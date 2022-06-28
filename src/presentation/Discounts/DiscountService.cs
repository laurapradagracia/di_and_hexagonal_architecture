using ShopingCart.API.Orders;

namespace ShopingCart.API.Discounts
{
    public class DiscountService : IDiscountService
    {
        public Discount DiscountFrom(Order order)
        {
            var nItems = order.Items.Select(x => x.Amount).Sum();
            if (IsNoDiscount(nItems))
            {
                return Discount.None;
            }
            throw new NotImplementedException();
        }
        private bool IsNoDiscount(int nItems) =>
            nItems <= 2;
    }
}
