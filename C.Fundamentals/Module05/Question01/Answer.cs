namespace C.Fundamentals.Module05.Question01
{
    /// <summary>
    /// <para>
    ///     Crie classes que representam as figuras geométricas: Triangulo, Quadrado, Circunferencia e
    ///     Trapezio. Cada uma destas classes deve ter um método para calcular a sua área, com a
    ///     seguinte assinatura: double CalcularArea().
    /// </para>
    /// <para>
    ///     Perceba que o método CalcularArea() não recebe parâmetros. Portanto todos os dados
    ///     necessários devem ser armazenados no objeto da classe em fields, para depois serem
    ///     utilizados pelo método.
    /// </para>
    /// <para>
    ///     As fórmulas para o cálculo da área são as seguintes:
    /// </para>
    /// <list type="bullet">
    ///     <item>
    ///         <para>
    ///             Figura: Triângulo
    ///         </para>
    ///         <list type="bullet">
    ///             <item>
    ///                 Fórmula: A = (b * h) / 2
    ///             </item>
    ///             <item>
    ///                 Elementos da fórmula: b (base), h (altura)
    ///             </item>
    ///         </list>
    ///     </item>
    ///     <item>
    ///         <para>
    ///             Figura: Quadrado
    ///         </para>
    ///         <list type="bullet">
    ///             <item>
    ///                 Fórmula: A = l * l
    ///             </item>
    ///             <item>
    ///                 Elementos da fórmula: l (lado)
    ///             </item>
    ///         </list>
    ///     </item>
    ///     <item>
    ///         <para>
    ///             Figura: Circunferência
    ///         </para>
    ///         <list type="bullet">
    ///             <item>
    ///                 Fórmula: A = PI * r * r
    ///             </item>
    ///             <item>
    ///                 Elementos da fórmula: r (raio)
    ///             </item>
    ///         </list>
    ///     </item>
    ///     <item>
    ///         <para>
    ///             Figura: Trapézio
    ///         </para>
    ///         <list type="bullet">
    ///             <item>
    ///                 Fórmula: A = ((B * b) / 2) * h
    ///             </item>
    ///             <item>
    ///                 Elementos da fórmula: B (base maior), b (base menor), h (altura)
    ///             </item>
    ///         </list>
    ///     </item>
    /// </list>
    /// <para>
    ///     Dica: O valor de PI pode ser obtido através da chamada Math.PI no C#.
    /// </para>
    /// </summary>
    internal static class Answer
    {
        internal static void Run()
        {
            Figure triangle = new Triangle(10, 7);
            Figure square = new Square(5);
            Figure circumference = new Circumference(3);
            Figure trapeze = new Trapeze(10, 5, 15);

            Console.WriteLine("Triangle area: {0}", triangle.CalculateArea());
            Console.WriteLine("Square area: {0}", square.CalculateArea());
            Console.WriteLine("Circumference area: {0}", circumference.CalculateArea());
            Console.WriteLine("Trapeze area: {0}", trapeze.CalculateArea());
        }
    }

    internal abstract class Figure
    {
        public abstract double CalculateArea();
    }

    internal class Triangle : Figure
    {
        private double @base;
        private double height;

        public Triangle(double @base, double height)
        {
            this.@base = @base;
            this.height = height;
        }

        public override double CalculateArea()
        {
            return (@base * height) / 2;
        }
    }

    internal class Square : Figure
    {
        private double side;

        public Square(double side)
        {
            this.side = side;
        }

        public override double CalculateArea()
        {
            return Math.Pow(side, 2);
        }
    }

    internal class Circumference : Figure
    {
        private double radius;

        public Circumference(double radius)
        {
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }

    internal class Trapeze : Figure
    {
        private double majorBase;
        private double minorBase;
        private double height;

        public Trapeze(double majorBase, double minorBase, double height)
        {
            this.majorBase = majorBase;
            this.minorBase = minorBase;
            this.height = height;
        }

        public override double CalculateArea()
        {
            return ((majorBase * minorBase) / 2) * height;
        }
    }
}
