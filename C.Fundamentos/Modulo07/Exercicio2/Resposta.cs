namespace C.Fundamentos.Modulo07.Exercicio2
{
    /// <summary>
    /// <para>
    ///     O C# possui uma interface chamada ICloneable, que pode ser implementada por classes que
    ///     são capazes de gerar cópias de objetos. Classes que implementam esta interface devem
    ///     implementar o método Clone(). Dentro deste método é implementada a lógica para criar um
    ///     novo objeto com base no objeto original.
    /// </para>
    /// <para>
    ///     Com base nisto, crie uma classe Porta que suporta a criação de novos objetos (cópia). Ela deve
    ///     ter os fields altura(double), largura(double) e aberta(boolean). Também deve possuir os
    ///     métodos Abrir(), Fechar() e os valores dos fields devem ser expostos para fora da classe
    ///     através de read-only properties.
    /// </para>
    /// <para>
    ///     Como uma porta pode criar outras cópias dela mesma, você deve implementar o método
    ///     Clone() na classe, o qual deve criar um novo objeto com os valores dos atributos copiados e
    ///     retorná-lo.
    /// </para>
    /// </summary>
    public static class Resposta
    {
        public static void Executar()
        {
            Porta porta = new Porta(2.5, 0.9);
            porta.Imprimir();

            Porta copia = (Porta)porta.Clone();
            copia.Imprimir();

            porta.Abrir();
            porta.Imprimir();

            copia = (Porta)porta.Clone();
            copia.Imprimir();

            porta.Fechar();
            porta.Imprimir();

            copia = (Porta)porta.Clone();
            copia.Imprimir();
        }
    }

    public class Porta : ICloneable
    {
        private double altura;
        private double largura;
        private bool aberta;

        public Porta(double altura, double largura)
        {
            this.altura = altura;
            this.largura = largura;
        }

        public double Altura { get { return altura; } }
        public double Largura { get { return largura; } }
        public bool Aberta { get { return aberta; } }

        public void Abrir()
        {
            this.aberta = true;
        }

        public void Fechar()
        {
            this.aberta = false;
        }

        public void Imprimir()
        {
            Console.WriteLine($"Altura: {altura}, Largura: {largura}, Aberta: {aberta}");
        }

        public object Clone()
        {
            Porta porta = new Porta(altura, largura);
            porta.aberta = aberta;
            return porta;
        }
    }
}
