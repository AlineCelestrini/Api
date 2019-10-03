using TesteApi.Models;
using System.Collections.Generic;


namespace ApiWeb_Teste.Repositorio
{
    public interface IProdutoRepository
    {
        void Add(TodoProduto user);
        IEnumerable<TodoProduto> GetAll();
        TodoProduto Find(long id);
        void Remove(long id);
        void Update(TodoProduto user);
    }
}
