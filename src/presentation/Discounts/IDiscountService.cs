using ShopingCart.API.Products;

namespace ShopingCart.API.Discounts
{
    public interface IDiscountService
    {
        DiscountResponse FigureDiscount(IEnumerable<Product> products);
    }
}