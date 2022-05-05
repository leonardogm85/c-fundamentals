namespace C.Fundamentals.Module03.Question03
{
    /// <summary>
    /// <para>
    ///     Neste exercício, você deve completar 4 tarefas:
    /// </para>
    /// <list type="number">
    ///     <item>
    ///         Imprima todos os números de 10 a 25.
    ///     </item>
    ///     <item>
    ///         Imprima a soma dos números de 1 a 100, pulando de dois em dois (1, 3, 5, 7, etc.).
    ///     </item>
    ///     <item>
    ///         Começando em 0, imprima os números seguintes, enquanto a soma dos números já
    ///         impressos for menor que 100.
    ///     </item>
    ///     <item>
    ///         Imprima a tabuada do 9 (até o décimo valor).
    ///     </item>
    /// </list>
    /// </summary>
    internal static class Answer
    {
        internal static void Run()
        {
            Item1();
            Item2();
            Item3();
            Item4();
        }

        private static void Item1()
        {
            string? item = null;

            for (int number = 10; number <= 25; number++)
            {
                if (item == null)
                {
                    item = number.ToString();
                }
                else
                {
                    item += $", {number}";
                }
            }

            Console.WriteLine($"Item 1: {item}");
        }

        private static void Item2()
        {
            int sum = 0;

            for (int number = 1; number <= 100; number += 2)
            {
                sum += number;
            }

            Console.WriteLine($"Item 2: {sum}");
        }

        private static void Item3()
        {
            string? item = null;

            int number = 0;
            int sum = 0;

            while (sum < 100)
            {
                if (item == null)
                {
                    item = number.ToString();
                }
                else
                {
                    item += $", {number}";
                }

                sum += number;
                number++;
            }

            Console.WriteLine($"Item 3: {item}");
        }

        private static void Item4()
        {
            string? item = null;

            for (int number = 0; number <= 10; number++)
            {
                int result = number * 9;

                if (item == null)
                {
                    item = result.ToString();
                }
                else
                {
                    item += $", {result}";
                }
            }

            Console.WriteLine($"Item 4: {item}");
        }
    }
}
