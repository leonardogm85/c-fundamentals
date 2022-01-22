namespace C.Fundamentos.Modulo08.Exercicio2
{
    /// <summary>
    /// <para>
    ///     Implemente a classe Colecao e duas subclasses: Pilha e Fila. Uma coleção tem um array de
    ///     dados que fazem parte da coleção.
    /// </para>
    /// <para>
    ///     Tanto a pilha como a fila são coleções. A diferença entre elas está na disciplina de acesso. Na
    ///     pilha, o último elemento inserido é o primeiro a ser removido(como numa pilha de pratos). Na
    ///     fila, o primeiro elemento inserido é o primeiro a ser removido(como numa fila de banco).
    /// </para>
    /// <para>
    ///     Os métodos da classe Colecao responsáveis por estas operações são:
    /// </para>
    /// <list type="bullet">
    ///     <item>
    ///         void InserirItem(object item)
    ///     </item>
    ///     <item>
    ///         object RemoverItem()
    ///     </item>
    /// </list>
    /// <para>
    ///     Crie um método que recebe uma coleção, adiciona alguns elementos e remove estes mesmo
    ///     elementos. Imprima os elementos removidos e veja a diferença no resultado.
    /// </para>
    /// <para>
    ///     Dica: Para resolver este exercício é necessário conhecer a respeito de arrays. Se você não está
    ///     familiarizado com eles neste momento, pode voltar a este exercício mais adiante, depois que
    ///     este tema for abordado no curso.
    /// </para>
    /// </summary>
    public static class Resposta
    {
        public static void Executar()
        {
            Pilha pilha = new Pilha(10);
            Imprimir(pilha);

            Fila fila = new Fila(10);
            Imprimir(fila);
        }

        public static void Imprimir(Colecao colecao)
        {
            string tipoColecao = colecao is Pilha
                ? "Pilha"
                : "Fila";

            Console.WriteLine(tipoColecao);

            colecao.InserirItem(2);
            colecao.InserirItem(4);
            colecao.InserirItem(6);
            colecao.InserirItem(8);
            colecao.InserirItem(10);
            colecao.InserirItem(12);
            colecao.InserirItem(14);
            colecao.InserirItem(16);
            colecao.InserirItem(18);
            colecao.InserirItem(20);

            Console.WriteLine(colecao.RemoverItem());
            Console.WriteLine(colecao.RemoverItem());
            Console.WriteLine(colecao.RemoverItem());
            Console.WriteLine(colecao.RemoverItem());
            Console.WriteLine(colecao.RemoverItem());
            Console.WriteLine(colecao.RemoverItem());
            Console.WriteLine(colecao.RemoverItem());
            Console.WriteLine(colecao.RemoverItem());
            Console.WriteLine(colecao.RemoverItem());
            Console.WriteLine(colecao.RemoverItem());

            Console.WriteLine();
        }
    }

    public abstract class Colecao
    {
        protected object?[] Itens { get; set; }

        protected int Posicao { get; set; }

        public Colecao(int tamanho)
        {
            Itens = new object?[tamanho];
        }

        public abstract void InserirItem(object item);

        public abstract object? RemoverItem();
    }

    public class Pilha : Colecao
    {
        public Pilha(int tamanho)
            : base(tamanho)
        {
        }

        public override void InserirItem(object item)
        {
            Itens[Posicao] = item;
            Posicao++;
        }

        public override object? RemoverItem()
        {
            Posicao--;

            object? item = Itens[Posicao];
            Itens[Posicao] = null;

            return item;
        }
    }

    public class Fila : Colecao
    {
        public Fila(int tamanho)
            : base(tamanho)
        {
        }

        public override void InserirItem(object item)
        {
            Itens[Posicao] = item;
            Posicao++;
        }

        public override object? RemoverItem()
        {
            object? item = Itens[0];

            for (int indice = 0; indice < Posicao; indice++)
            {
                Itens[indice] = indice < Posicao - 1
                    ? Itens[indice + 1]
                    : null;
            }

            Posicao--;

            return item;
        }
    }
}
