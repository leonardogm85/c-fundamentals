namespace C.Fundamentals.Module03.Question04
{
    /// <summary>
    /// <para>
    ///     Escreva um programa que calcule o fatorial de 10. A regra do fatorial (!) é a seguinte:
    /// </para>
    /// <code>
    ///     0! = 1
    ///     1! = 0! * 1
    ///     2! = 1! * 2
    ///     ...
    ///     n! = (n - 1)! * n
    /// </code>
    /// </summary>
    internal static class Answer
    {
        internal static void Run()
        {
            int sum = 0;

            for (int number = 0; number <= 10; number++)
            {
                if (number == 0)
                {
                    sum = 1;
                }
                else
                {
                    sum *= number;
                }
            }

            Console.WriteLine($"Resultado: {sum}");
        }
    }
}
