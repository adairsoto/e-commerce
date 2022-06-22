using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class EnderecoEntrega
    {
        public int Id { get; set; }
        public string logradouro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        
        public Usuario? Usuarios { get; set; }
        public int? UsuarioId { get; set; }
    }
}