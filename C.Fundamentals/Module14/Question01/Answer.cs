namespace C.Fundamentals.Module14.Question01
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
    internal static class Answer
    {
        internal static void Run()
        {
            Print(new List<Product>());
            Print(new HashSet<Product>());
            Print(new SortedSet<Product>());
        }

        private static void Print(ICollection<Product> items)
        {
            Products products = new Products(items);

            Product product1 = new Product("Laranja", 2.5);
            Product product2 = new Product("Laranja", 2.7);
            Product product3 = new Product("Maçã", 1.45);
            Product product4 = new Product("Mamão", 4.95);
            Product product5 = new Product("Limão", 2.3);

            products.Add(product1);
            products.Add(product2);
            products.Add(product3);
            products.Add(product4);
            products.Add(product5);

            products.Print();
        }
    }

    public class Products
    {
        ICollection<Product> products;

        public Products(ICollection<Product> products)
        {
            this.products = products;
        }

        public void Add(Product product)
        {
            products.Add(product);
        }

        public void Print()
        {
            Console.WriteLine(products.GetType().Name);

            foreach (Product produt in products)
            {
                Console.WriteLine(produt);
            }

            Console.WriteLine();
        }
    }

    public class Product : IComparable<Product>, IEquatable<Product>
    {
        private string name;
        private double value;

        public Product(string name, double value)
        {
            this.name = name;
            this.value = value;
        }

        public int CompareTo(Product? other)
        {
            return value.CompareTo(other?.value);
        }

        public bool Equals(Product? other)
        {
            return name == other?.name;
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Product);
        }

        public override int GetHashCode()
        {
            return name.GetHashCode();
        }

        public override string ToString()
        {
            return $"{name,-10} {value,7:c}";
        }
    }
}
