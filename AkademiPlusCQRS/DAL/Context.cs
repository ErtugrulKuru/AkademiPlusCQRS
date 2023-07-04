using Microsoft.EntityFrameworkCore;

namespace AkademiPlusCQRS.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-JH4NS85;initial catalog=AkademiPlusCQRSDb;integrated security=true");
        }
        public DbSet<Product> Products { get; set; }
    }
}
