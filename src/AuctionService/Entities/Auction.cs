namespace AuctionService.Entities;

public class Auction {
    public Guid Id { get; set;} //primary key
    public int ReservePrice { get; set;} = 0;
    public string Seller {get; set;}

    public string Winner {get; set;}

    public int? soldAmount { get; set;}

    public int? CurrentHighBid { get; set;}
    public DateTime CreatedAt { get; set;} = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set;} = DateTime.UtcNow;

    public DateTime AuctionEnd { get; set;}

    public Status Status { get; set;}

    public Item Item { get; set;}
    //Item.cs has 
    //public Auction Auction {get; set;} (this is  "navigational property" to set 1v1 relationship )

    // public ICollection<Item> Items { get; set; } 
    // The Auction class has a navigation property ICollection<Item>, which indicates that 
    // one auction can have multiple items.
    // The Item class has a foreign key AuctionId to represent the many items being 
    // related to one auction.
}