using Propriedades_metodos_construtores.Models;
using System.Globalization;

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("PR", "Paraná");
estados.Add("SP", "São Paulo");
estados.Add("MG", "Minas Gerais");

foreach (KeyValuePair<string, string> item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
}
Console.WriteLine("**** Removendo ******");
estados.Remove("SP");

foreach (KeyValuePair<string, string> item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
}

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
