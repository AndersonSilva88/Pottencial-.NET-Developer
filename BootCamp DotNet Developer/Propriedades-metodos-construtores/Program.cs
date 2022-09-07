using Propriedades_metodos_construtores.Models;
using System.Globalization;

new ExemploExcecao().Metodo1();


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
