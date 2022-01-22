namespace C.Fundamentos.Modulo14.Exercicio2
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
    public static class Resposta
    {
        public static void Executar()
        {
            Dictionary<int, string> opcoes = new Dictionary<int, string>();

            opcoes.Add(1, "C#");
            opcoes.Add(2, "Java");
            opcoes.Add(3, "C");
            opcoes.Add(4, "C++");
            opcoes.Add(5, "Python");

            List<int> votos = new List<int>();

            while (true)
            {
                Console.WriteLine("Escolha a sua linguagem de programação preferida (Para encerrar a votação informar 0):");

                foreach (KeyValuePair<int, string> opcao in opcoes)
                {
                    Console.WriteLine(
                        "{0}. {1}",
                        opcao.Key,
                        opcao.Value);
                }

                try
                {
                    int voto = LerEntrada();

                    if (voto == 0)
                    {
                        break;
                    }

                    votos.Add(voto);
                }
                catch (FormatException exception)
                {
                    Console.WriteLine(exception.Message);
                }

                Console.WriteLine();
            }

            Dictionary<int, int> somatorio = new Dictionary<int, int>();

            somatorio.Add(1, 0);
            somatorio.Add(2, 0);
            somatorio.Add(3, 0);
            somatorio.Add(4, 0);
            somatorio.Add(5, 0);

            foreach (int voto in votos)
            {
                somatorio[voto]++;
            }

            int totalVotos = votos.Count;

            int codigoOpcao = -1;
            int somaOpcao = -1;

            Console.WriteLine();

            Console.WriteLine(
                "{0,-25}{1,8}{2,10}",
                "Linguagem de Programacao",
                "Votos",
                "%");

            Console.WriteLine(
                "{0,-25}{1,8}{2,10}",
                "------------------------",
                "-----",
                "-");

            foreach (KeyValuePair<int, string> opcao in opcoes)
            {
                if (somatorio[opcao.Key] > somaOpcao)
                {
                    codigoOpcao = opcao.Key;
                    somaOpcao = somatorio[opcao.Key];
                }

                int quantidadeVotos = somatorio[opcao.Key];
                double mediaVotos = totalVotos == 0
                    ? 0
                    : (double)quantidadeVotos / totalVotos;

                Console.WriteLine(
                    "{0,-25}{1,8}{2,10:p}",
                    opcao.Value,
                    quantidadeVotos,
                    mediaVotos);
            }

            Console.WriteLine(
                "{0,-25}{1,8}",
                "------------------------",
                "-----");

            Console.WriteLine(
                "{0,-25}{1,8}",
                "Total",
                totalVotos);

            Console.WriteLine(
                "A opção {0} foi a mais votada, com {1} voto(s).",
                opcoes[codigoOpcao],
                somaOpcao);
        }

        private static int LerEntrada()
        {
            if (int.TryParse(Console.ReadLine(), out int valor))
            {
                if (valor < 0 || valor > 5)
                {
                    throw new FormatException("Foi informada uma opção inválida. Favor votar novamente.");
                }

                return valor;
            }

            throw new FormatException("Foi informada uma opção inválida. Favor votar novamente.");
        }
    }
}
