namespace C.Fundamentals.Module08.Polymorphism.Question03;

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
///     Desligar() e a property Ligado. O resultado obtido deve ser consistente com o que o modelo
///     representa. Por exemplo, ao chamar o método Ligar() de um Automovel, é esperado que a
///     property Ligado retorne true.
/// </para>
/// </summary>
internal static class Answer
{
    internal static void Run()
    {
        Vehicle car = new Car();
        car.TurnOn();
        Console.WriteLine("Car on: {0}", car.On);
        car.TurnOff();
        Console.WriteLine("Car on: {0}", car.On);
        Console.WriteLine();

        Vehicle motorcycle = new Motorcycle();
        motorcycle.TurnOn();
        Console.WriteLine("Motorcycle on: {0}", motorcycle.On);
        motorcycle.TurnOff();
        Console.WriteLine("Motorcycle on: {0}", motorcycle.On);
        Console.WriteLine();

        Vehicle bus = new Bus();
        bus.TurnOn();
        Console.WriteLine("Bus on: {0}", bus.On);
        bus.TurnOff();
        Console.WriteLine("Bus on: {0}", bus.On);
    }
}

internal abstract class Vehicle
{
    public bool On { get; private set; }

    public virtual void TurnOn()
    {
        On = true;
    }

    public virtual void TurnOff()
    {
        On = false;
    }
}

internal class Car : Vehicle
{
    public override void TurnOn()
    {
        base.TurnOn();
        Console.WriteLine("Car on");
    }

    public override void TurnOff()
    {
        base.TurnOff();
        Console.WriteLine("Car off");
    }
}

internal class Motorcycle : Vehicle
{
    public override void TurnOn()
    {
        base.TurnOn();
        Console.WriteLine("Motorcycle on");
    }

    public override void TurnOff()
    {
        base.TurnOff();
        Console.WriteLine("Motorcycle off");
    }
}

internal class Bus : Vehicle
{
    public override void TurnOn()
    {
        base.TurnOn();
        Console.WriteLine("Bus on");
    }

    public override void TurnOff()
    {
        base.TurnOff();
        Console.WriteLine("Bus off");
    }
}
