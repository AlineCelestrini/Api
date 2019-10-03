using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteApi.Models
{
    public class ProdutoDBContext
    {
        public ProdutoDBContext(DbContextOptions<ProdutoDBContext> options)
            : base(options)
        { }
            public DbSet<TodoProduto> Produtos { get; set; }
        }
    }

