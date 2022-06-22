using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string Descricao { get; set; }
        public string ImgUrl { get; set; }
        public ProdutoMarca? ProdutosMarcas { get; set; }
        public int ProdutoMarcaId { get; set; }
        public ProdutoCategoria? ProdutosCategorias { get; set; }
        public int ProdutoCategoriaId { get; set; }

    }
}

