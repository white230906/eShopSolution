using eShopSolution.Data.Enums;

namespace eShopSolution.Data.Entities;

public class Order
{
    
    public int Id { set; get; }
    public DateTime OrderDate { set; get; }
    public Guid UserId { set; get; }
    public string ShipName { set; get; }
    public string ShipAddress { set; get; }
    public string ShipEmail { set; get; }
    public string ShipPhoneNumber { set; get; }
    public OrderStatus OrderStatus { set; get; }
    
    public ICollection<OrderDetail> OrderDetails { set; get; } = new  List<OrderDetail>();
}