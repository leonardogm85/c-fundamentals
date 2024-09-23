namespace C.Fundamentals.Module06.EncapsulationAndOrganizationOfTheCode.Question01;

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
internal static class Answer
{
    internal static void Run()
    {
        Lamp lamp = new Lamp(true);
        lamp.Print();

        lamp.TurnOff();
        lamp.Print();

        lamp.TurnOn();
        lamp.Print();
    }
}

internal class Lamp
{
    private bool on;

    public Lamp(bool on)
    {
        this.on = on;
    }

    public void TurnOn()
    {
        on = true;
    }

    public void TurnOff()
    {
        on = false;
    }

    public void Print()
    {
        string result = on
            ? "Lamp on"
            : "Lamp off";

        Console.WriteLine(result);
    }
}
