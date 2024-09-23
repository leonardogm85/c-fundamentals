namespace C.Fundamentals.Module12.Generics.Question01;

/// <summary>
///  Crie uma classe chamada ServiceFactory <![CDATA[<T>]]> que possui um método chamado
///  NewInstance(). Quando este método é chamado ele cria um objeto do tipo T (invocando o
///  construtor padrão, sem parâmetros) e retorna este objeto. Um detalhe importante é que
///  apenas classes que implementam a interface IService (que também deve ser definida por
///  você) devem ser aceitos na parametrização do tipo. Esta interface possui o método void
///  Execute(), que deve ser implementado pelas classes que implementam esta interface.
/// </summary>
internal static class Answer
{
    internal static void Run()
    {
        ServiceFactory<Service> factory = new ServiceFactory<Service>();
        IService service = factory.NewInstance();
        service.Execute();
    }
}

internal class ServiceFactory<T> where T : IService, new()
{
    public T NewInstance()
    {
        return new T();
    }
}

internal interface IService
{
    void Execute();
}

internal class Service : IService
{
    public void Execute()
    {
        Console.WriteLine("Service.Execute();");
    }
}
