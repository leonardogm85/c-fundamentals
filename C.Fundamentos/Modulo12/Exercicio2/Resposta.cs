namespace C.Fundamentos.Modulo12.Exercicio2
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
    public static class Resposta
    {
        public static void Executar()
        {
            Triangulo<int> triangulo1 = new Triangulo<int>(
                new Ponto<int>(1, 2, 3),
                new Ponto<int>(4, 5, 6),
                new Ponto<int>(7, 8, 9)
                );
            Console.WriteLine(triangulo1);

            Triangulo<double> triangulo2 = new Triangulo<double>(
                new Ponto<double>(0.1, 0.2, 0.3),
                new Ponto<double>(0.4, 0.5, 0.6),
                new Ponto<double>(0.7, 0.8, 0.9)
                );
            Console.WriteLine(triangulo2);
        }
    }

    public struct Triangulo<T>
    {
        public Triangulo(Ponto<T> p1, Ponto<T> p2, Ponto<T> p3)
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;
        }

        public Ponto<T> P1 { get; private set; }
        public Ponto<T> P2 { get; private set; }
        public Ponto<T> P3 { get; private set; }

        public override string ToString()
        {
            return $"p1: [{P1}]\np2: [{P2}]\np3: [{P3}]";
        }
    }

    public struct Ponto<T>
    {
        public Ponto(T x, T y, T z)
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
