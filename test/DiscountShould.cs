using ShopingCart.API.Discounts;
using ShopingCart.API.Products;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ShoppingCart.Test;

public class DiscountShould
{
    [Fact]
    public void Be_None_When_2_Or_Less_Products()
    {
        var products = new List<Product>
        {
            new Product{ Id = 1, Name = "Product 1", Price =1f },
            new Product{ Id = 2, Name = "Product 2", Price =2f }
        };
        var discount = new Discount(products);
        Assert.False(discount.IsAny);
    }
    [Theory]
    [InlineData(3)]
    [InlineData(6)]
    [InlineData(24)]
    public void Be_3_Or_Mode_Products(int max)
    {

        var products = Enumerable.Range(1,max)
            .Select(x=> new Product { Id=x, Name= "Product "+x, Price =1f }).ToList();
        var discount = new Discount(products);
        Assert.True(discount.IsAny);
    }
    [Fact]
    public void Be_Half_Off_When_11_Or_Mode_Products()
    {
        var products = new List<Product>
        {
            new Product{ Id = 1, Name = "Product 1", Price = 1f },
            new Product{ Id = 1, Name = "Product 1", Price = 1f },
            new Product{ Id = 1, Name = "Product 1", Price = 1f },
            new Product{ Id = 1, Name = "Product 1", Price = 1f },
            new Product{ Id = 2, Name = "Product 2", Price = 2f },
            new Product{ Id = 2, Name = "Product 2", Price = 2f },
            new Product{ Id = 2, Name = "Product 2", Price = 2f },
            new Product{ Id = 2, Name = "Product 2", Price = 2f },
            new Product{ Id = 3, Name = "Product 3", Price = 3f },
            new Product{ Id = 3, Name = "Product 3", Price = 3f },
            new Product{ Id = 3, Name = "Product 3", Price = 3f },
            new Product{ Id = 3, Name = "Product 3", Price = 3f },
        };
        var discount = new Discount(products);
        Assert.Equal(Discount.HALF_OF_FACTOR, discount.Factor);
    }
}