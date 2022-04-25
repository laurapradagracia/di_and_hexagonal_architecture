using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopingCart.API.Discounts;
using ShopingCart.API.Products;

namespace ShopingCart.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DiscountsController : ControllerBase
    {
        private readonly IDiscountService _discountService;

        public DiscountsController(IDiscountService discountService)
        {
            _discountService = discountService;
        }

        [HttpPost]
        public DiscountResponse FigureDiscount(IEnumerable<Product> products)
        {
            return _discountService.FigureDiscount(products); ;
        }
    }
    
}
