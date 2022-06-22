using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutosController : ControllerBase
    {
        [HttpGet]
        public string ListarProdutos()
        {
            return "Lista de Produtos";
        }
        [HttpGet("{id}")]
        public string PegarProdutoId(int id)
        {
            return "Produto por Id";
        }
    }
}