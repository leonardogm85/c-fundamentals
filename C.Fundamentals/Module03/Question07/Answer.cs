namespace C.Fundamentals.Module03.Question07
{
    /// <summary>
    /// Verifique a validade de uma data e mostre uma mensagem na tela dizendo se a data é válida ou
    /// inválida. Devem existir três variáveis para armazenar o dia, o mês e o ano, e o usuário deve
    /// fornecer os valores para estas variáveis via console. Considerar que fevereiro pode ter
    /// somente 28 dias e que anos válidos estão compreendidos entre 1900 e 2999.
    /// </summary>
    internal static class Answer
    {
        internal static void Run()
        {
            try
            {
                Console.WriteLine("Digite o dia:");
                int day = Read();

                Console.WriteLine("Digite o mês:");
                int month = Read();

                Console.WriteLine("Digite o ano:");
                int year = Read();

                if (year < 1900 || year > 2999)
                {
                    Console.WriteLine("Data inválida");

                    return;
                }

                if (month < 1 || month > 12)
                {
                    Console.WriteLine("Data inválida");

                    return;
                }

                if (month == 2 && (day < 1 || day > 28))
                {
                    Console.WriteLine("Data inválida");

                    return;
                }

                if ((month == 4 || month == 6 || month == 9 || month == 11) && (day < 1 || day > 30))
                {
                    Console.WriteLine("Data inválida");

                    return;
                }

                if (day < 1 || day > 31)
                {
                    Console.WriteLine("Data inválida");

                    return;
                }

                Console.WriteLine("Data válida");
            }
            catch (FormatException exception)
            {
                Console.WriteLine(exception.Message);
            }
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
