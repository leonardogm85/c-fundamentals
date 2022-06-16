namespace C.Fundamentals.Module15.Question02
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
    internal static class Answer
    {
        internal static void Run()
        {
            Console.WriteLine("Choose between writing or reading data from a file.");
            Console.WriteLine("1. To write");
            Console.WriteLine("2. To read");

            string path = "book.bin";

            int option = Read();

            Console.WriteLine();

            if (option == 1)
            {
                using (FileStream stream = File.OpenWrite(path))
                {
                    using (BinaryWriter writer = new BinaryWriter(stream))
                    {
                        Book book1 = new Book
                        {
                            Title = "Clean Code",
                            PageNumber = 400,
                            Author = new Author
                            {
                                Name = "Robert C. Martin",
                                BirthDate = new DateTime(1960, 12, 31)
                            }
                        };

                        Book book2 = new Book
                        {
                            Title = "Refactoring",
                            PageNumber = 450,
                            Author = new Author
                            {
                                Name = "Martin Fowler",
                                BirthDate = new DateTime(1970, 12, 31)
                            }
                        };

                        book1.Write(writer);
                        book2.Write(writer);

                        Console.WriteLine(book1);
                        Console.WriteLine(book2);
                    }
                }

                return;
            }

            using (FileStream stream = File.OpenRead(path))
            {
                using (BinaryReader reader = new BinaryReader(stream))
                {
                    Book book1 = new Book();
                    Book book2 = new Book();

                    book1.Read(reader);
                    book2.Read(reader);

                    Console.WriteLine(book1);
                    Console.WriteLine(book2);
                }
            }
        }

        private static int Read()
        {
            if (int.TryParse(Console.ReadLine(), out int value) && (value == 1 || value == 2))
            {
                return value;
            }

            throw new FormatException("Could not convert the entered value to a valid number.");
        }
    }

    public interface IRecordable
    {
        void Read(BinaryReader reader);
        void Write(BinaryWriter writer);
    }

    public class Author : IRecordable
    {
        public string? Name { get; set; }
        public DateTime? BirthDate { get; set; }

        public void Read(BinaryReader reader)
        {
            string name = reader.ReadString();
            long birthDate = reader.ReadInt64();

            Name = name == string.Empty
                ? null
                : name;
            BirthDate = birthDate == 0
                ? null
                : DateTime.FromBinary(birthDate);
        }

        public void Write(BinaryWriter writer)
        {
            writer.Write(Name ?? string.Empty);
            writer.Write(BirthDate?.ToBinary() ?? 0);
        }

        public override string ToString()
        {
            return $"[Name: {Name}, Birth date: {BirthDate:dd/MM/yyyy}]";
        }
    }

    public class Book : IRecordable
    {
        public string? Title { get; set; }
        public int? PageNumber { get; set; }
        public Author? Author { get; set; }

        public void Read(BinaryReader reader)
        {
            string title = reader.ReadString();
            int pageNumber = reader.ReadInt32();

            Title = title == string.Empty
                ? null
                : title;
            PageNumber = pageNumber == 0
                ? null
                : pageNumber;

            (Author ??= new Author()).Read(reader);
        }

        public void Write(BinaryWriter writer)
        {
            writer.Write(Title ?? string.Empty);
            writer.Write(PageNumber ?? 0);

            (Author ?? new Author()).Write(writer);
        }

        public override string ToString()
        {
            return $"[Title: {Title}, Number of page(s): {PageNumber}, Author: {Author}]";
        }
    }
}
