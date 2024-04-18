using Microsoft.EntityFrameworkCore;
using WebUsinagem.Models;

namespace WebUsinagem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public  ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Registro> Registros { get; set; }
    }
}
