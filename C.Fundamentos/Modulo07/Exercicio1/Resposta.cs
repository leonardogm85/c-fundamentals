namespace C.Fundamentos.Modulo07.Exercicio1
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
    public static class Resposta
    {
        public static void Executar()
        {
            Ponto2D ponto2 = new Ponto2D(2, 4);
            ponto2.Imprimir();

            Ponto3D ponto3 = new Ponto3D(3, 6, 9);
            ponto3.Imprimir();
        }
    }

    public class Ponto2D
    {
        protected double x;
        protected double y;

        public Ponto2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public virtual void Imprimir()
        {
            Console.WriteLine($"x: {x}, y: {y}");
        }
    }

    public class Ponto3D : Ponto2D
    {
        protected double z;

        public Ponto3D(double x, double y, double z)
            : base(x, y)
        {
            this.z = z;
        }

        public override void Imprimir()
        {
            Console.WriteLine($"x: {x}, y: {y}, z: {z}");
        }
    }
}
