using Moq;
using ShopingCart.API.Billing;
using ShopingCart.API.Discounts;
using ShopingCart.API.Orders;
using ShopingCart.API.Products;
using System.Collections.Generic;
using Xunit;

namespace ShoppingCart.Test.AcceptanceTests
{
    public class BillingServiceShould
    {
        private readonly BillingService _billingService;
        private readonly Product SNEAKERS = new Product { Id = 1, Name = "Sneakers", Price = 8.5f };
        private readonly Mock<IProductRepository> _productRespository = new Mock<IProductRepository>();

        public BillingServiceShould()
        {
            _billingService = new BillingService(
                new ProductService(_productRespository.Object),
                new DiscountService());
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void Have_No_Discount_For_Orders_Of_2_Or_Less_Items(int productAmount)
        {
            Order order = BuildOrder(productAmount);
            var bill = _billingService.GetBillinStatement(order);
            Assert.Equal(Discount.None, bill.Discount);
        }

        private Order BuildOrder(int productAmount)
        {
            return new Order
            {
                Items = new List<OrderItem>
                {
                    new OrderItem
                    {
                        Product = SNEAKERS,
                        Amount = productAmount
                    }
                }
            };
        }
    }
}
