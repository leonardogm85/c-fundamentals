namespace C.Fundamentals.Module12.Question02
{
    /// <summary>
    /// <para>
    ///     Um triângulo é uma figura geométrica que possui três pontos. Crie as estruturas Triangulo e
    ///     Ponto para representar estes conceitos.
    /// </para>
    /// <para>
    ///     A estrutura Ponto possui as properties X, Y e Z, que correspondem às coordenadas dos
    ///     pontos, e tipo de dado das coordenadas deve ser parametrizado através do uso de generics. Já
    ///     a estrutura Triangulo possui as properties P1, P2 e P3, que correspondem aos três pontos
    ///     que compõem o triângulo. Triangulo deve ser parametrizado com o uso de generics, e o tipo
    ///     parametrizado deve ser utilizado nos pontos do triângulo.
    /// </para>
    /// <para>
    ///     No método Main() da aplicação, crie diferentes triângulos e pontos com diversos tipos de
    ///     dados, a fim de validar a implementação realizada.
    /// </para>
    /// </summary>
    internal static class Answer
    {
        internal static void Run()
        {
            Triangle<int> triangle1 = new Triangle<int>(
                new Point<int>(1, 2, 3),
                new Point<int>(4, 5, 6),
                new Point<int>(7, 8, 9)
                );
            Console.WriteLine(triangle1);

            Triangle<double> triangle2 = new Triangle<double>(
                new Point<double>(0.1, 0.2, 0.3),
                new Point<double>(0.4, 0.5, 0.6),
                new Point<double>(0.7, 0.8, 0.9)
                );
            Console.WriteLine(triangle2);
        }
    }

    internal struct Triangle<T>
    {
        public Triangle(Point<T> p1, Point<T> p2, Point<T> p3)
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;
        }

        public Point<T> P1 { get; private set; }
        public Point<T> P2 { get; private set; }
        public Point<T> P3 { get; private set; }

        public override string ToString()
        {
            return $"p1: [{P1}]\np2: [{P2}]\np3: [{P3}]";
        }
    }

    internal struct Point<T>
    {
        public Point(T x, T y, T z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public T X { get; private set; }
        public T Y { get; private set; }
        public T Z { get; private set; }

        public override string ToString()
        {
            return $"x: {X}, y: {Y} e z: {Z}";
        }
    }
}
