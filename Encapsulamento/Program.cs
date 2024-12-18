namespace Encapsulamento
{
    internal class Program
    {
        /// <summary>
        /// Encapsulamento
        /// Definição: Esconde os detalhes internos de uma classe, expondo apenas o necessário através de métodos ou propriedades públicas. 
        /// Dentro da classe ContaCorrente temos a propriedade _saldo que foi encapsulada com o modificador de acesso private
        /// </summary>
        static void Main(string[] args)
        {
            var contaCorrente = new ContaCorrente();
            contaCorrente.Depositar(1000);
            Console.WriteLine($"Novo saldo R$: {contaCorrente.ConsultarSaldo()}");
            Console.ReadLine();
        }


    }
}
