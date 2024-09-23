namespace C.Fundamentals.Module06.EncapsulationAndOrganizationOfTheCode.Question02;

/// <summary>
/// <para>
///     Crie uma classe Data que possui dois construtores. O primeiro recebe um dia, mês e ano e o
///     segundo, além destas informações, recebe também uma hora, minuto e segundo(a hora
///     fornecida deve estar entre 0 e 23). É importante que este segundo construtor invoque o
///     primeiro para evitar a duplicação de código.
/// </para>
/// <para>
///     Os construtores devem armazenar os dados fornecidos como parâmetros em fields privados.
///     Estes fields devem ter seus valores expostos para fora da classe usando read-only
///     properties.
/// </para>
/// <para>
///     A classe Data deve ter também um método Imprimir(), utilizado para imprimir a data e hora
///     representados pelo objeto. Este método recebe como parâmetro o formato de hora que deve
///     ser utilizado para imprimir as horas(12 ou 24h). Se o objeto for construído sem informação de
///     horário, este parâmetro não afeta a impressão.
/// </para>
/// <para>
///     Os formatos da hora são do tipo int, mas devem ser representados por duas constantes na
///     classe Data: FORMATO_12H e FORMATO_24H.
/// </para>
/// <para>
///     Para entender melhor o funcionamento do método Imprimir(), observe como ele deve se
///     comportar em diversas situações:
/// </para>
/// <code>
///     Data d1 = new Data(10, 03, 2000, 10, 30, 10);
///     d1.imprimir(Data.FORMATO_12H); // 10/3/2000 10:30:10 AM
///     d1.imprimir(Data.FORMATO_24H); // 10/3/2000 10:30:10
/// </code>
/// <code>
///     Data d2 = new Data(15, 06, 2000, 23, 15, 20);
///     d2.imprimir(Data.FORMATO_12H); // 15/6/2000 11:15:20 PM
///     d2.imprimir(Data.FORMATO_24H); // 15/6/2000 23:15:20
/// </code>
/// <code>
///     Data d3 = new Data(5, 10, 2005);
///     d3.imprimir(Data.FORMATO_12H); // 5/10/2005
///     d3.imprimir(Data.FORMATO_24H); // 5/10/2005
/// </code>
/// </summary>
internal static class Answer
{
    internal static void Run()
    {
        Date d1 = new Date(10, 03, 2000, 10, 30, 10);
        d1.Print(Date.FORMAT_12H);
        d1.Print(Date.FORMAT_24H);

        Date d2 = new Date(15, 06, 2000, 23, 15, 20);
        d2.Print(Date.FORMAT_12H);
        d2.Print(Date.FORMAT_24H);

        Date d3 = new Date(5, 10, 2005);
        d3.Print(Date.FORMAT_12H);
        d3.Print(Date.FORMAT_24H);
    }
}

internal class Date
{
    public const int FORMAT_12H = 1;
    public const int FORMAT_24H = 2;

    private int day;
    private int month;
    private int year;

    private int hour = -1;
    private int minute = -1;
    private int second = -1;

    public Date(int day, int month, int year)
    {
        this.day = day;
        this.month = month;
        this.year = year;
    }

    public Date(int day, int month, int year, int hour, int minute, int second)
        : this(day, month, year)
    {
        this.hour = hour;
        this.minute = minute;
        this.second = second;
    }

    public int Day { get { return day; } }
    public int Month { get { return month; } }
    public int Year { get { return year; } }

    public int Hour { get { return hour; } }
    public int Minute { get { return minute; } }
    public int Second { get { return second; } }

    public void Print(int format)
    {
        string date = $"{day:d2}/{month:d2}/{year:d4}";

        if (hour == -1)
        {
            Console.WriteLine(date);
        }
        else
        {
            string time;

            if (format == FORMAT_12H)
            {
                string period = hour < 12
                    ? "AM"
                    : "PM";

                time = $"{hour % 12:d2}:{minute:d2}:{second:d2} {period}";
            }
            else
            {
                time = $"{hour:d2}:{minute:d2}:{second:d2}";
            }

            Console.WriteLine("{0} {1}", date, time);
        }
    }
}
