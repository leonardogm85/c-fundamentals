namespace C.Fundamentos.Modulo03.Exercicio6
{
    /// <summary>
    /// <para>
    ///     Escreva um programa que imprime na saída os valores assumidos por x. Esta variável x deve
    ///     iniciar com algum valor inteiro, fornecido pelo usuário. Se x for par, x deve receber o valor
    ///     dele mesmo somado com 5. Já se x for ímpar, x deve receber o valor dele multiplicado por 2.
    ///     O programa termina assim que x for maior que 1000. Por exemplo, para x = 10, a saída deve
    ///     ser: 15, 30, 35, 70, 75, 150, 155, 310, 315, 630, 635, 1270. Faça este exercício usando blocos if
    ///     e depois usando blocos switch.
    /// </para>
    /// <para>
    ///     Dica: Para ler o número inteiro via console e convertê-lo para int, você pode utilizar:
    /// </para>
    /// <code>
    ///     int x = int.Parse(Console.ReadLine());
    /// </code>
    /// </summary>
    public static class Resposta
    {
        public static void Executar()
        {
            try
            {
                Console.WriteLine("Digite um número entre 0 e 1000:");
                int x = LerEntrada();

                string? item = null;

                while (x < 1000)
                {
                    if (x % 2 == 0)
                    {
                        x += 5;
                    }
                    else
                    {
                        x *= 2;
                    }

                    if (item == null)
                    {
                        item = x.ToString();
                    }
                    else
                    {
                        item += $", {x}";
                    }
                }

                Console.WriteLine($"Resultado: {item}");
            }
            catch (FormatException exception)
            {
                Console.WriteLine(exception.Message);
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
