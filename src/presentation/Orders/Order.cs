namespace ShopingCart.API.Orders
{
    public class Order
    {
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
    }
}
