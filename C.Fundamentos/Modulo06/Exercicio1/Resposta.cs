namespace C.Fundamentos.Modulo06.Exercicio1
{
    /// <summary>
    /// <para>
    ///     Crie uma classe Lampada que possui um field ligada, que indica se a lâmpada está ligada ou
    ///     desligada.
    /// </para>
    /// <para>
    ///     Ao construir uma lâmpada, o estado dela (ligada ou desligada) deve ser fornecido. Para ligar e
    ///     desligar a lâmpada, os métodos Ligar() e Desligar() devem ser chamados, respectivamente.
    ///     Aliás, esta é a única forma de alterar o estado da lâmpada, já que o field ligada não pode ser
    ///     acessado de fora da classe.
    /// </para>
    /// <para>
    ///     A lâmpada também possui um método Imprimir(). Quando chamado, ele mostra as mensagens
    ///     "Lâmpada ligada" ou "Lâmpada desligada", dependendo do estado atual.
    /// </para>
    /// <para>
    ///     Construa uma aplicação que cria uma lâmpada ligada, muda o estado dela e também imprime
    ///     o estado atual após cada chamada a Ligar() e Desligar().
    /// </para>
    /// </summary>
    public static class Resposta
    {
        public static void Executar()
        {
            Lampada lampada = new Lampada(true);
            lampada.Imprimir();

            lampada.Desligar();
            lampada.Imprimir();

            lampada.Ligar();
            lampada.Imprimir();
        }
    }

    public class Lampada
    {
        private bool ligada;

        public Lampada(bool ligada)
        {
            this.ligada = ligada;
        }

        public void Ligar()
        {
            ligada = true;
        }

        public void Desligar()
        {
            ligada = false;
        }

        public void Imprimir()
        {
            string estadoAtual = ligada
                ? "Lâmpada ligada"
                : "Lâmpada desligada";

            Console.WriteLine(estadoAtual);
        }
    }
}
