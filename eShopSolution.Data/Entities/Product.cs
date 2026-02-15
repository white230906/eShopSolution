namespace eShopSolution.Data.Entities;

public class Product
{
    public int Id { get; set; }
    public decimal Price { get; set; }
    public decimal OriginalPrice { get; set; }
    public int  Stock { get; set; }
    public int  ViewCount { get; set; }
    public DateTime DateCreated { get; set; }

    public ICollection<ProductInCategory> ProductInCategories { get; set; } = new List<ProductInCategory>();
    public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    public ICollection<Cart> Carts { get; set; } = new List<Cart>();
    public ICollection<ProductTranslation> ProductTranslations { get; set; } = new List<ProductTranslation>();
    //public ICollection<ProductImage> ProductImages { get; set; } = new List<ProductImage>();
}