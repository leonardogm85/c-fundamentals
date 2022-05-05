namespace C.Fundamentals.Module08.Question05
{
    /// <summary>
    /// <para>
    ///     Crie uma classe ContaBancaria, que representa uma conta bancária genérica que não pode ser
    ///     instanciada. Esta classe deve ter uma property Saldo(visível apenas para ela e para as suas
    ///     subclasses) e os métodos Depositar(double), Sacar(double) e Transferir(double,
    ///     ContaBancaria). Estes métodos devem depositar um valor na conta, sacar um valor da conta e
    ///     transferir um valor da conta de origem para uma conta de destino, respectivamente.
    /// </para>
    /// <para>
    ///     Além destes, ContaBancaria deve ter um método CalcularSaldo(). Este método possui a regra
    ///     do cálculo do saldo final(que pode ser diferente do saldo armazenado em Saldo) e deve ser
    ///     obrigatoriamente implementado pelas subclasses de ContaBancaria, pois cada classe possui
    ///     suas próprias regras de cálculo.
    /// </para>
    /// <para>
    ///     Crie duas subclasses de ContaBancaria: ContaCorrente e ContaInvestimento. Cada uma deverá
    ///     implementar suas regras para calcular o saldo(método CalcularSaldo()). No caso de
    ///     ContaCorrente, o saldo final é o saldo atual subtraído de 10%, referente a impostos que
    ///     devem ser pagos. Já para a ContaInvestimento, o saldo final é o saldo atual acrescido de 5%,
    ///     referente aos rendimentos do dinheiro investido.
    /// </para>
    /// <para>
    ///     Crie uma aplicação que instancia uma conta corrente e uma conta investimento e executa as
    ///     operações de depósito, saque, transferência e cálculo de saldo. Verifique se os resultados
    ///     obtidos são consistentes com a proposta do modelo e com as regras de cálculo estabelecidas.
    /// </para>
    /// </summary>
    internal static class Answer
    {
        internal static void Run()
        {
            BankAccount checkingAccount = new CheckingAccount();
            BankAccount investmentAccount = new InvestmentAccount();

            checkingAccount.Deposit(300);
            checkingAccount.Withdraw(100);
            checkingAccount.Transfer(50, investmentAccount);

            investmentAccount.Deposit(400);
            investmentAccount.Withdraw(200);
            investmentAccount.Transfer(100, checkingAccount);

            Console.WriteLine($"Saldo da conta corrente: {checkingAccount.CalculateBalance()}");
            Console.WriteLine($"Saldo da conta investimento: {investmentAccount.CalculateBalance()}");
        }
    }

    internal abstract class BankAccount
    {
        protected double Balance { get; set; }

        public void Deposit(double value)
        {
            Balance += value;
        }

        public void Withdraw(double value)
        {
            Balance -= value;
        }

        public void Transfer(double value, BankAccount bankAccount)
        {
            Withdraw(value);
            bankAccount.Deposit(value);
        }

        public abstract double CalculateBalance();
    }

    internal class CheckingAccount : BankAccount
    {
        public override double CalculateBalance()
        {
            return Balance * 0.9;
        }
    }

    internal class InvestmentAccount : BankAccount
    {
        public override double CalculateBalance()
        {
            return Balance * 1.05;
        }
    }
}
