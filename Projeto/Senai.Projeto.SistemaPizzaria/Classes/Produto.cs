using System;
namespace Projeto.Pizzaria.Classes {
    public class Produto {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public float Preco { get; set; }
        public string Categoria { get; set; }
        public DateTime Data { get; set; }
    }
}