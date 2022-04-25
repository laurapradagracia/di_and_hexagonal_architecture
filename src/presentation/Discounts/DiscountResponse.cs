using ShopingCart.API.Products;

namespace ShopingCart.API.Discounts
{
    public abstract class DiscountResponse
    {
        public List<Product> Products { get; set; }
        public float TotalDiscount { get; protected set; }
    }
}
