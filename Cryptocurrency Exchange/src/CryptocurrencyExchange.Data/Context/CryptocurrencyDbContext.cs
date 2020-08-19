using CryptocurrencyExchange.Business.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CryptocurrencyExchange.Data.Context
{
    public class CryptocurrencyDbContext : DbContext
    {
        public CryptocurrencyDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Coin> Coins { get; set; }
        public DbSet<Exchange> Exchanges { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetProperties()
                    .Where(p => p.ClrType == typeof(string))))
            {
                property.SetColumnType("varchar(100)");
            }
                      

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CryptocurrencyDbContext).Assembly);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);
        }
                
    }
}
