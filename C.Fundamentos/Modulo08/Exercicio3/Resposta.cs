namespace C.Fundamentos.Modulo08.Exercicio3
{
    /// <summary>
    /// <para>
    ///     Crie uma classe Veiculo com um field ligado (privado), que indica se o carro está ligado ou não.
    ///     Esta classe deve ter também os métodos Ligar() e Desligar(), que definem o valor para este
    ///     field, e uma read-only property para retornar o valor do field.
    /// </para>
    /// <para>
    ///     Depois crie três subclasses de Veiculo: Automovel, Motocicleta e Onibus. Cada classe destas
    ///     deve sobrescrever os métodos Ligar() e Desligar() e deve imprimir mensagens como
    ///     "Automóvel ligado", "Motocicleta desligada", etc. Para manter a consistência do modelo,
    ///     descubra como fazer para que o field ligado de Veiculo tenha o valor correto quando os
    ///     métodos são chamados.
    /// </para>
    /// <para>
    ///     Crie uma aplicação que instancia três veículos, um de cada tipo, e chama os métodos Ligar(),
    ///     Desligar() e a property Ligado.O resultado obtido deve ser consistente com o que o modelo
    ///     representa. Por exemplo, ao chamar o método Ligar() de um Automovel, é esperado que a
    ///     property Ligado retorne true.
    /// </para>
    /// </summary>
    public static class Resposta
    {
        public static void Executar()
        {
            Veiculo automovel = new Automovel();
            automovel.Ligar();
            Console.WriteLine(automovel.Ligado);
            automovel.Desligar();
            Console.WriteLine(automovel.Ligado);

            Veiculo motocicleta = new Motocicleta();
            motocicleta.Ligar();
            Console.WriteLine(motocicleta.Ligado);
            motocicleta.Desligar();
            Console.WriteLine(motocicleta.Ligado);

            Veiculo onibus = new Onibus();
            onibus.Ligar();
            Console.WriteLine(onibus.Ligado);
            onibus.Desligar();
            Console.WriteLine(onibus.Ligado);
        }
    }

    public abstract class Veiculo
    {
        public bool Ligado { get; private set; }

        public virtual void Ligar()
        {
            Ligado = true;
        }

        public virtual void Desligar()
        {
            Ligado = false;
        }
    }

    public class Automovel : Veiculo
    {
        public override void Ligar()
        {
            base.Ligar();
            Console.WriteLine($"Automovel ligado");
        }

        public override void Desligar()
        {
            base.Desligar();
            Console.WriteLine($"Automovel desligado");
        }
    }

    public class Motocicleta : Veiculo
    {
        public override void Ligar()
        {
            base.Ligar();
            Console.WriteLine($"Motocicleta ligado");
        }

        public override void Desligar()
        {
            base.Desligar();
            Console.WriteLine($"Motocicleta desligado");
        }
    }

    public class Onibus : Veiculo
    {
        public override void Ligar()
        {
            base.Ligar();
            Console.WriteLine($"Onibus ligado");
        }

        public override void Desligar()
        {
            base.Desligar();
            Console.WriteLine($"Onibus desligado");
        }
    }
}
