namespace C.Fundamentals.Module15.Question01
{
    /// <summary>
    /// <para>
    ///     Escreva uma aplicação para gerenciar itens de uma lista de compras. Ela deve funcionar da
    ///     seguinte forma.
    /// </para>
    /// <para>
    ///     Quando executada, a aplicação deve solicitar que o usuário escreva o nome de um item e
    ///     pressione ENTER. Quando fizer isto, este item deve ser armazenado num arquivo chamado
    ///     lista.txt. A aplicação fica em loop solicitando um item após o outro, até o momento que o
    ///     usuário digitar o item "0". Quando ele fizer isto, a aplicação termina. Outro detalhe é que não
    ///     deve ser permitido que o usuário insira itens vazios (como, por exemplo, só espaços em
    ///     branco ou apenas um ENTER). Nestes casos, a aplicação deve desconsiderar o item e solicitar
    ///     o próximo.
    /// </para>
    /// <para>
    ///     Mais um requisito da aplicação é que, quando aberta, ela deve verificar se o arquivo lista.txt
    ///     existe e se possui itens cadastrados. Caso isto seja verdadeiro, antes de solicitar a entrada de
    ///     novos itens, os itens já cadastrados devem ser mostrados na tela. Quando o usuário adicionar
    ///     novos itens, os itens já cadastrados não devem ser apagados (os novos devem ser adicionados
    ///     no fim do arquivo).
    /// </para>
    /// </summary>
    internal static class Answer
    {
        internal static void Run()
        {
            Console.WriteLine("Manager your shopping list.");
            Console.WriteLine();

            string path = @"list.txt";

            if (File.Exists(path))
            {
                using (StreamReader reader = File.OpenText(path))
                {
                    string? item = reader.ReadLine();

                    if (!string.IsNullOrWhiteSpace(item))
                    {
                        Console.WriteLine("You already have the following items on your shopping list:");

                        do
                        {
                            Console.WriteLine(item);
                            item = reader.ReadLine();
                        }
                        while (!string.IsNullOrWhiteSpace(item));

                        Console.WriteLine();
                    }
                }
            }

            Console.WriteLine("Enter the items on your shopping list (Or enter 0 to end).");
            Console.WriteLine();

            using (StreamWriter writer = File.AppendText(path))
            {
                while (true)
                {
                    Console.Write("Enter the item: ");
                    string? item = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(item))
                    {
                        continue;
                    }

                    if (item == "0")
                    {
                        break;
                    }

                    writer.WriteLine(item);
                }
            }
        }
    }
}
