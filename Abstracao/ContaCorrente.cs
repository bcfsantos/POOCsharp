namespace Abstracao
{
    public class ContaCorrente : Conta
    {
        public decimal LimiteChequeEspecial { get; set; }

        public ContaCorrente(string numeroConta, string titular, decimal saldoInicial, decimal limiteChequeEspecial)
            : base(numeroConta, titular, saldoInicial)
        {
            LimiteChequeEspecial = limiteChequeEspecial;
        }

        // Implementação do método abstrato
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
    }

}
