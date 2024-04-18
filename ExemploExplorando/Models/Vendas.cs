using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExemploExplorando.Models
{
    public class Vendas
    {
        public Vendas(int id, string produto, decimal preco )
        {
            Id = id;
            Produto = produto;
            Preco = preco;
            DataVenda = DateTime.Now;
        }
        public Vendas(int id, string produto, decimal preco, DateTime dataVenda)
        {
            Id = id;
            Produto = produto;
            Preco = preco;
            DataVenda = dataVenda;
        }

        public Vendas()
        {

        }


        public int Id { get; set; }
        [JsonProperty("Nome_produto")]
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set;} 
    }
}