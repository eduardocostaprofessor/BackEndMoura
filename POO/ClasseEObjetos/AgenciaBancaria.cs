namespace ClasseEObjetos
{
    public class AgenciaBancaria
    {
        public string Titular = "";
        public float Saldo;

        public void Depopsitar(float _valorSaque)
        {
            if (_valorSaque <= 0)
            {
                Console.WriteLine($"O valor do saldo deve ser maior do que R$ 0");
                return;
            }

            Saldo += _valorSaque;
            Console.WriteLine($"Depósito realizado. Novo Saldo: {Saldo}");
        } 


        public void Sacar(float _valorSaque)
        {
            if (_valorSaque <= 0 && _valorSaque < Saldo)
            {//valor negativo ou saldo insuficiente
                Console.WriteLine($"Saldo Atual: {Saldo}");
                Console.WriteLine($"Não é possível sacar este valor solicitado, por favor insira um valor válido ");
                return; //parar por aqui para evitar o saque abaixo
            }

            Saldo -= _valorSaque;

            Console.WriteLine($"Saque realizado. Novo Saldo: {Saldo}");
            
        }
    }//fim da classe
}//fim do namespace