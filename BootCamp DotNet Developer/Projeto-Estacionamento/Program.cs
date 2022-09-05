using Projeto_Estacionamento.Models;

Estacionamento est = new Estacionamento();

decimal precoInicial = 0;
decimal precoHora = 0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                    "Digite o preço inicial:");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora:");
precoHora = Convert.ToDecimal(Console.ReadLine());

string opcao = string.Empty;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("*****  DIGITE UMA OPÇAO: *****");
    Console.WriteLine("1 - CADASTRAR VEÍCULO");
    Console.WriteLine("2 - REMOVER VEÍCULO");
    Console.WriteLine("3 - LISTAR VEÍCULOS");
    Console.WriteLine("4 - ENCERRAR");
    Console.WriteLine("****************************");

    switch (Console.ReadLine())
    {
        //case "1":

        
    }

}

