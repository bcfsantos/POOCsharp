namespace Abstracao
{
    internal class Program
    {
        /// <summary>
        /// Abstração
        //Definição: Simplifica sistemas complexos ao expor apenas os detalhes necessários para o uso.
        /// </summary>
        static void Main(string[] args)
        {
            // Criando uma lista de contas, com diferentes tipos de contas(polimorfismo)
            Conta contaCorrente = new ContaCorrente("12345-6", "João Silva", 1000.00m, 500.00m);
            Conta contaPoupanca = new ContaPoupanca("98765-4", "Maria Oliveira", 2000.00m, 0.05m);

            // Exibindo informações e realizando operações
            contaCorrente.ExibirInformacoes();
            contaCorrente.Depositar(300.00m);
            contaCorrente.Sacar(1300.00m);

            Console.WriteLine();

            contaPoupanca.ExibirInformacoes();
            contaPoupanca.Depositar(500.00m);
            contaPoupanca.Sacar(1500.00m);

        }
    }
}
