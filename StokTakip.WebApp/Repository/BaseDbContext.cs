using Microsoft.EntityFrameworkCore;
using StokTakip.WebApp.Models;

namespace StokTakip.WebApp.Repository
{
    public class BaseDbContext : DbContext

    {
         public BaseDbContext(DbContextOptions apt) : base(apt)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=Stok_Takip_Db; Trusted_Connection=true"); ;
        }

        public DbSet<Product> Products { get; set; }

    }
}
