namespace C.Fundamentos.Modulo03.Exercicio2
{
    /// <summary>
    /// Escreva um programa semelhante ao do exercício 1, mas agora o número de notas e pesos
    /// pode variar. O usuário deve digitar quantas notas ele desejar e, para parar, a nota -1 deve ser
    /// digitada. Neste momento a média das notas e pesos digitados anteriormente deve ser
    /// calculada e o resultado impresso na tela.
    /// </summary>
    public static class Resposta
    {
        public static void Executar()
        {
            try
            {
                int count = 0;

                double numerador = 0;
                double denominador = 0;

                while (true)
                {
                    Console.WriteLine($"Digite a nota {++count} do aluno:");
                    double nota = LerEntrada();

                    if (nota == -1)
                    {
                        break;
                    }

                    Console.WriteLine("Digite seu peso:");
                    double peso = LerEntrada();

                    numerador += nota * peso;
                    denominador += peso;
                }

                double media = numerador / denominador;
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
