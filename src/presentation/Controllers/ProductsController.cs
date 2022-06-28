using Microsoft.AspNetCore.Mvc;
using ShopingCart.API.Products;

namespace ShopingCart.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ProductService _productService;

        public ProductsController(ProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public IEnumerable<Product> Get() =>
            _productService.GetAll();
    }


}
