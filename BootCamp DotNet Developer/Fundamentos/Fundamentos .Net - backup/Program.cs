using Fundamentos_.Net.Models;

int n = int.Parse(Console.ReadLine());
int p = 1;
int s =  0;

while (n > 0)
{
    int l = n % 10;

    p *= l;
    s += l;
}

Console.WriteLine(p-s);



//Menu
// string opcao = "";
// bool exibiMenu = true;

// while (exibiMenu)
// {
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção: ");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch (opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de cliente");
//             break;
//         case "2":
//             Console.WriteLine("Buscar cliente");
//             break;
//         case "3":
//             Console.WriteLine("Apagar cliente");
//             break;
//         case "4":
//             Console.WriteLine("Encerrar"); 
//             exibiMenu = false;
//             break;           
//         default:
//             Console.WriteLine("Opção inválida");
//             break;
//     }
// }

// Console.WriteLine("Finalizando programa!! ");


// int soma = 0;
// int numero = 0;

// do
// {
//     Console.WriteLine("Digite um número: (0 para parar)");
//     numero = Convert.ToInt32(Console.ReadLine());
//     soma += numero;

// } while (numero != 0);

// Console.WriteLine($"Total da soma dos números digitados é: {soma}");



// int numero = 5;
// int contador = 0;

// while (contador <= 10)
// {
//     Console.WriteLine($"{numero} X {contador} = {numero * contador}");
//     contador++;
// }


// int numero = 5;

// //Console.WriteLine($"{numero} x 1 = {numero * 1}");

// for (int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }


// Calculadora calculadora = new Calculadora();

// calculadora.Somar(10,20);
// calculadora.Subtrair(20,10);
// calculadora.Multiplicacao(10,20);
// calculadora.Divisao(20,2);
// calculadora.Potencia(3,3);
// calculadora.Seno(30);
// calculadora.Coseno(30);
// calculadora.Tangente(30);

// int numero = 10;

// Console.WriteLine(numero);

// Console.WriteLine("Incrementando o 10");
// //numero = numero + 1;
// numero++;

// Console.WriteLine(numero);

// calculadora.RaizQuadrada(9);

// bool choveu = true;
// bool estaTarde = true;

// if (!choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar");
// }
// else
// {
//     Console.WriteLine("Vou pedalar um outro dia");
// }



// bool possuiPresencaMinima = true;
// double media = 7.5;

// if (possuiPresencaMinima && media >= 7 )
// {
//     Console.WriteLine("Aprovado!");
// }
// else
// {
//     Console.WriteLine("Reprovado!");
// }

// bool maiorDeIdade = true;
// bool possuiAutorizacao = false;

// if (maiorDeIdade || possuiAutorizacao)
// {
//     Console.WriteLine("Entrada Liberada! ");
// }
// else
// {
//     Console.WriteLine("Entrada não liberada. ");
// }

// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("è uma vogal!!");
//         break;

//     default:
//         Console.WriteLine("Não é uma vogal");
//         break;    
// }




// int quantidadeEstoque = 10;
// int quantidadeCompra = 0;
// bool possivelVenda =  quantidadeCompra > 0 && quantidadeEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"é possivel realizar a venda? {possivelVenda}");

// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("venda invalida");
// }
// else if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada. ");
// }
// else
// {
//     Console.WriteLine("Desculpe, não temos a quantidade a venda, furo de estoque!!");
// }


// int a = 5;
// double b = a;

// double soma = 4 / (2+2);

// Console.WriteLine(soma);
// Console.WriteLine(b);



// int inteiro = 5;
// string a = inteiro.ToString();
// Console.WriteLine(a);

//int a = Convert.ToInt32("5");
//int a = int.Parse("5");

// int a = Convert.ToInt32(null);
// int b = int.Parse(null);

// Console.WriteLine(a);
// Console.WriteLine(b);


// int a = 10;
// int b = 20;
// int c = a + b;

// c += 5;

// Console.WriteLine(c);


// string apresentacao = "Olá seja bem vindo";
// int quantidade = 1;
// double altura = 1.80;
// decimal preco = 12.20M;
// bool condicao = true;

// DateTime dataAtual = DateTime.Now.AddDays(15);
// Console.WriteLine(dataAtual);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variável quantidade: " + quantidade);
// Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
// Console.WriteLine("Valor da variável preco: " + preco);
// Console.WriteLine("Valor da variável condicão: " + condicao);

// Pessoa pessoa = new Pessoa();

// pessoa.Nome = "Anderson";
// pessoa.Idade = 30;
// pessoa.Apresentar();

// int x = 10;

// for (int i = 1; i <= x; i++)
// {
//     Console.WriteLine(i);
// }
