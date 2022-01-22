namespace C.Fundamentos.Modulo13.Exercicio3
{
    /// <summary>
    /// <para>
    ///     Faça um programa que cria uma matriz de inteiros de duas dimensões e atribui valores a cada
    ///     uma das posições desta matriz. O número de linhas, de colunas e os valores a serem
    ///     atribuídos para cada posição devem ser lidos via console.
    /// </para>
    /// <para>
    ///     Na sequência, imprima a matriz e calcule a soma dos elementos de cada coluna. Esta soma
    ///     deve ser armazenada em um array. Por exemplo, se a matriz tem tamanho 3x4, você deverá
    ///     criar uma array de 4 posições, onde cada posição armazenará a soma dos 3 valores da coluna.
    ///     Os valores das somas também deverão ser mostrados.
    /// </para>
    /// </summary>
    public static class Resposta
    {
        public static void Executar()
        {
            Console.WriteLine("Criar uma matriz de inteiros de duas dimensões:");

            Console.WriteLine("Qual o número de linhas:");
            int quantidadeLinhas = LerEntrada();

            Console.WriteLine("Qual o número de colunas:");
            int quantidadeColunas = LerEntrada();

            Console.WriteLine();

            int[,] matriz = new int[quantidadeLinhas, quantidadeColunas];
            int[] soma = new int[quantidadeColunas];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine("Qual o valor da posição [{0}, {1}]", i, j);
                    int valor = LerEntrada();
                    matriz[i, j] = valor;
                    soma[j] += valor;
                }
            }

            Console.WriteLine();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("{0,-5} ", matriz[i, j]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < soma.Length; i++)
            {
                Console.Write("{0,-5} ", soma[i]);
            }
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
