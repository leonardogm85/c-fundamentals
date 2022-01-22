namespace C.Fundamentos.Modulo15.Exercicio2
{
    /// <summary>
    /// <para>
    ///     Primeiramente crie duas classes, Livro e Autor, de acordo com o demonstrado no diagrama
    ///     abaixo:
    /// </para>
    /// <list type="bullet">
    ///     <item>
    ///         <para>
    ///             Livro
    ///         </para>
    ///         <list type="table">
    ///             <item>
    ///                 + <![CDATA[<<property>>]]> Titulo : string
    ///             </item>
    ///             <item>
    ///                 + <![CDATA[<<property>>]]> NumPaginas : int
    ///             </item>
    ///             <item>
    ///                 + <![CDATA[<<property>>]]> Autor : Autor
    ///             </item>
    ///         </list>
    ///     </item>
    ///     <item>
    ///         <para>
    ///             Autor
    ///         </para>
    ///         <list type="table">
    ///             <item>
    ///                 + <![CDATA[<<property>>]]> Nome : string
    ///             </item>
    ///             <item>
    ///                 + <![CDATA[<<property>>]]> DataNascimento : DateTime
    ///             </item>
    ///         </list>
    ///     </item>
    /// </list>
    /// <para>
    ///     Crie também uma interface IRecordable, que declara dois métodos:
    /// </para>
    /// <code>
    ///     void Read(BinaryReader reader)
    ///     void Write(BinaryWriter writer)
    /// </code>
    /// <para>
    ///     Faça com que Livro e Autor implementem esta interface. Classes que implementam esta
    ///     interface devem codificar a forma como seus próprios atributos são gravados e lidos no
    ///     arquivo, através de chamadas aos objetos in e out.
    /// </para>
    /// <para>
    ///     A aplicação deve pedir para que o usuário escolha entre duas opções: gravar ou ler os dados.
    ///     Caso a opção de gravar seja escolhida, dois objetos Livro devem ser criados e gravados em um
    ///     arquivo. Já se a opção de leitura for escolhida, estes dois objetos devem ser lidos do arquivo e
    ///     impressos no console.
    /// </para>
    /// </summary>
    public static class Resposta
    {
        public static void Executar()
        {
            Console.WriteLine("Escolha entre gravar ou ler os dados de um arquivo.");
            Console.WriteLine("1. Gravar");
            Console.WriteLine("2. Ler");

            string path = @"livro.bin";

            int opcao = LerEntrada();

            Console.WriteLine();

            if (opcao == 1)
            {
                using (FileStream stream = File.OpenWrite(path))
                {
                    using (BinaryWriter writer = new BinaryWriter(stream))
                    {
                        Livro livro1 = new Livro
                        {
                            Titulo = "Código Limpo",
                            NumPaginas = 400,
                            Autor = new Autor
                            {
                                Nome = "Robert C. Martin",
                                DataNascimento = new DateTime(1960, 12, 31)
                            }
                        };

                        Livro livro2 = new Livro
                        {
                            Titulo = "Refatoração",
                            NumPaginas = 450,
                            Autor = new Autor
                            {
                                Nome = "Martin Fowler",
                                DataNascimento = new DateTime(1970, 12, 31)
                            }
                        };

                        livro1.Write(writer);
                        livro2.Write(writer);

                        Console.WriteLine(livro1);
                        Console.WriteLine(livro2);
                    }
                }

                return;
            }

            using (FileStream stream = File.OpenRead(path))
            {
                using (BinaryReader reader = new BinaryReader(stream))
                {
                    Livro livro1 = new Livro();
                    Livro livro2 = new Livro();

                    livro1.Read(reader);
                    livro2.Read(reader);

                    Console.WriteLine(livro1);
                    Console.WriteLine(livro2);
                }
            }
        }

        private static int LerEntrada()
        {
            if (int.TryParse(Console.ReadLine(), out int valor))
            {
                if (valor == 1 || valor == 2)
                {
                    return valor;
                }

                throw new FormatException("Não foi possível converter o valor digitado para um número válido.");

            }

            throw new FormatException("Não foi possível converter o valor digitado para um número válido.");
        }
    }

    public class Livro : IRecordable
    {
        public string? Titulo { get; set; }
        public int? NumPaginas { get; set; }
        public Autor? Autor { get; set; }

        public void Read(BinaryReader reader)
        {
            string titulo = reader.ReadString();
            int numPaginas = reader.ReadInt32();

            Titulo = titulo == string.Empty
                ? null
                : titulo;
            NumPaginas = numPaginas == 0
                ? null
                : numPaginas;

            (Autor ??= new Autor()).Read(reader);
        }

        public void Write(BinaryWriter writer)
        {
            writer.Write(Titulo ?? string.Empty);
            writer.Write(NumPaginas ?? 0);

            (Autor ?? new Autor()).Write(writer);
        }

        public override string ToString()
        {
            return $"[Título: {Titulo}, Número de página(s): {NumPaginas}, Autor: {Autor}]";
        }
    }

    public class Autor : IRecordable
    {
        public string? Nome { get; set; }
        public DateTime? DataNascimento { get; set; }

        public void Read(BinaryReader reader)
        {
            string nome = reader.ReadString();
            long dataNascimento = reader.ReadInt64();

            Nome = nome == string.Empty
                ? null
                : nome;
            DataNascimento = dataNascimento == 0
                ? null
                : DateTime.FromBinary(dataNascimento);
        }

        public void Write(BinaryWriter writer)
        {
            writer.Write(Nome ?? string.Empty);
            writer.Write(DataNascimento?.ToBinary() ?? 0);
        }

        public override string ToString()
        {
            return $"[Nome: {Nome}, Data de nascimento: {DataNascimento:dd/MM/yyyy}]";
        }
    }

    public interface IRecordable
    {
        void Read(BinaryReader reader);
        void Write(BinaryWriter writer);
    }
}
