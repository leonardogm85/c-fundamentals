namespace C.Fundamentals.Module08.Question02
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
    internal static class Answer
    {
        internal static void Run()
        {
            Stack stack = new Stack(10);
            Print(stack);

            Queue queue = new Queue(10);
            Print(queue);
        }

        internal static void Print(Collection collection)
        {
            string collectionType = collection is Stack
                ? "Stack"
                : "Queue";

            Console.WriteLine(collectionType);

            collection.InsertItem(2);
            collection.InsertItem(4);
            collection.InsertItem(6);
            collection.InsertItem(8);
            collection.InsertItem(10);
            collection.InsertItem(12);
            collection.InsertItem(14);
            collection.InsertItem(16);
            collection.InsertItem(18);
            collection.InsertItem(20);

            Console.WriteLine(collection.RemoveItem());
            Console.WriteLine(collection.RemoveItem());
            Console.WriteLine(collection.RemoveItem());
            Console.WriteLine(collection.RemoveItem());
            Console.WriteLine(collection.RemoveItem());
            Console.WriteLine(collection.RemoveItem());
            Console.WriteLine(collection.RemoveItem());
            Console.WriteLine(collection.RemoveItem());
            Console.WriteLine(collection.RemoveItem());
            Console.WriteLine(collection.RemoveItem());

            Console.WriteLine();
        }
    }

    internal abstract class Collection
    {
        protected object?[] Items { get; set; }

        protected int Position { get; set; }

        public Collection(int length)
        {
            Items = new object?[length];
        }

        public abstract void InsertItem(object item);

        public abstract object? RemoveItem();
    }

    internal class Stack : Collection
    {
        public Stack(int length)
            : base(length)
        {
        }

        public override void InsertItem(object item)
        {
            Items[Position] = item;
            Position++;
        }

        public override object? RemoveItem()
        {
            Position--;

            object? item = Items[Position];
            Items[Position] = null;

            return item;
        }
    }

    internal class Queue : Collection
    {
        public Queue(int length)
            : base(length)
        {
        }

        public override void InsertItem(object item)
        {
            Items[Position] = item;
            Position++;
        }

        public override object? RemoveItem()
        {
            object? item = Items[0];

            for (int index = 0; index < Position; index++)
            {
                Items[index] = index < Position - 1
                    ? Items[index + 1]
                    : null;
            }

            Position--;

            return item;
        }
    }
}
