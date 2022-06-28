namespace ShopingCart.API.Products
{
    public class ProductRepository : IProductRepository
    {
        private readonly Product[] _products = new Product[]
        {
            new Product { Id = 1 , Name = "Bananas", Price = 1.5f},
            new Product { Id = 2 , Name = "Peanuts", Price = 3.5f},
            new Product { Id = 3 , Name = "Pineapples", Price = 7.5f},
            new Product { Id = 4 , Name = "Mango", Price = 6.5f},
            new Product { Id = 5 , Name = "Ognions", Price = 0.5f},
            new Product { Id = 6 , Name = "Mushrooms", Price = 9.5f}
        };

        public IEnumerable<Product> GetAll() =>
            _products;
    }
}
