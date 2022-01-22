namespace C.Fundamentos.Modulo13.Exercicio2
{
    /// <summary>
    /// <para>
    ///     Crie uma classe Carta que contenha o valor e o naipe (o naipe pode ser um enumeration). Crie
    ///     também uma classe Baralho, que contém um array de cartas. A classe Baralho deve ter os
    ///     seguintes métodos:
    /// </para>
    /// <list type="bullet">
    ///     <item>
    ///         Carta[] Distribuir(int qtde): Distribui cartas do baralho. A quantidade de cartas
    ///         distribuídas é passada como parâmetro, e o retorno do método é um array de cartas
    ///         distribuídas. As cartas que são distribuídas deixam de fazer parte do baralho, pelo menos
    ///         conceitualmente.
    ///     </item>
    ///     <item>
    ///         void Embaralhar(): Embaralha as cartas do baralho. Cartas já distribuídas não fazem parte
    ///         do processo de embaralhamento.
    ///     </item>
    ///     <item>
    ///         void MostrarCartas(): Imprime as cartas do baralho. Cartas já distribuídas não devem ser
    ///         mostradas, pois não fazem mais parte do baralho.
    ///     </item>
    /// </list>
    /// <para>
    ///     Algumas considerações importantes:
    /// </para>
    /// <list type="bullet">
    ///     <item>
    ///         A quantidade a ser distribuída no processo de distribuição deve ser maior que zero e
    ///         menor ou igual ao número de cartas existentes no baralho. Caso a quantidade seja
    ///         inválida, o médoto deve lançar uma exceção do tipo ArgumentOutOfRangeException.
    ///     </item>
    ///     <item>
    ///         O processo de embaralhamento pode ser feito utilizando outro array, que recebe os
    ///         elementos do array original de forma randomizada.
    ///     </item>
    ///     <item>
    ///         Durante a randomização no processo de embaralhamento, é possível que a mesma
    ///         carta seja sorteada mais de uma vez. Portanto é preciso controlar quais cartas já
    ///         foram sorteadas e fazer esta checagem, para evitar situaçòes deste tipo. Uma dica é
    ///         utilizar um array para armazenar os índices de elementos já sorteados.
    ///     </item>
    /// </list>
    /// <para>
    ///     Crie um método Main() na aplicação que instancia as cartas e o baralho e faça chamadas aos
    ///     métodos Distribuir(), Embaralhar() e MostrarCartas() para validar a implementação
    ///     realizada.
    /// </para>
    /// </summary>
    public static class Resposta
    {
        public static void Executar()
        {
            Naipe[] naipes =
            {
                Naipe.Paus,
                Naipe.Espadas,
                Naipe.Copas,
                Naipe.Ouros
            };

            char[] valores =
            {
                'A',
                '2',
                '3',
                '4',
                '5',
                '6',
                '7',
                '8',
                '9',
                '0',
                'J',
                'Q',
                'K'
            };

            Carta[] cartas = new Carta[52];

            int indice = 0;

            foreach (Naipe naipe in naipes)
            {
                foreach (char valor in valores)
                {
                    Carta carta = new Carta(valor, naipe);
                    cartas[indice] = carta;
                    indice++;
                }
            }

            Baralho baralho = new Baralho(cartas);

            baralho.Distribuir(10);
            baralho.Embaralhar();
            baralho.MostrarCartas();
        }
    }

    public class Baralho
    {
        public Baralho(Carta[] cartas)
        {
            Cartas = cartas;
        }

        public Carta[] Cartas { get; private set; }

        public Carta[] Distribuir(int qtde)
        {
            if (qtde < 0 || qtde > Cartas.Length)
            {
                throw new ArgumentOutOfRangeException("A quantidade a ser distribuída deve ser maior que zero e menor ou igual ao número de cartas.");
            }

            Carta[] distribuidas = new Carta[qtde];

            Carta[] restantes = new Carta[Cartas.Length - qtde];

            for (int i = 0; i < Cartas.Length; i++)
            {
                Carta carta = Cartas[i];

                if (i < qtde)
                {
                    distribuidas[i] = carta;
                }
                else
                {
                    restantes[i - qtde] = carta;
                }
            }

            Cartas = restantes;

            return distribuidas;
        }

        public void Embaralhar()
        {
            Carta[] cartas = Cartas;

            Carta[] embaralhadas = new Carta[Cartas.Length];

            Random random = new Random();

            for (int i = 0; i < Cartas.Length; i++)
            {
                int sorteada = random.Next(cartas.Length);

                embaralhadas[i] = cartas[sorteada];

                Carta[] restantes = new Carta[cartas.Length - 1];

                for (int j = 0, l = 0; j < cartas.Length; j++)
                {
                    if (sorteada == j)
                    {
                        continue;
                    }

                    restantes[l++] = cartas[j];
                }

                cartas = restantes;
            }

            Cartas = embaralhadas;
        }

        public void MostrarCartas()
        {
            foreach (Carta carta in Cartas)
            {
                Console.WriteLine(carta);
            }
        }
    }

    public class Carta
    {
        public Carta(char valor, Naipe naipe)
        {
            Valor = valor;
            Naipe = naipe;
        }

        public char Valor { get; private set; }
        public Naipe Naipe { get; private set; }

        public override string ToString()
        {
            return $"{Valor}({Naipe})";
        }
    }

    public enum Naipe
    {
        Paus = 1,
        Espadas = 2,
        Copas = 3,
        Ouros = 4
    }
}
