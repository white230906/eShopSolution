namespace eShopSolution.Data.Entities;

public class AppUser
{
    public int Id  { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime Dob { get; set; }
    public ICollection<Cart> Carts { get; set; } = new List<Cart>();
    public ICollection<Order> Orders { get; set; } = new List<Order>();
    public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}