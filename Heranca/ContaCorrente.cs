namespace Heranca
{
    public class ContaCorrente : Conta
    {
        public decimal LimiteChequeEspecial { get; private set; }

        public ContaCorrente(string numeroConta, string titular, decimal saldoInicial, decimal limiteChequeEspecial)
            : base(numeroConta, titular, saldoInicial) =>
            LimiteChequeEspecial = limiteChequeEspecial;

        public override void Sacar(decimal valor)
        {
            if (valor <= 0 || valor > (Saldo + LimiteChequeEspecial))
            {
                Console.WriteLine(valor <= 0 ? "Valor inválido." : "Saldo insuficiente, incluindo o limite.");
                return;
            }

            Saldo -= valor;
            Console.WriteLine($"Saque de {valor:C} realizado. Saldo atual: {Saldo:C}");
        }

        public void AjustarLimiteChequeEspecial(decimal novoLimite) =>
            LimiteChequeEspecial = novoLimite >= 0
                ? novoLimite
                : throw new ArgumentException("Limite não pode ser negativo.");
    }

}
