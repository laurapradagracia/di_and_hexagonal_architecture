using System.Collections.Generic;
using Moq;
using ShopingCart.API.Products;
using Xunit;

namespace ShoppingCart.Test;

public class ProductServiceShould
{
    private readonly IProductService _productService;
    private readonly Mock<IProductRepository> _productRepository;
    public ProductServiceShould()
    {
        _productRepository = new Mock<IProductRepository>();
        _productService = new ProductService(_productRepository.Object);
    }
    [Fact]
    public void Find_All_Product()
    {
        var product = new Product { Id = 1, Name = "Tomate", Price = 20f };
        //setup Mock
        _productRepository.Setup(x => x.GetAll())
            .Returns(new List<Product> { new Product { Id = 1, Name = "Tomate", Price = 20f } });
        bool found = _productService.AreAllValid(new List<Product> { product });
        Assert.True(found);
    }
    [Fact]
    public void Find_Missing_Product()
    {
        var products = new List<Product> { new Product { Id = 1, Name = "Tomate", Price = 20f }, new Product { Id = 2, Name = "Pera", Price = 15f } } ;
        //setup Mock
        _productRepository.Setup(x => x.GetAll())
            .Returns(new List<Product> { new Product { Id = 1, Name = "Tomate", Price = 20f } });
        
        bool found = _productService.AreAllValid(products);
        Assert.False(found);
    }
}