namespace C.Fundamentals.Module13.Question01
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
    internal static class Answer
    {
        internal static void Run()
        {
            int[] numbers = new int[5];

            Console.WriteLine("Digite 5 números:");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Número {0}:", i + 1);
                numbers[i] = Read();
            }

            int total = 0;

            int max = int.MinValue;
            int min = int.MaxValue;

            foreach (int number in numbers)
            {
                total += number;

                max = Math.Max(max, number);
                min = Math.Min(min, number);
            }

            double average = (double)total / numbers.Length;

            Console.WriteLine($"Média: {average}");
            Console.WriteLine($"Maior: {max}");
            Console.WriteLine($"Menor: {min}");

            Array.Sort(numbers, new NumbersInDescendingOrder());

            string numbersInDescendingOrder = string.Join(", ", numbers);

            Console.WriteLine($"Números em ordem decrescente: {numbersInDescendingOrder}");
        }

        private static int Read()
        {
            if (int.TryParse(Console.ReadLine(), out int value))
            {
                return value;
            }

            throw new FormatException("Não foi possível converter o valor digitado para um número válido.");
        }
    }

    internal class NumbersInDescendingOrder : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return -x.CompareTo(y);
        }
    }
}
