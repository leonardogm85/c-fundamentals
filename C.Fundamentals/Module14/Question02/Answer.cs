namespace C.Fundamentals.Module14.Question02
{
    /// <summary>
    /// <para>
    ///     Crie um programa de votação, onde o usuário deve escolher a sua linguagem de programação
    ///     preferida dentre as seguintes opções:
    /// </para>
    /// <list type="number">
    ///     <item>
    ///         C#
    ///     </item>
    ///     <item>
    ///         Java
    ///     </item>
    ///     <item>
    ///         C
    ///     </item>
    ///     <item>
    ///         C++
    ///     </item>
    ///     <item>
    ///         Python
    ///     </item>
    /// </list>
    /// <para>
    ///     O programa solicita votos até que o número 0 seja escolhido. Quando isto acontecer, o
    ///     programa deverá mostrar a lista de opções em uma tabela, juntamente com o número de
    ///     votos de cada opção e a porcentagem de votos com relação ao total. A tabela também deve
    ///     mostrar, no final, o total de votos realizados.
    /// </para>
    /// <para>
    ///     Por fim, o programa deve mostrar qual foi a linguagem de programação mais votada, bem
    ///     como o número de votos que ela recebeu.
    /// </para>
    /// <para>
    ///     Algumas considerações importantes:
    /// </para>
    /// <list type="bullet">
    ///     <item>
    ///         As opções disponíveis para votação devem ser armazenadas em um dicionário, onde o
    ///         número de opção é mapeado para a linguagem de programação correspondente.
    ///     </item>
    ///     <item>
    ///         Os votos coletados devem ser armazenados em uma lista.
    ///     </item>
    ///     <item>
    ///         Se uma opção inválida for digitada, o programa deverá mostrar uma mensagem de
    ///         erro e solicitar novamente o voto.
    ///     </item>
    /// </list>
    /// </summary>
    internal static class Answer
    {
        internal static void Run()
        {
            Dictionary<int, string> options = new Dictionary<int, string>();

            options.Add(1, "C#");
            options.Add(2, "Java");
            options.Add(3, "C");
            options.Add(4, "C++");
            options.Add(5, "Python");

            List<int> votes = new List<int>();

            while (true)
            {// Choose your
                Console.WriteLine("Choose your preferred programming language (To end voting, enter 0):");

                foreach (KeyValuePair<int, string> option in options)
                {
                    Console.WriteLine(
                        "{0}. {1}",
                        option.Key,
                        option.Value);
                }

                try
                {
                    int vote = Read();

                    if (vote == 0)
                    {
                        break;
                    }

                    votes.Add(vote);
                }
                catch (FormatException exception)
                {
                    Console.WriteLine(exception.Message);
                }

                Console.WriteLine();
            }

            Dictionary<int, int> sumVotes = new Dictionary<int, int>();

            sumVotes.Add(1, 0);
            sumVotes.Add(2, 0);
            sumVotes.Add(3, 0);
            sumVotes.Add(4, 0);
            sumVotes.Add(5, 0);

            foreach (int voto in votes)
            {
                sumVotes[voto]++;
            }

            int totalVotes = votes.Count;

            int codeOption = -1;
            int sumOption = -1;

            Console.WriteLine();

            Console.WriteLine(
                "{0,-25}{1,8}{2,10}",
                "Programming language",
                "Votes",
                "%");

            Console.WriteLine(
                "{0,-25}{1,8}{2,10}",
                "------------------------",
                "-----",
                "-");

            foreach (KeyValuePair<int, string> option in options)
            {
                if (sumVotes[option.Key] > sumOption)
                {
                    codeOption = option.Key;
                    sumOption = sumVotes[option.Key];
                }

                int count = sumVotes[option.Key];
                double average = totalVotes == 0
                    ? 0
                    : (double)count / totalVotes;

                Console.WriteLine(
                    "{0,-25}{1,8}{2,10:p}",
                    option.Value,
                    count,
                    average);
            }

            Console.WriteLine(
                "{0,-25}{1,8}",
                "------------------------",
                "-----");

            Console.WriteLine(
                "{0,-25}{1,8}",
                "Total",
                totalVotes);

            Console.WriteLine(
                "Option {0} received the most votes, with {1} vote(s).",
                options[codeOption],
                sumOption);
        }

        private static int Read()
        {
            if (int.TryParse(Console.ReadLine(), out int value) && value >= 0 && value <= 5)
            {
                return value;
            }

            throw new FormatException("An invalid option was given. Please vote again.");
        }
    }
}
