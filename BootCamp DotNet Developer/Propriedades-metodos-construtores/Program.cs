using Propriedades_metodos_construtores.Models;

Pessoa pessoa = new Pessoa(nome: "Anderson", sobrenome: "Silva");
Pessoa pessoa1 = new Pessoa(nome: "Cleberson", sobrenome: "Neves");

Curso curso = new Curso();

curso.Nome = "Programação";
curso.Alunos = new List<Pessoa>();

curso.AdicionarAluno(pessoa);
curso.AdicionarAluno(pessoa1);
curso.ListarAlunos();


// pessoa.Idade = 30;
// pessoa.Apresentar();
