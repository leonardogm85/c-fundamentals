namespace C.Fundamentals.Module11.Question02
{
    /// <summary>
    /// Crie um programa que simula a mega-sena. O programa deve solicitar 6 números ao usuário,
    /// de 1 a 60. Depois ele deve sortear 6 números, mostrar os números sorteados e informar ao
    /// usuário quantos números ele acertou.
    /// </summary>
    internal static class Answer
    {
        internal static void Run()
        {
            int[] chosenNumbers = new int[6];
            int[] drawnNumbers = new int[6];

            Random random = new Random();

            int numberHits = 0;

            for (int i = 0; i < drawnNumbers.Length; i++)
            {
                drawnNumbers[i] = random.Next(1, 61);
            }

            Console.WriteLine("Simulação de um sorteio da mega-sena. Digite 6 números de 1 a 60:");

            for (int i = 0; i < chosenNumbers.Length; i++)
            {
                Console.WriteLine("Palpite {0}:", i + 1);
                chosenNumbers[i] = Read();

                for (int j = 0; j < drawnNumbers.Length; j++)
                {
                    if (drawnNumbers[j] == chosenNumbers[i])
                    {
                        numberHits++;
                    }
                }
            }

            Console.WriteLine("Números digitados: {0}", string.Join(", ", chosenNumbers));
            Console.WriteLine("Números sorteados: {0}", string.Join(", ", drawnNumbers));
            Console.WriteLine("Quantidade de acertos {0}", numberHits);
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
}
