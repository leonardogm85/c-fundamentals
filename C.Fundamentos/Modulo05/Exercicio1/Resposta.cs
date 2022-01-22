namespace C.Fundamentos.Modulo05.Exercicio1
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
    public static class Resposta
    {
        public static void Executar()
        {
            Figura triangulo = new Triangulo(10, 7);
            Figura quadrado = new Quadrado(5);
            Figura circunferencia = new Circunferencia(3);
            Figura trapezio = new Trapezio(10, 5, 15);

            Console.WriteLine($"Área do Triangulo: {triangulo.CalcularArea()}");
            Console.WriteLine($"Área do Quadrado: {quadrado.CalcularArea()}");
            Console.WriteLine($"Área do Circunferencia: {circunferencia.CalcularArea()}");
            Console.WriteLine($"Área do Trapezio: {trapezio.CalcularArea()}");
        }
    }

    public abstract class Figura
    {
        public abstract double CalcularArea();
    }

    public class Triangulo : Figura
    {
        private double @base;
        private double altura;

        public Triangulo(double @base, double altura)
        {
            this.@base = @base;
            this.altura = altura;
        }

        public override double CalcularArea()
        {
            return (@base * altura) / 2;
        }
    }

    public class Quadrado : Figura
    {
        private double lado;

        public Quadrado(double lado)
        {
            this.lado = lado;
        }

        public override double CalcularArea()
        {
            return Math.Pow(lado, 2);
        }
    }

    public class Circunferencia : Figura
    {
        private double raio;

        public Circunferencia(double raio)
        {
            this.raio = raio;
        }

        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(raio, 2);
        }
    }

    public class Trapezio : Figura
    {
        private double baseMaior;
        private double baseMenor;
        private double altura;

        public Trapezio(double baseMaior, double baseMenor, double altura)
        {
            this.baseMaior = baseMaior;
            this.baseMenor = baseMenor;
            this.altura = altura;
        }

        public override double CalcularArea()
        {
            return ((baseMaior * baseMenor) / 2) * altura;
        }
    }
}
