using Busco.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Busco.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
