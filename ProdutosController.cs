using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiWeb_Teste.Repositorio;
using Microsoft.AspNetCore.Mvc;
using TesteApi.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TesteApi.Controllers
{
    [Route("api/[Controller]")]
    public class ProdutosController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutosController(IProdutoRepository produtoRepo)
        {
            _produtoRepository = produtoRepo;
        }

        [HttpGet]
        public IEnumerable<TodoProduto> GetAll()
        {
        return _produtoRepository.GetAll();
        }
        [HttpGet("{id}", Name = "GetProduto")]
        public IActionResult GetById(long id)
        {
            var produto = _produtoRepository.Find(id);
            if (produto == null)
                return NotFound();
            return new ObjectResult(produto);
        }

    // GET: /<controller>/
    public IActionResult Index()
        {
            return View();
        }
    }
}
