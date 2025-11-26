namespace Exercicio02
{
    public class Contrato : IImprimivel
    {
        public string Nome;
        public string TextoClausulas;
        public void Imprimir()
        {
            Console.WriteLine($"Imprimindo o contrato ...");
        }
    }
}


// Fazer a funcão de cadastrar e listar de contratos e relatórios.