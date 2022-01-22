namespace C.Fundamentos.Modulo14.Exercicio1
{
    /// <summary>
    /// <para>
    ///     Crie uma classe Produto com dois fields: nome (string) e valor (double). Implemente a
    ///     interface IComparable <![CDATA[<T>]]> de forma que os produtos possam ser ordenados em ordem
    ///     crescente de valor quando necessário. Sobrescreva também os métodos Equals() e
    ///     GetHashCode() e implemente a interface IEquatable <![CDATA[<T>]]> , considerando que produtos iguais
    ///     são produtos que possuem o mesmo nome. E por último sobrescreva também o método
    ///     ToString(), para mostrar uma representação amigável do produto quando ele for impresso
    ///     no console.
    /// </para>
    /// <para>
    ///     Na seguência crie uma classe Produtos, responsável por armazenar os produtos criados. Esta
    ///     classe tem um field produtos, do tipo ICollection <![CDATA[<Produto>]]> , e os métodos Adicionar(),
    ///     que adiciona um produto à coleção, e ImprimirProdutos(), que imprime todos os produtos.
    /// </para>
    /// <para>
    ///     Crie uma aplicação que cria os seguintes produtos:
    /// </para>
    /// <list type="bullet">
    ///     <item>
    ///         Nome: Laranja; Valor: 2,50
    ///     </item>
    ///     <item>
    ///         Nome: Laranja; Valor: 2,70
    ///     </item>
    ///     <item>
    ///         Nome: Maçã; Valor: 1,45
    ///     </item>
    ///     <item>
    ///         Nome: Mamão; Valor: 4,95
    ///     </item>
    ///     <item>
    ///         Nome: Limão; Valor: 2,30
    ///     </item>
    /// </list>
    /// <para>
    ///     Experimente adicionar os produtos acima a coleções de diversos tipo, como List <![CDATA[<T>]]> ,
    ///     HashSet <![CDATA[<T>]]> e SortedSet <![CDATA[<T>]]> , e imprima os resultados. Lembre-se que todos estes tipos
    ///     podem ser atribuídos ao field produtos, pois todos são do tipo ICollection <![CDATA[<T>]]> . Procure
    ///     perceber o que acontece com os elementos quando você muda o tipo de coleção na qual o
    ///     produto está inserido, com relação à duplicidade de elementos e ordenação.
    /// </para>
    /// </summary>
    public static class Resposta
    {
        public static void Executar()
        {
            Imprimir(new List<Produto>());
            Imprimir(new HashSet<Produto>());
            Imprimir(new SortedSet<Produto>());
        }
        public static void Imprimir(ICollection<Produto> itens)
        {
            Produtos produtos = new Produtos(itens);

            Produto produto1 = new Produto("Laranja", 2.5);
            Produto produto2 = new Produto("Laranja", 2.7);
            Produto produto3 = new Produto("Maçã", 1.45);
            Produto produto4 = new Produto("Mamão", 4.95);
            Produto produto5 = new Produto("Limão", 2.3);

            produtos.Adicionar(produto1);
            produtos.Adicionar(produto2);
            produtos.Adicionar(produto3);
            produtos.Adicionar(produto4);
            produtos.Adicionar(produto5);

            produtos.Imprimir();
        }
    }

    public class Produtos
    {
        ICollection<Produto> produtos;

        public Produtos(ICollection<Produto> produtos)
        {
            this.produtos = produtos;
        }

        public void Adicionar(Produto produto)
        {
            produtos.Add(produto);
        }

        public void Imprimir()
        {
            Console.WriteLine(produtos.GetType().Name);

            foreach (Produto produto in produtos)
            {
                Console.WriteLine(produto);
            }

            Console.WriteLine();
        }
    }

    public class Produto : IComparable<Produto>, IEquatable<Produto>
    {
        private string nome;
        private double valor;

        public Produto(string nome, double valor)
        {
            this.nome = nome;
            this.valor = valor;
        }

        public int CompareTo(Produto? other)
        {
            return valor.CompareTo(other?.valor);
        }

        public bool Equals(Produto? other)
        {
            return nome == other?.nome;
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Produto);
        }

        public override int GetHashCode()
        {
            return nome.GetHashCode();
        }

        public override string ToString()
        {
            return $"{nome,-10} {valor,7:c}";
        }
    }
}
