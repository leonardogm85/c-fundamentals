namespace C.Fundamentals.Module05.Question02
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
    internal static class Answer
    {
        internal static void Run()
        {
            Test test11 = new Test(4.0, 2.5);
            Test test12 = new Test(1.0, 7.0);

            Test test21 = new Test(6.5, 3.5);
            Test test22 = new Test(0.0, 3.0);

            Test test31 = new Test(5.0, 4.0);
            Test test32 = new Test(6.0, 1.5);

            Student student1 = new Student(test11, test12);
            Student student2 = new Student(test21, test22);
            Student student3 = new Student(test31, test32);

            Class @class = new Class(student1, student2, student3);

            Console.WriteLine("Grade average of the first student: {0}", student1.CalculateAverage());
            Console.WriteLine("Grade average of the second student: {0}", student2.CalculateAverage());
            Console.WriteLine("Grade average of the third student: {0}", student3.CalculateAverage());

            Console.WriteLine("Grade average of the class: {0}", @class.CalculateAverage());
        }
    }

    internal class Class
    {
        private Student student1;
        private Student student2;
        private Student student3;

        public Class(Student student1, Student student2, Student student3)
        {
            this.student1 = student1;
            this.student2 = student2;
            this.student3 = student3;
        }

        public double CalculateAverage()
        {
            return (student1.CalculateAverage() + student2.CalculateAverage() + student3.CalculateAverage()) / 3;
        }
    }

    internal class Student
    {
        private Test test1;
        private Test test2;

        public Student(Test test1, Test test2)
        {
            this.test1 = test1;
            this.test2 = test2;
        }

        public double CalculateAverage()
        {
            return (test1.CalculateTotalGrade() + test2.CalculateTotalGrade()) / 2;
        }
    }

    internal class Test
    {
        private double grade1;
        private double grade2;

        public Test(double grade1, double grade2)
        {
            this.grade1 = grade1;
            this.grade2 = grade2;
        }

        public double CalculateTotalGrade()
        {
            return grade1 + grade2;
        }
    }
}
