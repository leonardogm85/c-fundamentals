namespace C.Fundamentals.Module03.Question05
{
    /// <summary>
    /// <para>
    ///     Imprima os 15 primeiros números da série de Fibonacci. A série de Fibonacci possui a seguinte
    ///     sequência numérica: 0, 1, 1, 2, 3, 5, 8, 13, 21, etc.
    /// </para>
    /// <para>
    ///     Para calculá-la, o primeiro e segundo elementos valem 1, daí por diante, o n-ésimo elemento
    ///     vale o(n-1)-ésimo elemento somado ao(n-2)-ésimo elemento(ex: 8 = 5 + 3).
    /// </para>
    /// </summary>
    internal static class Answer
    {
        internal static void Run()
        {
            string? item = null;

            int last = 0;
            int penultimate = 0;

            for (int number = 0; number < 15; number++)
            {
                if (number == 0)
                {
                    item = number.ToString();
                }
                else if (number == 1)
                {
                    item += $", {number}";

                    last = 1;
                }
                else
                {
                    int current = last + penultimate;

                    penultimate = last;
                    last = current;

                    item += $", {current}";
                }
            }

            Console.WriteLine($"Resultado: {item}");
        }
    }
}
