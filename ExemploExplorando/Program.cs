// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Reflection.Metadata;
using ExemploExplorando.Models;
using Newtonsoft.Json;






string conteudoArquivo = File.ReadAllText("Arquivos/venda.json");


List<Vendas> vendas = JsonConvert.DeserializeObject<List<Vendas>>(conteudoArquivo);

foreach (var venda in vendas)
{
    Console.WriteLine($"Id: {venda.Id}");
    Console.WriteLine($"Produto: {venda.Produto}");
    Console.WriteLine($"Preço: {venda.Preco}");
    Console.WriteLine($"Data da Venda: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
    Console.WriteLine();
}

























// List<Vendas> listaVendas = new List<Vendas>();  


// Vendas v1 = new Vendas(1,"Material de escritorio",25.00M);
// Vendas v2 = new Vendas(2,"Material de limpeza",50.00M);

// listaVendas.Add(v1);
// listaVendas.Add(v2);


// string serializado = JsonConvert.SerializeObject(listaVendas,Formatting.Indented);

// File.WriteAllText("Arquivos/venda.json",serializado);

// Console.WriteLine(serializado);




















// int numero = 10;

// //if ternário
// bool ehPar = numero % 2 == 0;
// Console.WriteLine($"O numero {numero} é {(ehPar ? "par" : "ímpar")}");

// if(numero % 2 == 0)
// {
//     Console.WriteLine($"O número {numero} é par");
// }
// else
// {
//     Console.WriteLine($"O número {numero} é ímpar");
// }





// Pessoa p1 = new Pessoa(nome: "João",sobrenome: "Aragão");

// ( string nome, string sobrenome) = p1;


// Console.WriteLine($"{nome} {sobrenome}");











// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");


// if(sucesso)
// {
    
//     foreach (var linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Erro ao ler o arquivo");
// }






// //Maneiras de criar uma tupla
// (int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "João", "Aragão", 1.8m);
// ValueTuple<int, string, string, decimal> tupla2 = (2, "Eduardo", "Neves", 1.7m);
// var tupla3 = (3, "Maria", "Silva", 1.6m);

// Console.WriteLine($"Id: {tupla.Id}");
// Console.WriteLine($"Nome: {tupla.Nome}");
// Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
// Console.WriteLine($"Altura: {tupla.Altura}");


// Console.WriteLine($"Id: {tupla2.Item1}");
// Console.WriteLine($"Nome: {tupla2.Item2}");
// Console.WriteLine($"Sobrenome: {tupla2.Item3}");
// Console.WriteLine($"Altura: {tupla2.Item4}");

// Console.WriteLine($"Id: {tupla3.Item1}");
// Console.WriteLine($"Nome: {tupla3.Item2}");
// Console.WriteLine($"Sobrenome: {tupla3.Item3}");
// Console.WriteLine($"Altura: {tupla3.Item4}");




























// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "São Paulo");
// estados.Add("RJ", "Rio de Janeiro");
// estados.Add("MG", "Minas Gerais");



// Console.WriteLine(estados["SP"]);


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


