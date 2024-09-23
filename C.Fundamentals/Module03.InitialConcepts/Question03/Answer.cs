namespace C.Fundamentals.Module03.InitialConcepts.Question03;

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
        Task1();
        Task2();
        Task3();
        Task4();
    }

    private static void Task1()
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

        Console.WriteLine("Print all numbers from 10 to 25:");
        Console.WriteLine(item);
        Console.WriteLine();
    }

    private static void Task2()
    {
        int sum = 0;

        for (int number = 1; number <= 100; number += 2)
        {
            sum += number;
        }

        Console.WriteLine("Print the sum of the numbers from 1 to 100, skipping two by two (1, 3, 5, 7, etc.):");
        Console.WriteLine(sum);
        Console.WriteLine();
    }

    private static void Task3()
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

        Console.WriteLine("Starting at 0, print the following numbers, while the sum of the numbers already printed is less than 100:");
        Console.WriteLine(item);
        Console.WriteLine();
    }

    private static void Task4()
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

        Console.WriteLine("Print the 9 multiplication table (up to the tenth value):");
        Console.WriteLine(item);
        Console.WriteLine();
    }
}
