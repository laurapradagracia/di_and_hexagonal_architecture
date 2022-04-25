using ShopingCart.API.Products;

namespace ShopingCart.API.Discounts
{
    public class NoDiscountResponse: DiscountResponse
    {
        public NoDiscountResponse()
        {
            TotalDiscount = 0f;
        }
    }
}
