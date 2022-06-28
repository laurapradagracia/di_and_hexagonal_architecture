
namespace ShopingCart.API.Products;

public interface IProductService
{
    IEnumerable<Product> GetAll();
    bool AreAllValid(IEnumerable<Product> products);
}
