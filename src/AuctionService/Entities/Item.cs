using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionService.Entities;

[Table("Items")] // set teh table name to items 
public class Item{
    public Guid Id {get; set;}
    public string Make {get; set;}
    public string Model {get; set;}

    public int Year {get; set;}

    public string Color {get; set;}

    public int Milage {get; set;}

    public string ImageUrl {get; set;}

    // nav property we can do it by configuration but were dong it by convention 
    // define a 1 to 1 relation

    public Auction Auction {get; set;}
    public Guid AuctionId {get; set;}
    
}