using ShopingCart.API.Products;

namespace ShopingCart.API.Discounts
{
    public class Discount
    {
        public const float HALF_OF_FACTOR = 0.5f;
        private readonly List<Product> _products;
        public List<Product> Products { get; set; }
        public List<Product> ComplementaryProducts { get; set; }
        public bool IsAny { get; }
        public float Factor { get; set; }

        public Discount(List<Product> products)
        {
            _products = products;
            IsAny = products.Count > 2;
            Factor = products.Count > 11 
                ? HALF_OF_FACTOR
                : 0f;
        }
    }
}