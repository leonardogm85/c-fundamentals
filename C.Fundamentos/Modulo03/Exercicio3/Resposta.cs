namespace C.Fundamentos.Modulo03.Exercicio3
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
    public static class Resposta
    {
        public static void Executar()
        {
            Item1();
            Item2();
            Item3();
            Item4();
        }

        private static void Item1()
        {
            string? item = null;

            for (int numero = 10; numero <= 25; numero++)
            {
                if (item == null)
                {
                    item = numero.ToString();
                }
                else
                {
                    item += $", {numero}";
                }
            }

            Console.WriteLine($"Item 1: {item}");
        }

        private static void Item2()
        {
            int soma = 0;

            for (int numero = 1; numero <= 100; numero += 2)
            {
                soma += numero;
            }

            Console.WriteLine($"Item 2: {soma}");
        }

        private static void Item3()
        {
            string? item = null;

            int numero = 0;
            int soma = 0;

            while (soma < 100)
            {
                if (item == null)
                {
                    item = numero.ToString();
                }
                else
                {
                    item += $", {numero}";
                }

                soma += numero;
                numero++;
            }

            Console.WriteLine($"Item 3: {item}");
        }

        private static void Item4()
        {
            string? item = null;

            for (int numero = 0; numero <= 10; numero++)
            {
                int resultado = numero * 9;

                if (item == null)
                {
                    item = resultado.ToString();
                }
                else
                {
                    item += $", {resultado}";
                }
            }

            Console.WriteLine($"Item 4: {item}");
        }
    }
}
