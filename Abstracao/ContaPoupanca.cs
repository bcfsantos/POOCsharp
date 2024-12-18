namespace Abstracao
{
    public class ContaPoupanca : Conta
    {
        public decimal TaxaJuros { get; set; }

        public ContaPoupanca(string numeroConta, string titular, decimal saldoInicial, decimal taxaJuros)
            : base(numeroConta, titular, saldoInicial)
        {
            TaxaJuros = taxaJuros;
        }

        // Implementação do método abstrato
        public override void Sacar(decimal valor)
        {
            if (valor <= 0 || valor > Saldo)
            {
                Console.WriteLine("Saque inválido. Verifique o saldo.");
                return;
            }

            Saldo -= valor;
            Console.WriteLine($"[Conta Poupança] Saque de {valor:C} realizado. Saldo atual: {Saldo:C}");
        }
    }
}
