namespace C.Fundamentals.Module04.Question02
{
    /// <summary>
    /// Crie a estrutura (struct) Fracao, que representa uma fração matemática. Esta estrutura deve
    /// ser capaz de armazenar o numerador e o denominador da fração. Ela ainda deve ter um
    /// método que recebe uma fração como parâmetro, multiplica ambas as frações, e retorna uma
    /// nova fração como resultado. Crie um programa simples que instancia duas frações, define
    /// seus valores, calcula o valor da multiplicação entre elas e mostra o resultado.
    /// </summary>
    internal static class Answer
    {
        internal static void Run()
        {
            Fraction f1 = new Fraction(2, 3);
            Fraction f2 = new Fraction(5, 15);
            Fraction f3 = f1.Multiply(f2);

            Console.WriteLine($"Fração: {f3.GetFraction()}");
            Console.WriteLine($"Calculo: {f3.GetCalculation()}");
        }
    }

    public struct Fraction
    {
        private int numerator;
        private int denominator;

        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public Fraction Multiply(Fraction fraction)
        {
            return new Fraction(
                numerator * fraction.numerator,
                denominator * fraction.denominator);
        }

        public double GetCalculation()
        {
            return (double)numerator / denominator;
        }

        public string GetFraction()
        {
            return $"{numerator}/{denominator}";
        }
    }
}
