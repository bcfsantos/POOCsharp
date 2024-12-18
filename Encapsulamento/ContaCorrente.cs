namespace Encapsulamento
{
    public class ContaCorrente
    {
        private decimal _saldo;
        public void Depositar(decimal valor)
        {
            if (valor > 0)
                _saldo += valor;
            else
                throw new Exception("O valor deve ser positivo.");
        }
        public decimal ConsultarSaldo()
        {
            return _saldo;
        }
    }
}
