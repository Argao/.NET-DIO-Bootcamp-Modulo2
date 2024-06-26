using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno){
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int qntd = Alunos.Count;
            return  qntd;
        }

        public bool RemoverAluno(Pessoa aluno){
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos(){
            Console.WriteLine($"Alunos do cirso de: {Nome}");

            for (int i = 0; i < Alunos.Count; i++)
            {
                
                // Console.WriteLine("Nº " + i + " - " + Alunos[i].NomeCompleto);
                Console.WriteLine($"Nº {i+1} - {Alunos[i].NomeCompleto}");
            }

            // foreach (Pessoa aluno in Alunos)
            // {
            //     Console.WriteLine(aluno.NomeCompleto);
            // }
        }
    }
}