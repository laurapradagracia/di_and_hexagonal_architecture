using Microsoft.AspNetCore.Mvc;
using ShopingCart.API.Products;

namespace ShopingCart.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public IEnumerable<Product> Get() =>
            _productService.GetAll();
    }


}
