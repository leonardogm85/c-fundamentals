namespace C.Fundamentos.Modulo09.Exercicio2
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
    public static class Resposta
    {
        public static void Executar()
        {
            try
            {
                object? o = null;
                o.ToString();
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Referência de objeto não definida para uma instância de um objeto.");
            }

            Console.WriteLine("Processo finalizado.");
        }
    }
}
