using Microsoft.EntityFrameworkCore;
using SeuNamespace.Models;

namespace SeuNamespace.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        // alem disso, da pra adicionar mais bagulho foda sobre o produto e papapa
    }
}