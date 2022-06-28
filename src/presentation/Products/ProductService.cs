namespace ShopingCart.API.Products;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public bool AreAllValid(IEnumerable<Product> products)
    {
        var existingProducts = _productRepository.GetAll();
        return products.All(x => existingProducts.Contains(x));
    }
        

    public IEnumerable<Product> GetAll() =>
        _productRepository.GetAll();
}
