using Exercicio02;

// criar uma lista para faturas, relatórios e contratos
List<IImprimivel> documentos = new List<IImprimivel>();



// Criar um menu


int opcao;

do
{
    Console.Clear();
    Console.Write($@"Menu de Opções
    1) Cadastrar Fatura
    2) Cadastrar Relatório
    3) Cadastrar Contrato
    4) Listar Faturas
    5) Listar Relatórios
    6) Listar Contratos
    0) Sair
    Escolha a opção:
    ");
    opcao = int.Parse(Console.ReadLine());

    //criar um swith case para as opções do menu
    switch (opcao)
    {
        case 1:
            CadastrarFaturas();
            break;
        case 2:
            Console.WriteLine($"Cadastrar Relatório em desenvolvimento");
            break;
        case 3:
            Console.WriteLine($"Cadastrar Contrato em desenvolvimento");
            break;
        case 4:
            ListarFaturas();
            break;
        case 5:
            Console.WriteLine($"Listar Relatórios em desenvolvimento");
            break;
        case 6:
            Console.WriteLine($"Listar Contratos em desenvolvimento");
            break;
        case 0:
            Console.WriteLine($"Sair");
            break;
        default:
            Console.WriteLine($"Opção Inválida");
            break;
    }

    Console.WriteLine($"Pressione <Enter> para continuar");
    Console.ReadLine();//faz uma parada no sistema nesse momento

} while (opcao != 0);



// Funções Auxiliares
void CadastrarFaturas()
{
    Console.Write($"Digite o nome do Cliente Devedor");
    string dev = Console.ReadLine();

    Console.Write($"Digite o nome da empresa");
    string empresa = Console.ReadLine();

    Console.Write($"Digite o valor da fatura");
    float valor = float.Parse(Console.ReadLine());


    Console.Write($"Dias de atraso da fatura?");
    int qtdAtraso = int.Parse(Console.ReadLine());

    Fatura fat = new Fatura(dev, empresa, valor, qtdAtraso);
    documentos.Add(fat);

    Console.WriteLine($"Fatura cadastrada com sucesso!");
}

void CadastrarContratos()
{

}

void CadastrarRelatorios()
{

}

void ListarContratos()
{

}

void ListarFaturas()
{
    Console.WriteLine($"Listando Faturas:");
    foreach (var item in documentos)
    {
        if (item is Fatura)
        {
            item.Imprimir();
        }
    }

}

void ListarRelatorios()
{

}



// para cada opção vamos chamar uma função auxiliar













// // Cria um objeto de cada classe e adiciona nas listas
// Fatura fatEdu = new Fatura();
// documentos.Add(fatEdu);

// Fatura fatAle = new Fatura();
// documentos.Add(fatAle);

// Relatorio relEdu = new Relatorio();
// documentos.Add(relEdu);

// Contrato contEdu = new Contrato();
// documentos.Add(contEdu);

// // Listar os dados da fatura

// Console.WriteLine($"FATURAS:");
// foreach (var fat in documentos)
// {
//     if (fat is Fatura)
//     {//se for fatura
//         fat.Imprimir();

//     }
// }

// Console.WriteLine($"CONTRATOS:");
// foreach (var item in documentos)
// {
//     if (item is Contrato)
//     {
//         item.Imprimir();
//     }
// }

// Console.WriteLine($"RELÁTORIOS:");

// foreach (var item in documentos)
// {
//     if (item is Relatorio)
//     {
//         item.Imprimir();
//     }
// }