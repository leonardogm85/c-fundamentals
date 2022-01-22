namespace C.Fundamentos.Modulo04.Exercicio2
{
    /// <summary>
    /// Crie a estrutura (struct) Fracao, que representa uma fração matemática. Esta estrutura deve
    /// ser capaz de armazenar o numerador e o denominador da fração. Ela ainda deve ter um
    /// método que recebe uma fração como parâmetro, multiplica ambas as frações, e retorna uma
    /// nova fração como resultado. Crie um programa simples que instancia duas frações, define
    /// seus valores, calcula o valor da multiplicação entre elas e mostra o resultado.
    /// </summary>
    public static class Resposta
    {
        public static void Executar()
        {
            Francao f1 = new Francao(2, 3);
            Francao f2 = new Francao(5, 15);
            Francao f3 = f1.Multiplicar(f2);

            Console.WriteLine($"Fração: {f3.ObterFrancao()}");
            Console.WriteLine($"Calculo: {f3.ObterCalculo()}");
        }
    }

    public struct Francao
    {
        private int numerador;
        private int denominador;

        public Francao(int numerador, int denominador)
        {
            this.numerador = numerador;
            this.denominador = denominador;
        }

        public Francao Multiplicar(Francao francao)
        {
            return new Francao(
                numerador * francao.numerador,
                denominador * francao.denominador);
        }

        public double ObterCalculo()
        {
            return (double)numerador / denominador;
        }

        public string ObterFrancao()
        {
            return $"{numerador}/{denominador}";
        }
    }
}
