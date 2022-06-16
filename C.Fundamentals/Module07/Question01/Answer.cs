namespace C.Fundamentals.Module07.Question01
{
    /// <summary>
    /// <para>
    ///     Crie duas classes: Ponto2D e Ponto3D. Ponto2D possui como fields as coordenadas x e y,
    ///     enquanto Ponto3D, além delas, também possui a coordenada z. Utilize a relação de herança
    ///     para representar estas classes.
    /// </para>
    /// <para>
    ///     A respeito dos construtores, Ponto2D deve ter apenas um construtor, que recebe os valores
    ///     de x e y como parâmetros(tipo double). Já Ponto3D também deve ter apenas um construtor,
    ///     que deve receber x, y e z como parâmetros(também do tipo double). Dica: Se a relação de
    ///     herança e a declaração dos construtores foram feitas corretamente, você deverá,
    ///     obrigatoriamente, chamar o construtor da superclasse explicitamente.
    /// </para>
    /// <para>
    ///     Ambas as classes devem implementar o método Imprimir(), que exibe no console os valores
    ///     das coordenadas do objeto.
    /// </para>
    /// </summary>
    internal static class Answer
    {
        internal static void Run()
        {
            Point2D point2 = new Point2D(2, 4);
            point2.Print();

            Point3D point3 = new Point3D(3, 6, 9);
            point3.Print();
        }
    }

    internal class Point2D
    {
        protected double x;
        protected double y;

        public Point2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public virtual void Print()
        {
            Console.WriteLine("Point 2D = x: {0}, y: {1}", x, y);
        }
    }

    internal class Point3D : Point2D
    {
        protected double z;

        public Point3D(double x, double y, double z)
            : base(x, y)
        {
            this.z = z;
        }

        public override void Print()
        {
            Console.WriteLine("Point 3D = x: {0}, y: {1}, z: {2}", x, y, z);
        }
    }
}
