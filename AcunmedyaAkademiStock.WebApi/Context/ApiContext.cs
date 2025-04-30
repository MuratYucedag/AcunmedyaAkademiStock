using AcunmedyaAkademiStock.WebApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace AcunmedyaAkademiStock.WebApi.Context
{
    public class ApiContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-R7AR1ND;initial catalog=AcunmedyaApiDb;integrated Security=true");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
//trust server certificate=true;