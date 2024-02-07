using Microsoft.EntityFrameworkCore;
using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Repositories;

public class RocketseatAuctionDbContext : DbContext
{
    public DbSet<Auction> Auctions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var rootDirectory = Environment.CurrentDirectory;
        var dataDirectory = Path.GetFullPath(Path.Combine(rootDirectory, "Data"));
        var dbFilePath = Path.Combine(dataDirectory, "leilaoDbNLW.db");

        optionsBuilder.UseSqlite($"Data Source={dbFilePath}");
    }
}
