namespace C.Fundamentals.Module08.Question01
{
    /// <summary>
    /// <para>
    ///     Crie a classe Figura que representa figuras geométricas, representadas pelas classes
    ///     Quadrado e Retangulo. Uma figura pode ter sua área calculada a partir do método
    ///     CalcularArea(), que retorna a área calculada da figura em forma de um double.
    /// </para>
    /// <para>
    ///     Crie também a classe FiguraComplexa. Uma figura complexa é também uma figura, mas a
    ///     diferença é que ela é composta por várias figuras(quadrados, retângulos ou até outras figuras
    ///     complexas). Para calcular a área de uma figura complexa, basta somar a área de todas as
    ///     figuras que a compõem.
    /// </para>
    /// <para>
    ///     Para executar a aplicação, crie a classe Program, que é responsável por criar uma figura
    ///     complexa e calcular a sua área.Esta figura deve ser composta por:
    /// </para>
    /// <list type="bullet">
    ///     <item>
    ///         1 quadrado com 3 de lado
    ///     </item>
    ///     <item>
    ///         1 quadrado com 10 de lado
    ///     </item>
    ///     <item>
    ///         1 retângulo com lados 2 e 7
    ///     </item>
    ///     <item>
    ///         1 retângulo com lados 5 e 3
    ///     </item>
    /// </list>
    /// <para>
    ///     Dica 1: Perceba a diferença entre uma classe ser uma figura e ter uma ou mais figuras. A
    ///     primeira relação é de herança, enquanto a segunda implica em uma composição.
    /// </para>
    /// <para>
    ///     Dica 2: Para resolver este exercício é necessário conhecer a respeito de arrays. Se você não
    ///     está familiarizado com eles neste momento, pode voltar a este exercício mais adiante, depois
    ///     que este tema for abordado no curso.
    /// </para>
    /// </summary>
    internal static class Answer
    {
        internal static void Run()
        {
            Figure square1 = new Square(3);
            Figure square2 = new Square(10);

            Figure rectangle1 = new Rectangle(2, 7);
            Figure rectangle2 = new Rectangle(5, 3);

            Figure[] figures = new Figure[4];

            figures[0] = square1;
            figures[1] = square2;
            figures[2] = rectangle1;
            figures[3] = rectangle2;

            Figure complexFigure = new ComplexFigure(figures);

            Console.WriteLine($"Área da figura complexa: {complexFigure.CalculateArea()}");
        }
    }

    internal abstract class Figure
    {
        public abstract double CalculateArea();
    }

    internal class ComplexFigure : Figure
    {
        public Figure[] Figures { get; private set; }

        public ComplexFigure(Figure[] figures)
        {
            Figures = figures;
        }

        public override double CalculateArea()
        {
            double total = 0;

            foreach (Figure figure in Figures)
            {
                total += figure.CalculateArea();
            }

            return total;
        }
    }

    internal class Square : Figure
    {
        public Square(double side)
        {
            Side = side;
        }

        public double Side { get; private set; }

        public override double CalculateArea()
        {
            return Math.Pow(Side, 2);
        }
    }

    internal class Rectangle : Figure
    {
        public Rectangle(double @base, double height)
        {
            Base = @base;
            Height = height;
        }

        public double Base { get; private set; }
        public double Height { get; private set; }

        public override double CalculateArea()
        {
            return Base * Height;
        }
    }
}
