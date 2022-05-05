namespace C.Fundamentals.Module04.Question01
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
    internal static class Answer
    {
        internal static void Run()
        {
            Watch watch1 = new Watch();

            watch1.Set(0, 30, 50);

            Console.WriteLine("Primeiro relôgio:");

            Console.WriteLine($"Posição do Hora: {watch1.hourHand.position}");
            Console.WriteLine($"Posição do Minuto: {watch1.minuteHand.position}");
            Console.WriteLine($"Posição do Segundo: {watch1.secondHand.position}");

            Console.WriteLine($"Hora: {watch1.ReadHour()}");
            Console.WriteLine($"Minuto: {watch1.ReadMinute()}");
            Console.WriteLine($"Segundo: {watch1.ReadSecond()}");

            Watch watch2 = new Watch();

            watch2.Set(10, 10, 10);

            Console.WriteLine("Segundo relôgio:");

            Console.WriteLine($"Posição do Hora: {watch2.hourHand.position}");
            Console.WriteLine($"Posição do Minuto: {watch2.minuteHand.position}");
            Console.WriteLine($"Posição do Segundo: {watch2.secondHand.position}");

            Console.WriteLine($"Hora: {watch2.ReadHour()}");
            Console.WriteLine($"Minuto: {watch2.ReadMinute()}");
            Console.WriteLine($"Segundo: {watch2.ReadSecond()}");

            Watch watch3 = new Watch();

            watch3.Set(22, 40, 30);

            Console.WriteLine("Terceiro relôgio:");

            Console.WriteLine($"Posição do Hora: {watch3.hourHand.position}");
            Console.WriteLine($"Posição do Minuto: {watch3.minuteHand.position}");
            Console.WriteLine($"Posição do Segundo: {watch3.secondHand.position}");

            Console.WriteLine($"Hora: {watch3.ReadHour()}");
            Console.WriteLine($"Minuto: {watch3.ReadMinute()}");
            Console.WriteLine($"Segundo: {watch3.ReadSecond()}");
        }
    }

    internal class Watch
    {
        public Pointer hourHand = new Pointer();
        public Pointer minuteHand = new Pointer();
        public Pointer secondHand = new Pointer();

        public void Set(int hour, int minute, int second)
        {
            hourHand.position = hour % 12;
            minuteHand.position = minute / 5;
            secondHand.position = second / 5;
        }

        public int ReadHour()
        {
            return hourHand.position;
        }

        public int ReadMinute()
        {
            return minuteHand.position * 5;
        }

        public int ReadSecond()
        {
            return secondHand.position * 5;
        }
    }

    internal class Pointer
    {
        public int position;
    }
}
