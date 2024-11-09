using AuctionService.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuctionService.Data;

public class AuctionDbContext : DbContext{
    //constructor for AuctionDBContext with parameter of type DbContextOptions
    public AuctionDbContext(DbContextOptions options) : base(options) { 

    }
    //need to tell our db connection about the entity we have in our CRUD app project
    //DbSet tell context call the entity we have. It provides methods to interact with the database, allowing you to Add, Query, Update, and Delete data.
    public DbSet<Auction>Auctions {get; set;} // table names in DB are typically pluralised 
}

