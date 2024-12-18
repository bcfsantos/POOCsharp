namespace Heranca
{
    internal class Program
    {
        /// <summary>
        /// Herança
        ///Definição: Permite que uma classe herde propriedades e métodos de outra, formando uma relação "é um".
        ///A classe ContaCorrente herda da classe conta, podem reutilizar metodos e propriedades.
        /// </summary>
        static void Main(string[] args)
        {
            var conta = new ContaCorrente("12345-6", "João Silva", 1000.00m, 500.00m);

            Console.WriteLine($"Conta criada: {conta.Titular}, Saldo: {conta.Saldo:C}, Limite: {conta.LimiteChequeEspecial:C}");

            conta.Depositar(200.00m);
            conta.Sacar(1300.00m);
            conta.Sacar(100.00m);

            conta.AjustarLimiteChequeEspecial(1000.00m);
            conta.Sacar(800.00m);
            Console.ReadLine();
        }
    }
}
