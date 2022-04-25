using ShopingCart.API.Products;

namespace ShopingCart.API.Discounts
{
    public class DiscountService
    {
        public Discount FigureDiscount(IEnumerable<Product> products)
        {
            var discount = new Discount(products.ToList());
            return discount;
        }
    }
}
