using System.Collections.Generic;
using System.Linq;
using TesteApi.Models;
using ApiWeb_Teste.Repositorio;

namespace TesteApi.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
 
    
        private readonly TodoContext _contexto;

        public ProdutoRepository(TodoContext ctx)
        {
            _contexto = ctx;
        }

        public void Add(TodoProduto produto)
        {
            _contexto.TodoProdutos.Add(produto);
            _contexto.SaveChanges();

       }
        public TodoProduto Find(long id)
        {
            return _contexto.TodoProdutos.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<TodoProduto> GetAll()
        {
            return _contexto.TodoProdutos.ToList();
        }

        public void Remove(long id)
        {
            var entity = _contexto.TodoProdutos.First(p => p.Id == id);
            _contexto.TodoProdutos.Remove(entity);
            _contexto.SaveChanges();
        }

        public void Update(TodoProduto produto)
        {
            _contexto.TodoProdutos.Update(produto);
            _contexto.SaveChanges();
        }
}
}
