namespace C.Fundamentos.Modulo03.Exercicio4
{
    /// <summary>
    /// <para>
    ///     Escreva um programa que calcule o fatorial de 10. A regra do fatorial (!) é a seguinte:
    /// </para>
    /// <code>
    ///     0! = 1
    ///     1! = 0! * 1
    ///     2! = 1! * 2
    ///     ...
    ///     n! = (n - 1)! * n
    /// </code>
    /// </summary>
    public static class Resposta
    {
        public static void Executar()
        {
            int soma = 0;

            for (int numero = 0; numero <= 10; numero++)
            {
                if (numero == 0)
                {
                    soma = 1;
                }
                else
                {
                    soma *= numero;
                }
            }

            Console.WriteLine($"Resultado: {soma}");
        }
    }
}
