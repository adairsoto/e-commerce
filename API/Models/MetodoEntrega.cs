using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class MetodoEntrega
    {
        public int Id { get; set; }
        public string EntregaNome { get; set; }
        public string EntregaTempo { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
    }
}