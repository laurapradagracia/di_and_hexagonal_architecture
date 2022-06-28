namespace ShopingCart.API.Discounts
{
    public class Discount
    {
        public static Discount None { get; } = new Discount{ Type = nameof(None), Total=0m };
        public string Type { get; set; }
        public decimal Total { get; set; }
    }
}
