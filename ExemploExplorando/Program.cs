// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Reflection.Metadata;
using ExemploExplorando.Models;

string dateString = "2022-04-17 18:00";

bool isValid = DateTime.TryParseExact(dateString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date);

if(isValid)
{
    Console.WriteLine(date);
}
else
{
    Console.WriteLine("Data inválida");
}

Console.WriteLine(date);






















// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 34382.40M;

// Console.WriteLine($"{valorMonetario:C}");
// Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
// Console.WriteLine(valorMonetario.ToString("N2"));

// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;

// Console.WriteLine(numero.ToString("##-##-##"));















// string n1 = "10";
// int n2 = 20;

// string resultado = n1 + n2;

// Console.WriteLine(resultado);

































// Pessoa p1 = new Pessoa(nome: "João",sobrenome: "Aragão");
// Pessoa p2 = new Pessoa(nome: "Eduardo",sobrenome: "Neves Queiroz");

// Curso cursoDeIngles = new Curso();

// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();


