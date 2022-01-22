namespace C.Fundamentos.Modulo03.Exercicio1
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
    public static class Resposta
    {
        public static void Executar()
        {
            try
            {
                Console.WriteLine("Digite a primeira nota do aluno:");
                double nota1 = LerEntrada();
                Console.WriteLine("Digite seu peso:");
                double peso1 = LerEntrada();

                Console.WriteLine("Digite a segunda nota do aluno:");
                double nota2 = LerEntrada();
                Console.WriteLine("Digite seu peso:");
                double peso2 = LerEntrada();

                Console.WriteLine("Digite a terceira nota do aluno:");
                double nota3 = LerEntrada();
                Console.WriteLine("Digite seu peso:");
                double peso3 = LerEntrada();

                double media = ((nota1 * peso1) + (nota2 * peso2) + (nota3 * peso3)) / (peso1 + peso2 + peso3);
                Console.WriteLine($"A média do aluno: {media}");
            }
            catch (FormatException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static double LerEntrada()
        {
            if (double.TryParse(Console.ReadLine(), out double valor))
            {
                return valor;
            }

            throw new FormatException("Não foi possível converter o valor digitado para um número válido.");
        }
    }
}
