using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class LeituraArquivo
    {
        public (bool Sucesso, string[] Linhas, int QtndLinhas) LerArquivo(string caminho)
        {
            try
            {
                string[] linhas = System.IO.File.ReadAllLines(caminho);
                return (true, linhas, linhas.Count());
            }
            catch (System.Exception)
            {
                
                return (false, new string[0], 0);
            }

        }
    }
}