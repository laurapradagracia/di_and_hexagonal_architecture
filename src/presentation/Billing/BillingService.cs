using ShopingCart.API.Discounts;
using ShopingCart.API.Orders;
using ShopingCart.API.Products;

namespace ShopingCart.API.Billing
{
    public class BillingService : IBillingService
    {
        private readonly IProductService _productService;
        private readonly IDiscountService _discountService;

        public BillingService(IProductService productService, IDiscountService discountService)
        {
            _productService = productService;
            _discountService = discountService;
        }
        public BillStatment GetBillinStatement(Order order)
        {
            if(!_productService.AreAllValid(order.Items.Select(x => x.Product)))
            {
                throw new ArgumentException("All products in order must be valid");
            }
            return new BillStatment
            {
                Discount = _discountService.DiscountFrom(order),
                Order = order
            };
        }
    }
}
