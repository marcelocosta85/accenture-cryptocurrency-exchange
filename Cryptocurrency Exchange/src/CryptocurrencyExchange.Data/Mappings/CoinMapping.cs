using CryptocurrencyExchange.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CryptocurrencyExchange.Data.Mappings
{
    public class CoinMapping : IEntityTypeConfiguration<Coin>
    {
        public void Configure(EntityTypeBuilder<Coin> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Symbol)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(p => p.Name)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(p => p.Nameid)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(p => p.Rank)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(p => p.PriceUsd)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(p => p.PercentChange24h)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(p => p.PercentChange1h)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(p => p.PercentChange7d)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(p => p.MarketCapUsd)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(p => p.Volume24)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(p => p.Volume24Native)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(p => p.Csupply)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(p => p.PriceBtc)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(p => p.Tsupply)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(p => p.Msupply)
                .IsRequired()
                .HasColumnType("varchar(100)");
        }
    }
}
