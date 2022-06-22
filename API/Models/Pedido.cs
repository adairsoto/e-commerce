using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public decimal Subtotal { get; set; }
        public string Status { get; set; }

        public Usuario? Usuarios { get; set; }
        public string UsuarioId { get; set; }
        public EnderecoEntrega? EnderecoEntregas { get; set; }
        public string EnderecoEntregaId { get; set; }
        public MetodoEntrega? MetodoEntrega  { get; set; }
        public int MetodoEntregaId { get; set; }
    }
}