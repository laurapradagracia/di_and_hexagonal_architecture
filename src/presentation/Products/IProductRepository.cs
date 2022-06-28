
namespace ShopingCart.API.Products;

public interface IProductRepository
{
    IEnumerable<Product> GetAll();
}
