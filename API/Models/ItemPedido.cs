using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class ItemPedido
    {
        public int Id { get; set; }
        public decimal Preco { get; set; }
        public int quantidade { get; set; }

        public Produto? Produtos { get; set; }
        public string ProdutoId { get; set; }
        public Pedido? Pedidos { get; set; }
        public string PedidoId { get; set; }
    }
}