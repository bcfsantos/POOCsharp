namespace Heranca
{
    public class Conta
    {
        public string NumeroConta { get; init; }
        public string Titular { get; init; }
        public decimal Saldo { get; protected set; }

        public Conta(string numeroConta, string titular, decimal saldoInicial) =>
            (NumeroConta, Titular, Saldo) = (numeroConta, titular, saldoInicial);

        public virtual void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor do depósito deve ser positivo.");
                return;
            }

            Saldo += valor;
            Console.WriteLine($"Depósito de {valor:C} realizado. Saldo atual: {Saldo:C}");
        }

        public virtual void Sacar(decimal valor)
        {
            if (valor <= 0 || valor > Saldo)
            {
                Console.WriteLine(valor <= 0 ? "Valor inválido." : "Saldo insuficiente.");
                return;
            }

            Saldo -= valor;
            Console.WriteLine($"Saque de {valor:C} realizado. Saldo atual: {Saldo:C}");
        }
    }

}

