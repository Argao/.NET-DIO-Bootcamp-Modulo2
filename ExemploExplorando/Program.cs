// See https://aka.ms/new-console-template for more information
using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome: "João",sobrenome: "Aragão");
Pessoa p2 = new Pessoa(nome: "Eduardo",sobrenome: "Neves Queiroz");

Curso cursoDeIngles = new Curso();

cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();


