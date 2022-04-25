namespace ShopingCart.API.Discounts
{
    public class HalfOffDiscountResponse:DiscountResponse
    {
        public void SetDiscount(float factor)
        {
            TotalDiscount = Products.Select(x => x.Price * factor).Sum();
        }
    }
}
