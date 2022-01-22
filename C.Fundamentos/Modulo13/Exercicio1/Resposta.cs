namespace C.Fundamentos.Modulo13.Exercicio1
{
    /// <summary>
    /// <para>
    ///     Escreva um programa que solicite a entrada de 5 números inteiros via conosole, os quais
    ///     deverão ser armazenados em um array. Depois itere sobre os elementos do array e imprima
    ///     as seguintes informações na tela:
    /// </para>
    /// <list type="number">
    ///     <item>
    ///         Média entre os elementos do array.
    ///     </item>
    ///     <item>
    ///         Maior valor presente no array.
    ///     </item>
    ///     <item>
    ///         Menor valor presente no array.
    ///     </item>
    /// </list>
    /// <para>
    ///     Para finalizar, ordene os elementos do array em ordem decrescente e imprima os elementos.
    /// </para>
    /// </summary>
    public static class Resposta
    {
        public static void Executar()
        {
            int[] numeros = new int[5];

            Console.WriteLine("Digite 5 números:");

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Número {0}:", i + 1);
                numeros[i] = LerEntrada();
            }

            int total = 0;

            int maior = int.MinValue;
            int menor = int.MaxValue;

            foreach (int numero in numeros)
            {
                total += numero;

                maior = Math.Max(maior, numero);
                menor = Math.Min(menor, numero);
            }

            double media = (double)total / numeros.Length;

            Console.WriteLine($"Média: {media}");
            Console.WriteLine($"Maior: {maior}");
            Console.WriteLine($"Menor: {menor}");

            Array.Sort(numeros, new NumerosEmOrdemDecrescente());

            string numerosEmOrdemDecrescente = string.Join(", ", numeros);

            Console.WriteLine($"Números em ordem decrescente: {numerosEmOrdemDecrescente}");
        }

        private static int LerEntrada()
        {
            if (int.TryParse(Console.ReadLine(), out int valor))
            {
                return valor;
            }

            throw new FormatException("Não foi possível converter o valor digitado para um número válido.");
        }
    }

    public class NumerosEmOrdemDecrescente : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return -x.CompareTo(y);
        }
    }
}
