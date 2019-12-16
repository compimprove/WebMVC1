using Microsoft.EntityFrameworkCore;
using WebMVC1.Models;

namespace WebMVC1.Data
{
    public class SqlServerDbContext : DbContext
    {
        public SqlServerDbContext(DbContextOptions<SqlServerDbContext> options)
           : base(options)
        {
        }
        public DbSet<Product> Product { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<Movie> Movie { get; set; }
    }
}
