namespace C.Fundamentos.Modulo08.Exercicio1
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
    public static class Resposta
    {
        public static void Executar()
        {
            Figura quadrado1 = new Quadrado(3);
            Figura quadrado2 = new Quadrado(10);

            Figura retangulo1 = new Retangulo(2, 7);
            Figura retangulo2 = new Retangulo(5, 3);

            Figura[] figuras = new Figura[4];

            figuras[0] = quadrado1;
            figuras[1] = quadrado2;
            figuras[2] = retangulo1;
            figuras[3] = retangulo2;

            Figura figuraComplexa = new FiguraComplexa(figuras);

            Console.WriteLine($"Área da figura complexa: {figuraComplexa.CalcularArea()}");
        }
    }

    public abstract class Figura
    {
        public abstract double CalcularArea();
    }

    public class FiguraComplexa : Figura
    {
        public Figura[] Figuras { get; private set; }

        public FiguraComplexa(Figura[] figuras)
        {
            Figuras = figuras;
        }

        public override double CalcularArea()
        {
            double total = 0;

            foreach (var figura in Figuras)
            {
                total += figura.CalcularArea();
            }

            return total;
        }
    }

    public class Quadrado : Figura
    {
        public Quadrado(double lado)
        {
            Lado = lado;
        }

        public double Lado { get; private set; }

        public override double CalcularArea()
        {
            return Math.Pow(Lado, 2);
        }
    }

    public class Retangulo : Figura
    {
        public Retangulo(double @base, double altura)
        {
            Base = @base;
            Altura = altura;
        }

        public double Base { get; private set; }
        public double Altura { get; private set; }

        public override double CalcularArea()
        {
            return Base * Altura;
        }
    }
}
