using ShopingCart.API.Products;
using Xunit;

namespace ShoppingCart.Test;

public class ProductServiceShould
{
    private readonly ProductService _productService;

    public ProductServiceShould()
    {
        _productService = new ProductService(new ProductRepository());
    }
    [Fact]
    public void Not_Come_Empty()
    {
        var products = _productService.GetAll();
        Assert.NotEmpty(products);
    }
}