using ShopingCart.API.Products;

namespace ShopingCart.API.Discounts
{
    public class Discount
    {
        public const float HALF_OF_FACTOR = 0.5f;
        private readonly List<Product> _products;
        public List<Product> BillableProducts { get; set; }
        public List<Product> FreeOfChargeProducts { get; set; }
        public bool IsAny { get; }
        public float Factor { get; private set; }

        public Discount(List<Product> products)
        {
            _products = products;
            IsAny = products.Count > 2;
            ProcessProducts(products);
            
        }

        private void ProcessProducts(List<Product> products)
        {
            BillableProducts = CalculateBillable(products);
            Factor = products.Count > 11
                ? HALF_OF_FACTOR
                : 0f;
        }

        private List<Product> CalculateBillable(List<Product> products)
        {
            return products;
        }
    }
}