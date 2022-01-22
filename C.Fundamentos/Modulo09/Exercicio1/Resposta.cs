namespace C.Fundamentos.Modulo09.Exercicio1
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
    public static class Resposta
    {
        public static void Executar()
        {
            ContaBancaria contaBancaria1 = new ContaBancaria();
            ContaBancaria contaBancaria2 = new ContaBancaria();

            contaBancaria1.Depositar(500);
            contaBancaria1.Sacar(250);
            contaBancaria1.Transferir(50, contaBancaria2);

            try
            {
                contaBancaria2.Depositar(0);
            }
            catch (ValorInvalidoException exception)
            {
                Console.WriteLine($"{exception.Message} -> Valor: {exception.Valor}");
            }

            try
            {
                contaBancaria2.Sacar(-1);
            }
            catch (ValorInvalidoException exception)
            {
                Console.WriteLine($"{exception.Message} -> Valor: {exception.Valor}");
            }

            try
            {
                contaBancaria2.Sacar(100);
            }
            catch (SaldoInsuficienteException exception)
            {
                Console.WriteLine($"{exception.Message} -> Saldo: {exception.Saldo}");
            }

            try
            {
                contaBancaria2.Transferir(-1, contaBancaria1);
            }
            catch (ValorInvalidoException exception)
            {
                Console.WriteLine($"{exception.Message} -> Valor: {exception.Valor}");
            }

            try
            {
                contaBancaria2.Transferir(100, contaBancaria1);
            }
            catch (SaldoInsuficienteException exception)
            {
                Console.WriteLine($"{exception.Message} -> Saldo: {exception.Saldo}");
            }
        }
    }

    public class ContaBancaria
    {
        protected double Saldo { get; set; }

        public void Depositar(double valor)
        {
            if (valor <= 0)
            {
                throw new ValorInvalidoException("O valor a ser depositado não deve ser menor ou igual a zero.", valor);
            }

            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (valor <= 0)
            {
                throw new ValorInvalidoException("O valor a ser sacado não deve ser menor ou igual a zero.", valor);
            }

            if (valor > Saldo)
            {
                throw new SaldoInsuficienteException("O valor a ser sacado não deve ser maior que o saldo.", Saldo);
            }

            Saldo -= valor;
        }

        public void Transferir(double valor, ContaBancaria contaBancaria)
        {
            if (valor <= 0)
            {
                throw new ValorInvalidoException("O valor a ser transferido não deve ser menor ou igual a zero.", valor);
            }

            if (valor > Saldo)
            {
                throw new SaldoInsuficienteException("O valor a ser transferido não deve ser maior que o saldo.", Saldo);
            }

            Sacar(valor);
            contaBancaria.Depositar(valor);
        }
    }

    public class ValorInvalidoException : Exception
    {
        public double Valor { get; private set; }

        public ValorInvalidoException(string message, double valor)
            : base(message)
        {
            Valor = valor;
        }
    }

    public class SaldoInsuficienteException : Exception
    {
        public double Saldo { get; private set; }

        public SaldoInsuficienteException(string message, double saldo)
            : base(message)
        {
            Saldo = saldo;
        }
    }
}
