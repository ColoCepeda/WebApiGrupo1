using ApiGrupo1.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiGrupo1.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
    }
}
