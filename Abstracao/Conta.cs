namespace Abstracao
{
    public abstract class Conta
    {
        public string NumeroConta { get; set; }
        public string Titular { get; set; }
        public decimal Saldo { get; protected set; }

        // Construtor da classe abstrata
        public Conta(string numeroConta, string titular, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            Titular = titular;
            Saldo = saldoInicial;
        }

        // Método abstrato: cada tipo de conta deve implementar
        public abstract void Sacar(decimal valor);

        // Método concreto: já implementado, pode ser usado sem sobrescrita
        public void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor do depósito deve ser positivo.");
                return;
            }

            Saldo += valor;
            Console.WriteLine($"Depósito de {valor:C} realizado. Saldo atual: {Saldo:C}");
        }

        // Método para exibir informações da conta
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Conta: {NumeroConta}, Titular: {Titular}, Saldo: {Saldo:C}");
        }
    }

}
