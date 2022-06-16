namespace C.Fundamentals.Module13.Question02
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
    internal static class Answer
    {
        internal static void Run()
        {
            Suit[] suits =
            {
                Suit.Clubs,
                Suit.Spades,
                Suit.Hearts,
                Suit.Diamonds
            };

            char[] values =
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

            Card[] cards = new Card[52];

            int index = 0;

            foreach (Suit suit in suits)
            {
                foreach (char value in values)
                {
                    Card card = new Card(value, suit);
                    cards[index] = card;
                    index++;
                }
            }

            PlayingCards playingCards = new PlayingCards(cards);

            playingCards.Distribute(10);
            playingCards.Shuffle();
            playingCards.Show();
        }
    }

    public class PlayingCards
    {
        public PlayingCards(Card[] cards)
        {
            Cards = cards;
        }

        public Card[] Cards { get; private set; }

        public Card[] Distribute(int count)
        {
            if (count < 0 || count > Cards.Length)
            {
                throw new ArgumentOutOfRangeException("The amount to be dealt must be greater than zero and less than or equal to the number of cards.");
            }

            Card[] cardsDealt = new Card[count];

            Card[] cardsLeft = new Card[Cards.Length - count];

            for (int i = 0; i < Cards.Length; i++)
            {
                Card cards = Cards[i];

                if (i < count)
                {
                    cardsDealt[i] = cards;
                }
                else
                {
                    cardsLeft[i - count] = cards;
                }
            }

            Cards = cardsLeft;

            return cardsDealt;
        }

        public void Shuffle()
        {
            Card[] cards = Cards;

            Card[] shuffledCards = new Card[Cards.Length];

            Random random = new Random();

            for (int i = 0; i < Cards.Length; i++)
            {
                int numberDrawn = random.Next(cards.Length);

                shuffledCards[i] = cards[numberDrawn];

                Card[] cardsLeft = new Card[cards.Length - 1];

                for (int j = 0, l = 0; j < cards.Length; j++)
                {
                    if (numberDrawn == j)
                    {
                        continue;
                    }

                    cardsLeft[l++] = cards[j];
                }

                cards = cardsLeft;
            }

            Cards = shuffledCards;
        }

        public void Show()
        {
            foreach (Card card in Cards)
            {
                Console.WriteLine(card);
            }
        }
    }

    public class Card
    {
        public Card(char value, Suit suit)
        {
            Value = value;
            Suit = suit;
        }

        public char Value { get; private set; }
        public Suit Suit { get; private set; }

        public override string ToString()
        {
            return $"{Value}({Suit})";
        }
    }

    public enum Suit
    {
        Clubs = 1,
        Spades = 2,
        Hearts = 3,
        Diamonds = 4
    }
}
