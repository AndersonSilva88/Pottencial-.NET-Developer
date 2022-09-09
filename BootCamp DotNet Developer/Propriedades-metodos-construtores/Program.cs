using Propriedades_metodos_construtores.Models;
using System.Globalization;
using Newtonsoft.Json;

int quantidadeEntradas = 3;

while (quantidadeEntradas > 0)
{
    var numeroQuantidade = Int32.Parse(Console.ReadLine());

    if (numeroQuantidade >= 1 && numeroQuantidade <= 500)
    {
        string[] tartarugas = Console.ReadLine().Split(" ");
        var maiorVelocidade = Int32.Parse(tartarugas[0]);

        for (int i = 1; i < numeroQuantidade; i++)
        {
            var tartaruga = Int32.Parse(tartarugas[i]);

            if (tartaruga > maiorVelocidade)
            {
                maiorVelocidade = tartaruga;
            }
        }

        if (maiorVelocidade < 10)
        {
            Console.WriteLine(1);
        }
        else if (maiorVelocidade >= 10 && maiorVelocidade < 20)
        {
            Console.WriteLine(2);
        }
        else if (maiorVelocidade >= 20)
        {
            Console.WriteLine(3);
        }

        quantidadeEntradas--;
    }
    else
    {
        Console.WriteLine("Insira um numero entre 1 e 500");
    }

}



// double salario = 0.00;
// double reajuste = 0.00;
// double novoSalario = 0.00;
// double percentual = 0.00;

// salario = Convert.ToDouble(Console.ReadLine());

// if (salario < 0.0)
// {
//     return;
// }
// else if (salario >= 0.0 && salario <= 400.00)
// {
//     percentual = 15.0 / 100.00;
//     reajuste = salario * percentual;
//     novoSalario = reajuste + salario;
// }
// else if (salario > 400.00 && salario <= 800.00)
// {
//     percentual = 12.0 / 100.00;
//     reajuste = salario * percentual;
//     novoSalario = reajuste + salario;
// }
// else if (salario > 800.00 && salario <= 1200.00)
// {
//     percentual = 10.0 / 100.00;
//     reajuste = salario * percentual;
//     novoSalario = reajuste + salario;
// }
// else if (salario > 1200.00 && salario <= 2000.00)
// {
//     percentual = 7.0 / 100.00;
//     reajuste = salario * percentual;
//     novoSalario = reajuste + salario;
// }
// else
// {
//     percentual = 4.0 / 100.0;
//     reajuste = salario * percentual;
//     novoSalario = reajuste + salario;
// }

// Console.WriteLine("Novo salario {0:0.00}", novoSalario);
// Console.WriteLine("Reajuste ganho : {0:0.00}", reajuste);
// Console.WriteLine("Em percentual: {0} %", percentual * 100.00);

// int n = int.Parse(Console.ReadLine());

// int[] num = new int[n];

// for (int i = 0; i < n; i++)
// {
//     num[i] = int.Parse(Console.ReadLine());
// }

// Console.WriteLine(NumVez(num));


// static int NumVez(int[] nums)
// {
//     int m = 0;
//     int aux = 0;

//     for (int j = 0; j < nums.Length; j++)
//     {
//         int count = 0;

//         for (int x = 0; x < nums.Length; x++)
//         {
//             if (nums[j] == nums[x])
//             {
//                 count++;
//             }
//         }

//         if (count > aux)
//         {
//             m = nums[j];
//             aux = count;
//         }
//     }

//     return m;
// }



// int numero = 10;
// bool par = false;

// par = numero.EhPar();

// string mensagem = "O número " + numero + " " + "é " + (par ? "par" : "impar");
// Console.WriteLine(mensagem);

// MeuArray<int> arrayInteiro = new MeuArray<int>();

// arrayInteiro.AdicionarElementoArray(10);

// Console.WriteLine(arrayInteiro[0]);

// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// var listaAnonima = listaVenda.Select(x => new { x.Produto, x.Preco });

// foreach (var venda in listaAnonima)
// {
//     Console.WriteLine($"Produto: {venda.Produto}, Preço: {venda.Preco}");
// }

// var tipoAnonimo = new { Nome = "Anderson", Sobreome = "Silva", Altura = 1.90 };

// Console.WriteLine("Nome: " + tipoAnonimo.Nome);
// Console.WriteLine("Sobrenome: " + tipoAnonimo.Sobreome);
// Console.WriteLine("Altura: " + tipoAnonimo.Altura);

// string conteudo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudo);

// foreach (Venda venda in listaVenda)
// {
//     Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, " +
//                     $"Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}" +
//                     $", Desconto: {venda.Desconto}");
// }



// bool? desejaReceberEmail = null;

// if (desejaReceberEmail.HasValue && desejaReceberEmail.Value)
// {
//     Console.WriteLine("O Usuário optou em receber e-mail");
// }
// else
// {
//     Console.WriteLine("O usuário não respondeu ou optou por não receber e-mail");
// }



// string conteudo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudo);

// foreach (Venda venda in listaVenda)
// {
//     Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, " +
//                     $"Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
// }

// DateTime DataAtual = DateTime.Now;

// List<Venda> listaVenda = new List<Venda>();

// Venda venda = new Venda(1, "Caneta", 10.0M, DataAtual);
// Venda venda1 = new Venda(2, "Lapis", 5.50M, DataAtual);
// Venda venda2 = new Venda(3, "Borracha", 1.50M, DataAtual);
// Venda venda3 = new Venda(4, "Apontador", 2.50M, DataAtual);

// listaVenda.Add(venda);
// listaVenda.Add(venda1);
// listaVenda.Add(venda2);
// listaVenda.Add(venda3);

// string serializado = JsonConvert.SerializeObject(listaVenda, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json", serializado);

// Console.WriteLine(serializado);



// int numero = 10;
// bool ehPar = false;

// ehPar = numero % 2 == 0;
// Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "impar"));

// if (numero % 2 == 0)
// {
//     Console.WriteLine($"O Número {numero} é par");
// }
// else
// {
//     Console.WriteLine($"O Número é impar");
// }



// Pessoa pessoa = new Pessoa("Anderson", "Silva");

// (string nome, string sobrenome) = pessoa;

// Console.WriteLine($"{nome} {sobrenome}");


// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if (sucesso)
// {
//     Console.WriteLine("Quantidade linhas do arquivo: " + quantidadeLinhas);
//     foreach (string linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Não foi possivel ler o arquivo");
// }



// (int Id, string Nome, string Sobrenome) tupla = (1, "Anderson", "Silva");


// Console.WriteLine($"Id: {tupla.Id}");
// Console.WriteLine($"Nome: {tupla.Nome}");
// Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");


// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("PR", "Paraná");
// estados.Add("SP", "São Paulo");
// estados.Add("MG", "Minas Gerais");

// foreach (KeyValuePair<string, string> item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
// }
// Console.WriteLine("**** Removendo ******");
// estados.Remove("SP");

// foreach (KeyValuePair<string, string> item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
// }

// Stack<int> pilha = new Stack<int>();
// Console.WriteLine("**** Adicionando elementos na pilha ****");
// pilha.Push(2);
// pilha.Push(3);
// pilha.Push(4);
// pilha.Push(5);
// pilha.Push(6);
// pilha.Push(7);
// pilha.Push(8);

// Console.WriteLine("**** PILHA *****");
// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }
// Console.WriteLine("**** Remove Elemento ****");
// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

// Console.WriteLine("**** PILHA *****");
// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(3);
// fila.Enqueue(4);
// fila.Enqueue(5);
// fila.Enqueue(6);
// fila.Enqueue(7);
// fila.Enqueue(8);

// Console.WriteLine("****** FILA ******");
// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine("***** Removendo Elemento *****");
// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

// Console.WriteLine("****** FILA ******");
// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }

// new ExemploExcecao().Metodo1();


// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }

// }
// catch (Exception e)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {e.Message}");
// }
// finally
// {
//     Console.WriteLine("Chegou até aqui");
// }





// DateTime data = DateTime.Now;
// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));

// Console.WriteLine(data.ToShortDateString());
// Console.WriteLine(data.ToShortTimeString());

// string dataString = "2022-04-17 10:00";

// DateTime.TryParseExact(dataString,
//                         "yyyy-MM-dd HH:mm",
//                         CultureInfo.InvariantCulture,
//                         DateTimeStyles.None, out DateTime data1);
// Console.WriteLine(data1);

// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

// decimal valorMonetario = 1582.40m;

// Console.WriteLine($"{valorMonetario:C}");
// Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));

// double procentagem = .3421;

// Console.WriteLine(procentagem.ToString("P"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));


// string numero1 = "10";
// int numero2 = 20;

// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);


// Pessoa pessoa = new Pessoa(nome: "Anderson", sobrenome: "Silva");
// Pessoa pessoa1 = new Pessoa(nome: "Cleberson", sobrenome: "Neves");

// Curso curso = new Curso();

// curso.Nome = "Programação";
// curso.Alunos = new List<Pessoa>();

// curso.AdicionarAluno(pessoa);
// curso.AdicionarAluno(pessoa1);
// curso.ListarAlunos();


// pessoa.Idade = 30;
// pessoa.Apresentar();
