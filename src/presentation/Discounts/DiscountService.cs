using ShopingCart.API.Products;

namespace ShopingCart.API.Discounts
{
    public class DiscountService : IDiscountService
    {
        public DiscountResponse FigureDiscount(IEnumerable<Product> products)
        {
            var discount = new Discount(products.ToList());
            if(!discount.IsAny)
            {
                return new NoDiscountResponse { Products = discount.BillableProducts };
            }
            if(discount.Factor==Discount.HALF_OF_FACTOR)
            {
                var discountResponse = new HalfOffDiscountResponse { Products = discount.BillableProducts };
                discountResponse.SetDiscount(discount.Factor);
                return discountResponse;
            }
            return null;
        }
    }
}
