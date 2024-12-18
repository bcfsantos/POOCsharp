namespace Polimorfismo
{
    public class Conta
    {
        public string NumeroConta { get; set; }
        public string Titular { get; set; }
        public decimal Saldo { get; protected set; }

        public Conta(string numeroConta, string titular, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            Titular = titular;
            Saldo = saldoInicial;
        }

        public virtual void Sacar(decimal valor)
        {
            if (valor <= 0 || valor > Saldo)
            {
                Console.WriteLine("Saque inválido. Verifique o saldo e o valor solicitado.");
                return;
            }

            Saldo -= valor;
            Console.WriteLine($"[Conta] Saque de {valor:C} realizado. Saldo atual: {Saldo:C}");
        }

        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"Conta: {NumeroConta}, Titular: {Titular}, Saldo: {Saldo:C}");
        }
    }
}
