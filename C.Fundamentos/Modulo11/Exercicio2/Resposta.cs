namespace C.Fundamentos.Modulo11.Exercicio2
{
    /// <summary>
    /// Crie um programa que simula a mega-sena. O programa deve solicitar 6 números ao usuário,
    /// de 1 a 60. Depois ele deve sortear 6 números, mostrar os números sorteados e informar ao
    /// usuário quantos números ele acertou.
    /// </summary>
    public static class Resposta
    {
        public static void Executar()
        {
            int[] numeros = new int[6];
            int[] sorteados = new int[6];

            Random random = new Random();

            int acertos = 0;

            for (int i = 0; i < sorteados.Length; i++)
            {
                sorteados[i] = random.Next(1, 61);
            }

            Console.WriteLine("Simulação de um sorteio da mega-sena. Digite 6 números de 1 a 60:");

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Palpite {0}:", i + 1);
                numeros[i] = LerEntrada();

                for (int j = 0; j < sorteados.Length; j++)
                {
                    if (sorteados[j] == numeros[i])
                    {
                        acertos++;
                    }
                }
            }

            Console.WriteLine("Números digitados: {0}", string.Join(", ", numeros));
            Console.WriteLine("Números sorteados: {0}", string.Join(", ", sorteados));
            Console.WriteLine("Quantidade de acertos {0}", acertos);
        }

        private static int LerEntrada()
        {
            if (int.TryParse(Console.ReadLine(), out int valor))
            {
                return valor;
            }

            throw new FormatException("Não foi possível converter o valor digitado para um número válido.");
        }
    }
}
