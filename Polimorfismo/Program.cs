namespace Polimorfismo
{
    internal class Program
    {
        /// <summary>
        /// Polimorfismo
        //Definição: Permite que diferentes classes implementem o mesmo método de formas distintas.
        ///Na classe conta podemos ver o método sacar virtual e na classe ContaCorrente o método sacar é implementado de forma diferente 
        ///utilizando o override.
        /// </summary>
        static void Main(string[] args)
        {
            List<Conta> contas = new List<Conta>
            {
                new Conta("12345-6", "João Silva", 1000.00m),
                new ContaCorrente("67890-1", "Maria Oliveira", 2000.00m, 500.00m)
            };

            foreach (var conta in contas)
            {
                conta.ExibirInformacoes();

                // Chamando o método Sacar
                conta.Sacar(1500.00m); // Polimorfismo em ação.

                // Usando conversão explícita para chamar o método específico de ContaCorrente
                if (conta is ContaCorrente contaCorrente)
                {
                    Console.WriteLine("Chamando o método específico de ContaCorrente...");
                    contaCorrente.Sacar(2500.00m);

                }

                Console.WriteLine();

            }
        }
    }
}
