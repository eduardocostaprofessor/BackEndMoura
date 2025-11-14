
namespace Exemplos
{
    public class ContaPoupanca : ContaBancaria
    {
        public double Saldo = 0;
        public override void Depositar(double valor)
        {
            if(valor <= 0)
            {
                Console.WriteLine($"O valor do depósito deve ser positivo");
                return;//para a execução do método aqui
            }
            
            Saldo += valor;
        }

        public override void Sacar(double valor)
        {
            throw new NotImplementedException();
        }
    }
}