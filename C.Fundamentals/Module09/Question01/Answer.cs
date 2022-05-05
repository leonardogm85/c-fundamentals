namespace C.Fundamentals.Module09.Question01
{
    /// <summary>
    /// <para>
    ///     Crie uma classe ContaBancaria que possui um saldo como field e os métodos Sacar(double),
    ///     Depositar(double) e Transferir(double, ContaBancaria). Crie também duas exceções:
    ///     ValorInvalidoException e SaldoInsuficienteException.
    /// </para>
    /// <para>
    ///     A exceção ValorInvalidoException deve ser lançada se o valor utilizado nas operações de
    ///     depósito, saque ou transferência for igual ou inferior a 0. Já a exceção
    ///     SaldoInsuficienteException deve ser lançada se o valor de um saque ou transferência for
    ///     superior ao saldo disponível. No construtor de ValorInvalidoException é necessário fornecer
    ///     uma mensagem de erro e o valor inválido utilizado. E no construtor de
    ///     SaldoInsuficienteException é necessário fornecer uma mensagem de erro e também o saldo
    ///     disponível.
    /// </para>
    /// <para>
    ///     Crie uma classe que instancia duas contas e tenta realizar operações de depósito, saque e
    ///     transferência. Faça transações corretas e também transações que geram exceção. Quando a
    ///     transação gerar exceção, faça um catch da mesma, imprima a mensagem de erro e o valor
    ///     inválido utilizado(para ValorInvalidoException) ou o saldo disponível(para
    ///     SaldoInsuficienteException).
    /// </para>
    /// </summary>
    internal static class Answer
    {
        internal static void Run()
        {
            BankAccount bankAccount1 = new BankAccount();
            BankAccount bankAccount2 = new BankAccount();

            bankAccount1.Deposit(500);
            bankAccount1.Withdraw(250);
            bankAccount1.Transfer(50, bankAccount2);

            try
            {
                bankAccount2.Deposit(0);
            }
            catch (InvalidValueException exception)
            {
                Console.WriteLine($"{exception.Message} -> Valor: {exception.Value}");
            }

            try
            {
                bankAccount2.Withdraw(-1);
            }
            catch (InvalidValueException exception)
            {
                Console.WriteLine($"{exception.Message} -> Valor: {exception.Value}");
            }

            try
            {
                bankAccount2.Withdraw(100);
            }
            catch (InsufficientBalanceException exception)
            {
                Console.WriteLine($"{exception.Message} -> Saldo: {exception.Balance}");
            }

            try
            {
                bankAccount2.Transfer(-1, bankAccount1);
            }
            catch (InvalidValueException exception)
            {
                Console.WriteLine($"{exception.Message} -> Valor: {exception.Value}");
            }

            try
            {
                bankAccount2.Transfer(100, bankAccount1);
            }
            catch (InsufficientBalanceException exception)
            {
                Console.WriteLine($"{exception.Message} -> Saldo: {exception.Balance}");
            }
        }
    }

    internal class BankAccount
    {
        protected double Balance { get; set; }

        public void Deposit(double value)
        {
            if (value <= 0)
            {
                throw new InvalidValueException("O valor a ser depositado não deve ser menor ou igual a zero.", value);
            }

            Balance += value;
        }

        public void Withdraw(double value)
        {
            if (value <= 0)
            {
                throw new InvalidValueException("O valor a ser sacado não deve ser menor ou igual a zero.", value);
            }

            if (value > Balance)
            {
                throw new InsufficientBalanceException("O valor a ser sacado não deve ser maior que o saldo.", Balance);
            }

            Balance -= value;
        }

        public void Transfer(double value, BankAccount bankAccount)
        {
            if (value <= 0)
            {
                throw new InvalidValueException("O valor a ser transferido não deve ser menor ou igual a zero.", value);
            }

            if (value > Balance)
            {
                throw new InsufficientBalanceException("O valor a ser transferido não deve ser maior que o saldo.", Balance);
            }

            Withdraw(value);
            bankAccount.Deposit(value);
        }
    }

    internal class InvalidValueException : Exception
    {
        public double Value { get; private set; }

        public InvalidValueException(string message, double value)
            : base(message)
        {
            Value = value;
        }
    }

    internal class InsufficientBalanceException : Exception
    {
        public double Balance { get; private set; }

        public InsufficientBalanceException(string message, double balance)
            : base(message)
        {
            Balance = balance;
        }
    }
}
