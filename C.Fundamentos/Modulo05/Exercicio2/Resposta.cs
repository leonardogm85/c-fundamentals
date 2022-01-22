namespace C.Fundamentos.Modulo05.Exercicio2
{
    /// <summary>
    /// <para>
    ///     Desenvolva um sistema escolar para cálculos de médias. Ele é composto pelas seguintes
    ///     classes:
    /// </para>
    /// <list type="bullet">
    ///     <item>
    ///         <para>
    ///             Turma
    ///         </para>
    ///         <list type="table">
    ///             <item>
    ///                 + aluno1: Aluno
    ///             </item>
    ///             <item>
    ///                 + aluno2: Aluno
    ///             </item>
    ///             <item>
    ///                 + aluno3: Aluno
    ///             </item>
    ///             <item>
    ///                 + CalcularMedia(): double
    ///             </item>
    ///         </list>
    ///     </item>
    ///     <item>
    ///         <para>
    ///             Aluno
    ///         </para>
    ///         <list type="table">
    ///             <item>
    ///                 + prova1: Prova
    ///             </item>
    ///             <item>
    ///                 + prova2: Prova
    ///             </item>
    ///             <item>
    ///                 + CalcularMedia(): double
    ///             </item>
    ///         </list>
    ///     </item>
    ///     <item>
    ///         <para>
    ///             Prova
    ///         </para>
    ///         <list type="table">
    ///             <item>
    ///                 + notaParte1: double
    ///             </item>
    ///             <item>
    ///                 + notaParte2: double
    ///             </item>
    ///             <item>
    ///                 + CalcularNotaTotal(): double
    ///             </item>
    ///         </list>
    ///     </item>
    /// </list>
    /// <para>
    ///     Uma turma é composta por três alunos. Cada um dos alunos realizou duas provas, onde cada
    ///     prova possuía duas partes.Observe uma descrição sobre o que cada método faz:
    /// </para>
    /// <list type="bullet">
    ///     <item>
    ///         Turma.CalcularMedia(): Calcula a média da turma. A média é calculada utilizando a
    ///         média de cada aluno da turma.
    ///     </item>
    ///     <item>
    ///         Aluno.CalcularMedia(): Calcula a média do aluno. A média é calculada utilizando a
    ///         nota total das duas provas realizadas por ele.
    ///     </item>
    ///     <item>
    ///         Prova.CalcularNotaTotal(): Calcula a nota total da prova. Esta nota é data pela soma
    ///         das notas das partes 1 e 2. A nota total não pode ultrapassar 10.0.
    ///     </item>
    /// </list>
    /// <para>
    ///     Crie uma aplicação que instancia a turma, os três alunos e as duas provas para cada aluno.
    ///     Defina também notas para as provas.A aplicação deve mostrar mensagens informando a
    ///     média de cada aluno e a média geral da turma.
    /// </para>
    /// <para>
    ///     Para a definição das notas, utilize as seguintes informações:
    /// </para>
    /// <list type="bullet">
    ///     <item>Turma.Aluno1.Prova1(4.0, 2.5)</item>
    ///     <item>Turma.Aluno1.Prova2(1.0, 7.0)</item>
    ///     <item>Turma.Aluno2.Prova1(6.5, 3.5)</item>
    ///     <item>Turma.Aluno2.Prova2(0.0, 3.0)</item>
    ///     <item>Turma.Aluno3.Prova1(5.0, 4.0)</item>
    ///     <item>Turma.Aluno3.Prova2(6.0, 1.5)</item>
    /// </list>
    /// </summary>
    public static class Resposta
    {
        public static void Executar()
        {
            Prova prova11 = new Prova(4.0, 2.5);
            Prova prova12 = new Prova(1.0, 7.0);

            Prova prova21 = new Prova(6.5, 3.5);
            Prova prova22 = new Prova(0.0, 3.0);

            Prova prova31 = new Prova(5.0, 4.0);
            Prova prova32 = new Prova(6.0, 1.5);

            Aluno aluno1 = new Aluno(prova11, prova12);
            Aluno aluno2 = new Aluno(prova21, prova22);
            Aluno aluno3 = new Aluno(prova31, prova32);

            Turma turma = new Turma(aluno1, aluno2, aluno3);

            Console.WriteLine($"Média do primeiro aluno: {aluno1.CalcularMedia()}");
            Console.WriteLine($"Média do segundo aluno: {aluno2.CalcularMedia()}");
            Console.WriteLine($"Média do terceiro aluno: {aluno3.CalcularMedia()}");

            Console.WriteLine($"Média da turma: {turma.CalcularMedia()}");
        }
    }

    public class Turma
    {
        private Aluno aluno1;
        private Aluno aluno2;
        private Aluno aluno3;

        public Turma(Aluno aluno1, Aluno aluno2, Aluno aluno3)
        {
            this.aluno1 = aluno1;
            this.aluno2 = aluno2;
            this.aluno3 = aluno3;
        }

        public double CalcularMedia()
        {
            return (aluno1.CalcularMedia() + aluno2.CalcularMedia() + aluno3.CalcularMedia()) / 3;
        }
    }

    public class Aluno
    {
        private Prova prova1;
        private Prova prova2;

        public Aluno(Prova prova1, Prova prova2)
        {
            this.prova1 = prova1;
            this.prova2 = prova2;
        }

        public double CalcularMedia()
        {
            return (prova1.CalcularNotaTotal() + prova2.CalcularNotaTotal()) / 2;
        }
    }

    public class Prova
    {
        private double notaParte1;
        private double notaParte2;

        public Prova(double notaParte1, double notaParte2)
        {
            this.notaParte1 = notaParte1;
            this.notaParte2 = notaParte2;
        }

        public double CalcularNotaTotal()
        {
            return notaParte1 + notaParte2;
        }
    }
}
