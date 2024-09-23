namespace C.Fundamentals.Module10.StringsAndEnumerations.Question01;

/// <summary>
/// <para>
///     Implemente um método Processar(), que recebe uma string s como parâmetro e retorna
///     uma nova string. Ele deve funcionar da seguinte forma:
/// </para>
/// <list type="bullet">
///     <item>
///         Se s for null, o método retorna null.
///     </item>
///     <item>
///         Se o tamanho de s for menor ou igual a 3, a string s convertida para maiúscula é
///         retornada.
///     </item>
///     <item>
///         Se s tiver tamanho maior do que 3, além da conversão para maiúsculo, os 3 primeiros
///         caracteres devem ser substituídos por ??? antes da string ser retornada.
///     </item>
/// </list>
/// <para>
///     Para exemplificar o funcionamento do algoritmo, observe a tabela abaixo. Ela mostra diversas
///     formas de chamar o método e o retorno esperado em cada caso:
/// </para>
/// <list type="bullet">
///     <item>
///         Invocação: Processar(null); Retorno: null
///     </item>
///     <item>
///         Invocação: Processar("ab"); Retorno: AB
///     </item>
///     <item>
///         Invocação: Processar("abcdefg"); Retorno: ???DEFG
///     </item>
/// </list>
/// <para>
///     Dica: Você pode usar o método Substring() presente na classe String para poder retornar
///     os caracteres a partir da quarta posição.
/// </para>
/// </summary>
internal static class Answer
{
    internal static void Run()
    {
        Console.WriteLine(Process(null));
        Console.WriteLine(Process("ab"));
        Console.WriteLine(Process("abcdefg"));
    }

    internal static string? Process(string? s)
    {
        if (s == null)
        {
            return null;
        }

        if (s.Length <= 3)
        {
            return s.ToUpper();
        }

        return $"???{s.Substring(3).ToUpper()}";
    }
}
