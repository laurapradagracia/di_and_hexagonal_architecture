using ShopingCart.API.Orders;

namespace ShopingCart.API.Discounts
{
    public interface IDiscountService
    {
        Discount DiscountFrom(Order order);
    }
}