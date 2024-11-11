using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionService.Entities;

[Table("Items")] // set teh table name to items 
public class Item{
    public Guid Id {get; set;}
    public string Make {get; set;}
    public string Model {get; set;}

    public int Year {get; set;}

    public string Color {get; set;}

    public int Mileage {get; set;}

    public string ImageUrl {get; set;}

    // nav property we can do it by configuration but were dong it by convention 
    // define a 1 to 1 relation

    public Auction Auction {get; set;}
    // Auction has     public Item Item { get; set;}  to set up 1v1 relationship
    public Guid AuctionId {get; set;} //foreign key references ID in Auction class
    
}