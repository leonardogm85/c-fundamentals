namespace C.Fundamentals.Module09.Question02
{
    /// <summary>
    /// <para>
    ///     Imagine que a sua aplicação é composta pelo seguinte código:
    /// </para>
    /// <code>
    ///     object o = null;
    ///     o.toString();
    /// </code>
    /// <para>
    ///     Se você executar este código irá perceber que uma exceção será lançada. Identifique que
    ///     exceção é esta e altere este mesmo código para que ele exiba uma mensagem amigável de
    ///     erro e termine normalmente.
    /// </para>
    /// </summary>
    internal static class Answer
    {
        internal static void Run()
        {
            try
            {
                object? o = null;
                o!.ToString();
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Object reference not set to an instance of an object.");
            }

            Console.WriteLine("Process finished.");
        }
    }
}
