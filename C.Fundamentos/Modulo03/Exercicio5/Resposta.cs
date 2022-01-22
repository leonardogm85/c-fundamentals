namespace C.Fundamentos.Modulo03.Exercicio5
{
    /// <summary>
    /// <para>
    ///     Imprima os 15 primeiros números da série de Fibonacci. A série de Fibonacci possui a seguinte
    ///     sequência numérica: 0, 1, 1, 2, 3, 5, 8, 13, 21, etc.
    /// </para>
    /// <para>
    ///     Para calculá-la, o primeiro e segundo elementos valem 1, daí por diante, o n-ésimo elemento
    ///     vale o(n-1)-ésimo elemento somado ao(n-2)-ésimo elemento(ex: 8 = 5 + 3).
    /// </para>
    /// </summary>
    public static class Resposta
    {
        public static void Executar()
        {
            string? item = null;

            int ultimo = 0;
            int penultimo = 0;

            for (int numero = 0; numero < 15; numero++)
            {
                if (numero == 0)
                {
                    item = numero.ToString();
                }
                else if (numero == 1)
                {
                    item += $", {numero}";

                    ultimo = 1;
                }
                else
                {
                    int atual = ultimo + penultimo;

                    penultimo = ultimo;
                    ultimo = atual;

                    item += $", {atual}";
                }
            }

            Console.WriteLine($"Resultado: {item}");
        }
    }
}
