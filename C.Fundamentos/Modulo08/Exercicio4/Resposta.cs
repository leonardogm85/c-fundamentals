namespace C.Fundamentos.Modulo08.Exercicio4
{
    /// <summary>
    /// Crie uma interface IAreaCalculavel com um método CalcularArea() e crie classes de figuras
    /// geométricas que implementam este método(como quadrado, circunferência e retângulo).
    /// Depois crie uma classe com um método Main() para exercitar as chamadas aos métodos que
    /// calculam a área.
    /// </summary>
    public static class Resposta
    {
        public static void Executar()
        {
            IAreaCalculavel quadrado = new Quadrado(5);
            IAreaCalculavel circunferencia = new Circunferencia(2);
            IAreaCalculavel retangulo = new Retangulo(2, 4);

            Console.WriteLine($"Área do quadrado: {quadrado.CalcularArea()}");
            Console.WriteLine($"Área do circunferência: {circunferencia.CalcularArea()}");
            Console.WriteLine($"Área do retângulo: {retangulo.CalcularArea()}");
        }
    }

    public interface IAreaCalculavel
    {
        double CalcularArea();
    }

    public class Quadrado : IAreaCalculavel
    {
        public Quadrado(double lado)
        {
            Lado = lado;
        }

        public double Lado { get; private set; }

        public double CalcularArea()
        {
            return Math.Pow(Lado, 2);
        }
    }

    public class Circunferencia : IAreaCalculavel
    {
        public Circunferencia(double raio)
        {
            Raio = raio;
        }

        public double Raio { get; private set; }

        public double CalcularArea()
        {
            return Math.PI * Math.Pow(Raio, 2);
        }
    }

    public class Retangulo : IAreaCalculavel
    {
        public Retangulo(double @base, double altura)
        {
            Base = @base;
            Altura = altura;
        }

        public double Base { get; private set; }
        public double Altura { get; private set; }

        public double CalcularArea()
        {
            return Base * Altura;
        }
    }
}
