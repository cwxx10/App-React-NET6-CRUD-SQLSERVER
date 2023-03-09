using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using App_React_NET6_CRUD.Models;

namespace App_React_NET6_CRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly DbreactnetVendasContext _db;

        public ProdutosController(DbreactnetVendasContext db)
        {
            _db = db;
        }

        [HttpGet]
        [Route("GetProdutos")]
        public IActionResult GetProdutos() {
            List<Produto> lista = _db.Produtos.ToList();
            //return Ok();
            return StatusCode(StatusCodes.Status200OK, lista);
        }





    }
}
