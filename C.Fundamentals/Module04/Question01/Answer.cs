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

            Console.WriteLine("First watch:");

            Console.WriteLine("Hour position: {0}", watch1.hourHand.position);
            Console.WriteLine("Minute position: {0}", watch1.minuteHand.position);
            Console.WriteLine("Second position: {0}", watch1.secondHand.position);

            Console.WriteLine("Hour: {0}", watch1.ReadHour());
            Console.WriteLine("Minute: {0}", watch1.ReadMinute());
            Console.WriteLine("Second: {0}", watch1.ReadSecond());

            Console.WriteLine();

            Watch watch2 = new Watch();

            watch2.Set(10, 10, 10);

            Console.WriteLine("Second watch:");

            Console.WriteLine("Hour position: {0}", watch2.hourHand.position);
            Console.WriteLine("Minute position: {0}", watch2.minuteHand.position);
            Console.WriteLine("Second position: {0}", watch2.secondHand.position);

            Console.WriteLine("Hour: {0}", watch2.ReadHour());
            Console.WriteLine("Minute: {0}", watch2.ReadMinute());
            Console.WriteLine("Second: {0}", watch2.ReadSecond());

            Console.WriteLine();

            Watch watch3 = new Watch();

            watch3.Set(22, 40, 30);

            Console.WriteLine("Third watch:");

            Console.WriteLine("Hour position: {0}", watch3.hourHand.position);
            Console.WriteLine("Minute position: {0}", watch3.minuteHand.position);
            Console.WriteLine("Second position: {0}", watch3.secondHand.position);

            Console.WriteLine("Hour: {0}", watch3.ReadHour());
            Console.WriteLine("Minute: {0}", watch3.ReadMinute());
            Console.WriteLine("Second: {0}", watch3.ReadSecond());
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
