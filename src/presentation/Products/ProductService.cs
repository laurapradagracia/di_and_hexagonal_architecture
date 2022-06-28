namespace ShopingCart.API.Products
{
    public class ProductService
    {
        private readonly ProductRepository _productRepository;

        public ProductService(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Product> GetAll() =>
            _productRepository.GetAll();
    }
}
