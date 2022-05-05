namespace C.Fundamentals.Module10.Question02
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
    internal static class Answer
    {
        internal static void Run()
        {
            try
            {
                Console.WriteLine("Escolha uma das opçcões de bebidas abaixo:");

                Drink[] drinks = Enum.GetValues<Drink>();

                foreach (Drink drink in drinks)
                {
                    Console.WriteLine($"{(int)drink} - {drink}");
                }

                int option = Read();

                if (Enum.IsDefined(typeof(Drink), option))
                {
                    Drink selectedDrink = (Drink)option;

                    Console.WriteLine($"Opção escolhida: {(int)selectedDrink} - {selectedDrink}");
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

        private static int Read()
        {
            if (int.TryParse(Console.ReadLine(), out int value))
            {
                return value;
            }

            throw new FormatException("Não foi possível converter o valor digitado para um número válido.");
        }
    }

    internal enum Drink
    {
        Soda = 1,
        Juice = 2,
        Water = 3
    }
}
