namespace C.Fundamentals.Module07.Question02
{
    /// <summary>
    /// <para>
    ///     O C# possui uma interface chamada ICloneable, que pode ser implementada por classes que
    ///     são capazes de gerar cópias de objetos. Classes que implementam esta interface devem
    ///     implementar o método Clone(). Dentro deste método é implementada a lógica para criar um
    ///     novo objeto com base no objeto original.
    /// </para>
    /// <para>
    ///     Com base nisto, crie uma classe Porta que suporta a criação de novos objetos (cópia). Ela deve
    ///     ter os fields altura(double), largura(double) e aberta(boolean). Também deve possuir os
    ///     métodos Abrir(), Fechar() e os valores dos fields devem ser expostos para fora da classe
    ///     através de read-only properties.
    /// </para>
    /// <para>
    ///     Como uma porta pode criar outras cópias dela mesma, você deve implementar o método
    ///     Clone() na classe, o qual deve criar um novo objeto com os valores dos atributos copiados e
    ///     retorná-lo.
    /// </para>
    /// </summary>
    internal static class Answer
    {
        internal static void Run()
        {
            Door door = new Door(2.5, 0.9);
            door.Print();

            Door clone = (Door)door.Clone();
            clone.Print();

            door.TurnOn();
            door.Print();

            clone = (Door)door.Clone();
            clone.Print();

            door.TurnOff();
            door.Print();

            clone = (Door)door.Clone();
            clone.Print();
        }
    }

    internal class Door : ICloneable
    {
        private double height;
        private double width;
        private bool open;

        public Door(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        public double Height { get { return height; } }
        public double Width { get { return width; } }
        public bool Open { get { return open; } }

        public void TurnOn()
        {
            this.open = true;
        }

        public void TurnOff()
        {
            this.open = false;
        }

        public void Print()
        {
            Console.WriteLine("Door = Height: {0}, Width: {1}, Open: {2}", height, width, open);
        }

        public object Clone()
        {
            Door door = new Door(height, width);
            door.open = open;
            return door;
        }
    }
}
