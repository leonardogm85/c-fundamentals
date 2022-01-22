namespace C.Fundamentos.Modulo04.Exercicio1
{
    /// <summary>
    /// <para>
    ///     Crie as classes Relogio e Ponteiro e escreva um método Executar() para treinar a chamada aos
    ///     métodos e fields.
    /// </para>
    /// <para>
    ///     Fields da classe Relogio:
    /// </para>
    /// <list type="bullet">
    ///     <item>
    ///         ponteiroHora (tipo Ponteiro)
    ///     </item>
    ///     <item>
    ///         ponteiroMinuto (tipo Ponteiro)
    ///     </item>
    ///     <item>
    ///         ponteiroSegundo (tipo Ponteiro)
    ///     </item>
    /// </list>
    /// <para>
    ///     Métodos da classe Relogio:
    /// </para>
    /// <list type="bullet">
    ///     <item>
    ///         AcertarRelogio(int, int, int): Acerta o relógio, posicionando adequadamente cada
    ///         ponteiro do relógio.Os parâmetros passados são hora, minuto e segundo.
    ///     </item>
    ///     <item>
    ///         LerHora(): retorna a hora atual do relógio.
    ///     </item>
    ///     <item>
    ///         LerMinuto(): retorna o minuto atual do relógio.
    ///     </item>
    ///     <item>
    ///         LerSegundo(): retorna o segundo atual do relógio.
    ///     </item>
    /// </list>
    /// <para>
    ///     Fields da classe Ponteiro:
    /// </para>
    /// <list type="bullet">
    ///     <item>
    ///         posicao(int): indica em qual posição está o ponteiro (1, 2, 3, 4, etc.).
    ///     </item>
    /// </list>
    /// </summary>
    public static class Resposta
    {
        public static void Executar()
        {
            Relogio relogio1 = new Relogio();

            relogio1.AcertarRelogio(0, 30, 50);

            Console.WriteLine("Primeiro relôgio:");

            Console.WriteLine($"Posição do Hora: {relogio1.ponteiroHora.posicao}");
            Console.WriteLine($"Posição do Minuto: {relogio1.ponteiroMinuto.posicao}");
            Console.WriteLine($"Posição do Segundo: {relogio1.ponteiroSegundo.posicao}");

            Console.WriteLine($"Hora: {relogio1.LerHora()}");
            Console.WriteLine($"Minuto: {relogio1.LerMinuto()}");
            Console.WriteLine($"Segundo: {relogio1.LerSegundo()}");

            Relogio relogio2 = new Relogio();

            relogio2.AcertarRelogio(10, 10, 10);

            Console.WriteLine("Segundo relôgio:");

            Console.WriteLine($"Posição do Hora: {relogio2.ponteiroHora.posicao}");
            Console.WriteLine($"Posição do Minuto: {relogio2.ponteiroMinuto.posicao}");
            Console.WriteLine($"Posição do Segundo: {relogio2.ponteiroSegundo.posicao}");

            Console.WriteLine($"Hora: {relogio2.LerHora()}");
            Console.WriteLine($"Minuto: {relogio2.LerMinuto()}");
            Console.WriteLine($"Segundo: {relogio2.LerSegundo()}");

            Relogio relogio3 = new Relogio();

            relogio3.AcertarRelogio(22, 40, 30);

            Console.WriteLine("Terceiro relôgio:");

            Console.WriteLine($"Posição do Hora: {relogio3.ponteiroHora.posicao}");
            Console.WriteLine($"Posição do Minuto: {relogio3.ponteiroMinuto.posicao}");
            Console.WriteLine($"Posição do Segundo: {relogio3.ponteiroSegundo.posicao}");

            Console.WriteLine($"Hora: {relogio3.LerHora()}");
            Console.WriteLine($"Minuto: {relogio3.LerMinuto()}");
            Console.WriteLine($"Segundo: {relogio3.LerSegundo()}");
        }
    }

    public class Relogio
    {
        public Ponteiro ponteiroHora = new Ponteiro();
        public Ponteiro ponteiroMinuto = new Ponteiro();
        public Ponteiro ponteiroSegundo = new Ponteiro();

        public void AcertarRelogio(int hora, int minuto, int segundo)
        {
            ponteiroHora.posicao = hora % 12;
            ponteiroMinuto.posicao = minuto / 5;
            ponteiroSegundo.posicao = segundo / 5;
        }

        public int LerHora()
        {
            return ponteiroHora.posicao;
        }

        public int LerMinuto()
        {
            return ponteiroMinuto.posicao * 5;
        }

        public int LerSegundo()
        {
            return ponteiroSegundo.posicao * 5;
        }
    }

    public class Ponteiro
    {
        public int posicao;
    }
}
