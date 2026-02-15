namespace eShopSolution.Data.Entities;

public class Cart
{
    public int Id { set; get; }
    public int Quantity { set; get; }
    public decimal Price { set; get; }
    
    public int ProductId { set; get; }
    public Product Product { get; set; }
    public int UserId  { set; get; }
    public AppUser  AppUser { get; set; }
}