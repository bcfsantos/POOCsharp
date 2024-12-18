namespace Polimorfismo
{
    public class ContaCorrente : Conta
    {
        public decimal LimiteChequeEspecial { get; private set; }

        public ContaCorrente(string numeroConta, string titular, decimal saldoInicial, decimal limiteChequeEspecial)
            : base(numeroConta, titular, saldoInicial)
        {
            LimiteChequeEspecial = limiteChequeEspecial;
        }

        public override void Sacar(decimal valor)
        {
            if (valor <= 0 || valor > (Saldo + LimiteChequeEspecial))
            {
                Console.WriteLine("Saque inválido. O valor excede o saldo e o limite do cheque especial.");
                return;
            }

            Saldo -= valor;
            Console.WriteLine($"[Conta Corrente] Saque de {valor:C} realizado. Saldo atual: {Saldo:C}");
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Conta: {NumeroConta}, Titular: {Titular}, Saldo: {Saldo:C}, Limite: {LimiteChequeEspecial:C}");
        }
    }
}
