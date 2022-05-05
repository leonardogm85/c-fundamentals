namespace C.Fundamentals.Module11.Question01
{
    /// <summary>
    /// <para>
    ///     Crie uma classe que representa produtos. Para cada objeto desta classe, deve ser fornecido
    ///     um nome (string), peso (double) e data de validade (DateTime).
    /// </para>
    /// <para>
    ///     Depois disso, implemente uma aplicação que cria três produtos, cujos dados são os seguintes:
    /// </para>
    /// <list type="bullet">
    ///     <item>
    ///         Nome: Feijão; Peso: 2,5; Data de Validade: 04/10/2020
    ///     </item>
    ///     <item>
    ///         Nome: Café; Peso: 1,0; Data de Validade: 01/01/2022
    ///     </item>
    ///     <item>
    ///         Nome: Beterraba; Peso: 0,9; Data de Validade: 12/11/2017
    ///     </item>
    /// </list>
    /// <para>
    ///     Com os produtos criados, escreva um código que exibe os dados de cada produto de uma
    ///     forma tabulada e de acordo com as seguintes regras:
    /// </para>
    /// <list type="bullet">
    ///     <item>
    ///         A primeira informação é um número sequencial, iniciando em 1.
    ///     </item>
    ///     <item>
    ///         A segunda informação é o nome do produto. Ele deve ocupar 12 caracteres. Caso seu
    ///         nome tenha menos que isso, ele deve ficar alinhado à direita e os caracteres que
    ///         faltam devem ser preenchidos com espaços em branco.
    ///     </item>
    ///     <item>
    ///         A terceira informação é o peso. Ele deve ter 2 casas decimais (separadas com o uso da
    ///         vírgula) e ocupar uma área de 9 caracteres. Se o número tiver menos de 9 caracteres,
    ///         ele deve ser preenchido com 0's à esquerda.
    ///     </item>
    ///     <item>
    ///         A quarta informação é a data de validade, que deve ser mostrada no padrão dia, mês e
    ///         ano.
    ///     </item>
    /// </list>
    /// <para>
    ///     Obeserve como deve ser o resultado final:
    /// </para>
    /// <code>
    ///     1)      Feijão 000002,50 04/10/2020
    ///     2)        Café 000001,00 01/01/2022
    ///     3)   Beterraba 000000,90 12/11/2017
    /// </code>
    /// <para>
    ///     Dica: Você pode usar o formato customizado 000000.00 para garantir que o peso tenha
    ///     tamanho 9 e sempre conte com 2 casas decimais.
    /// </para>
    /// </summary>
    internal static class Answer
    {
        internal static void Run()
        {
            Product bean = new Product(
                "Feijão",
                2.5,
                new DateTime(2020, 10, 4));

            Product coffee = new Product(
                "Café",
                1.0,
                new DateTime(2022, 1, 1));

            Product beet = new Product(
                "Beterraba",
                0.9,
                new DateTime(2017, 11, 12));

            Console.WriteLine(
                "{0}) {1,12} {2:000000.00} {3:dd/MM/yyyy}",
                1,
                bean.Name,
                bean.Weight,
                bean.ExpirationDate);

            Console.WriteLine(
                "{0}) {1,12} {2:000000.00} {3:dd/MM/yyyy}",
                2,
                coffee.Name,
                coffee.Weight,
                coffee.ExpirationDate);

            Console.WriteLine(
                "{0}) {1,12} {2:000000.00} {3:dd/MM/yyyy}",
                3,
                beet.Name,
                beet.Weight,
                beet.ExpirationDate);
        }

        internal class Product
        {
            public Product(string name, double weight, DateTime expirationDate)
            {
                Name = name;
                Weight = weight;
                ExpirationDate = expirationDate;
            }

            public string Name { get; private set; }
            public double Weight { get; private set; }
            public DateTime ExpirationDate { get; private set; }
        }
    }
}
