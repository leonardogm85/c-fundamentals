namespace C.Fundamentos.Modulo10.Exercicio2
{
    /// <summary>
    /// <para>
    ///     Crie um enum chamado Bebida que pode assumir as opções Refrigerante, Suco e Agua,
    ///     com os respectivos valores 1, 2 e 3 associados.
    /// </para>
    /// <para>
    ///     Mostre no console as opções de bebidas existentes no enum e solicite ao usuário a digitação,
    ///     via console, de uma bebida(1, 2 ou 3). Mostre então o nome da bebida associada à opção
    ///     digitada.
    /// </para>
    /// <para>
    ///     Dica: Se você desejar converter a string retornada por Console.ReadLine() em um int,
    ///     você pode usar o método int.Parse() e fornecer a string como parâmetro. Caso a
    ///     conversão não possa ser realizada, esta chamada vai lançar uma exceção do tipo
    ///     FormatException.
    /// </para>
    /// </summary>
    public static class Resposta
    {
        public static void Executar()
        {
            try
            {
                Console.WriteLine("Escolha uma das opçcões de bebidas abaixo:");

                Bebida[] bebidas = Enum.GetValues<Bebida>();

                foreach (Bebida bebida in bebidas)
                {
                    Console.WriteLine($"{(int)bebida} - {bebida}");
                }

                int opcao = LerEntrada();

                if (Enum.IsDefined(typeof(Bebida), opcao))
                {
                    Bebida bebidaEscolhida = (Bebida)opcao;

                    Console.WriteLine($"Opção escolhida: {(int)bebidaEscolhida} - {bebidaEscolhida}");
                }
                else
                {
                    Console.WriteLine("Escolha uma opção válida.");
                }
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

    public enum Bebida
    {
        Refrigerante = 1,
        Suco = 2,
        Agua = 3
    }
}
