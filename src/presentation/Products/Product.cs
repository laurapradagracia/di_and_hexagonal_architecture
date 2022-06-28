namespace ShopingCart.API.Products
{
    public record Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
    }
}
