namespace C.Fundamentals.Module03.Question01
{
    /// <summary>
    /// <para>
    ///     Escreva um programa que solicita que sejam digitadas três notas de um aluno e um peso para
    ///     cada nota. Calcule e imprima a média do aluno.
    /// </para>
    /// <para>
    ///     Dica: Para ler as notas via console e convertê-las para double, você pode utilizar:
    /// </para>
    /// <code>
    ///     double nota1 = double.Parse(Console.ReadLine());
    /// </code>
    /// </summary>
    internal static class Answer
    {
        internal static void Run()
        {
            try
            {
                Console.WriteLine("Digite a primeira nota do aluno:");
                double grade1 = Read();
                Console.WriteLine("Digite seu peso:");
                double weight1 = Read();

                Console.WriteLine("Digite a segunda nota do aluno:");
                double grade2 = Read();
                Console.WriteLine("Digite seu peso:");
                double weight2 = Read();

                Console.WriteLine("Digite a terceira nota do aluno:");
                double grade3 = Read();
                Console.WriteLine("Digite seu peso:");
                double weight3 = Read();

                double average = ((grade1 * weight1) + (grade2 * weight2) + (grade3 * weight3)) / (weight1 + weight2 + weight3);
                Console.WriteLine($"A média do aluno: {average}");
            }
            catch (FormatException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static double Read()
        {
            if (double.TryParse(Console.ReadLine(), out double value))
            {
                return value;
            }

            throw new FormatException("Não foi possível converter o valor digitado para um número válido.");
        }
    }
}
