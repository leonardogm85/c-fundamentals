namespace C.Fundamentos.Modulo03.Exercicio7
{
    /// <summary>
    /// Verifique a validade de uma data e mostre uma mensagem na tela dizendo se a data é válida ou
    /// inválida. Devem existir três variáveis para armazenar o dia, o mês e o ano, e o usuário deve
    /// fornecer os valores para estas variáveis via console. Considerar que fevereiro pode ter
    /// somente 28 dias e que anos válidos estão compreendidos entre 1900 e 2999.
    /// </summary>
    public static class Resposta
    {
        public static void Executar()
        {
            try
            {
                Console.WriteLine("Digite o dia:");
                int dia = LerEntrada();

                Console.WriteLine("Digite o mês:");
                int mes = LerEntrada();

                Console.WriteLine("Digite o ano:");
                int ano = LerEntrada();

                if (ano < 1900 || ano > 2999)
                {
                    Console.WriteLine("Data inválida");

                    return;
                }

                if (mes < 1 || mes > 12)
                {
                    Console.WriteLine("Data inválida");

                    return;
                }

                if (mes == 2 && (dia < 1 || dia > 28))
                {
                    Console.WriteLine("Data inválida");

                    return;
                }

                if ((mes == 4 || mes == 6 || mes == 9 || mes == 11) && (dia < 1 || dia > 30))
                {
                    Console.WriteLine("Data inválida");

                    return;
                }

                if (dia < 1 || dia > 31)
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
