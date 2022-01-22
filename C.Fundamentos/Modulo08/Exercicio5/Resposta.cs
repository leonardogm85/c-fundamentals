namespace C.Fundamentos.Modulo08.Exercicio5
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
    public static class Resposta
    {
        public static void Executar()
        {
            ContaBancaria contaCorrente = new ContaCorrente();
            ContaBancaria contaInvestimento = new ContaInvestimento();

            contaCorrente.Depositar(300);
            contaCorrente.Sacar(100);
            contaCorrente.Transferir(50, contaInvestimento);

            contaInvestimento.Depositar(400);
            contaInvestimento.Sacar(200);
            contaInvestimento.Transferir(100, contaCorrente);

            Console.WriteLine($"Saldo da conta corrente: {contaCorrente.CalcularSaldo()}");
            Console.WriteLine($"Saldo da conta investimento: {contaInvestimento.CalcularSaldo()}");
        }
    }

    public abstract class ContaBancaria
    {
        protected double Saldo { get; set; }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            Saldo -= valor;
        }

        public void Transferir(double valor, ContaBancaria contaBancaria)
        {
            Sacar(valor);
            contaBancaria.Depositar(valor);
        }

        public abstract double CalcularSaldo();
    }

    public class ContaCorrente : ContaBancaria
    {
        public override double CalcularSaldo()
        {
            return Saldo * 0.9;
        }
    }

    public class ContaInvestimento : ContaBancaria
    {
        public override double CalcularSaldo()
        {
            return Saldo * 1.05;
        }
    }
}
