using ShopingCart.API.Products;

namespace ShopingCart.API.Orders;

public class OrderItem
{
    public int Amount { get; set; }
    public Product Product { get; set; }
}
