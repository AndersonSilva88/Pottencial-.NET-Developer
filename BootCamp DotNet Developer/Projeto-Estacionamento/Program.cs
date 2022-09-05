using Projeto_Estacionamento.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoHora = 0;


Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                    "Digite o preço inicial:");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora:");
precoHora = Convert.ToDecimal(Console.ReadLine());


Estacionamento est = new Estacionamento(precoInicial,precoHora);

string opcao = string.Empty;
bool exibirMenu = true;

while (exibirMenu)
{
    //Console.Clear();
    Console.WriteLine("*****  DIGITE UMA OPÇAO: *****");
    Console.WriteLine("1 - CADASTRAR VEÍCULO");
    Console.WriteLine("2 - REMOVER VEÍCULO");
    Console.WriteLine("3 - LISTAR VEÍCULOS");
    Console.WriteLine("4 - ENCERRAR");
    Console.WriteLine("****************************");

    switch (Console.ReadLine())
    {
        case "1":
            est.AdicionarVeiculo();
            break;
        case "2":
            est.RemoverVeiculo();
            break;
        case "3":
            est.ListarVeiculos();
            break;
        case "4":
            exibirMenu = false;
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;    
    }

    Console.WriteLine("Pressione um tecla para continuar");
    Console.WriteLine();
}

Console.WriteLine("O programa se encerrou");
