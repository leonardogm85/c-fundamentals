namespace C.Fundamentos.Modulo06.Exercicio2
{
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
    public static class Resposta
    {
        public static void Executar()
        {
            Data d1 = new Data(10, 03, 2000, 10, 30, 10);
            d1.Imprimir(Data.FORMATO_12H);
            d1.Imprimir(Data.FORMATO_24H);

            Data d2 = new Data(15, 06, 2000, 23, 15, 20);
            d2.Imprimir(Data.FORMATO_12H);
            d2.Imprimir(Data.FORMATO_24H);

            Data d3 = new Data(5, 10, 2005);
            d3.Imprimir(Data.FORMATO_12H);
            d3.Imprimir(Data.FORMATO_24H);
        }
    }

    public class Data
    {
        public const int FORMATO_12H = 1;
        public const int FORMATO_24H = 2;

        private int dia;
        private int mes;
        private int ano;

        private int hora = -1;
        private int minuto = -1;
        private int segundo = -1;

        public Data(int dia, int mes, int ano)
        {
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;
        }

        public Data(int dia, int mes, int ano, int hora, int minuto, int segundo)
            : this(dia, mes, ano)
        {
            this.hora = hora;
            this.minuto = minuto;
            this.segundo = segundo;
        }

        public int Dia { get { return dia; } }
        public int Mes { get { return mes; } }
        public int Ano { get { return ano; } }

        public int Hora { get { return hora; } }
        public int Minuto { get { return minuto; } }
        public int Segundo { get { return segundo; } }

        public void Imprimir(int formato)
        {
            string data = $"{dia:d2}/{mes:d2}/{ano:d4}";

            if (hora == -1)
            {
                Console.WriteLine(data);
            }
            else
            {
                string horario;

                if (formato == FORMATO_12H)
                {
                    string periodo = hora < 12
                        ? "AM"
                        : "PM";

                    horario = $"{(hora % 12):d2}:{minuto:d2}:{segundo:d2} {periodo}";
                }
                else
                {
                    horario = $"{hora:d2}:{minuto:d2}:{segundo:d2}";
                }

                Console.WriteLine($"{data} {horario}");
            }
        }
    }
}
