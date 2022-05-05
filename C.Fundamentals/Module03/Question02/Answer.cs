namespace C.Fundamentals.Module03.Question02
{
    /// <summary>
    /// Escreva um programa semelhante ao do exercício 1, mas agora o número de notas e pesos
    /// pode variar. O usuário deve digitar quantas notas ele desejar e, para parar, a nota -1 deve ser
    /// digitada. Neste momento a média das notas e pesos digitados anteriormente deve ser
    /// calculada e o resultado impresso na tela.
    /// </summary>
    internal static class Answer
    {
        internal static void Run()
        {
            try
            {
                int count = 0;

                double numerator = 0;
                double denominator = 0;

                while (true)
                {
                    Console.WriteLine($"Digite a nota {++count} do aluno (ou -1 para finalizar):");
                    double grade = Read();

                    if (grade == -1)
                    {
                        break;
                    }

                    Console.WriteLine("Digite seu peso:");
                    double weight = Read();

                    numerator += grade * weight;
                    denominator += weight;
                }

                double average = numerator / denominator;
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
