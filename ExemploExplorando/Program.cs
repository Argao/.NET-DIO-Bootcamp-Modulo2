// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Reflection.Metadata;
using ExemploExplorando.Models;


Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("RJ", "Rio de Janeiro");
estados.Add("MG", "Minas Gerais");



Console.WriteLine(estados["SP"]);


// foreach (var estado in estados)
// {
//     Console.WriteLine($"Chave: {estado.Key}, Valor: {estado.Value}");
// }


// estados.Remove("MG");
// estados["SP"] = "São Paulo - valor alterado";





// foreach (var estado in estados)
// {
//     Console.WriteLine($"Chave: {estado.Key}, Valor: {estado.Value}");
// }
// string chave = "RJ2";

// Console.WriteLine($"Verificando elemento: {chave}");

// if(estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existente: {chave}");
// }
// else
// {
//     Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
// }



// Stack<int> pilha = new Stack<int>();

// pilha.Push(2);
// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }




// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");
// pilha.Push(20);
// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }

















// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }


// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }   






















// new ExemploExcecao().Metodo1();






















// try{
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }

// }
// catch (IOException e)
// {
//     Console.WriteLine("Erro ao ler o arquivo: " + e.Message);
// }


































// string dateString = "2022-04-17 18:00";

// bool isValid = DateTime.TryParseExact(dateString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date);

// if(isValid)
// {
//     Console.WriteLine(date);
// }
// else
// {
//     Console.WriteLine("Data inválida");
// }

// Console.WriteLine(date);






















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


