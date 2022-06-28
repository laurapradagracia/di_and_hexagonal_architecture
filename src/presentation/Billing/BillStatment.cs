using ShopingCart.API.Discounts;
using ShopingCart.API.Orders;

namespace ShopingCart.API.Billing
{
    public class BillStatment
    {
        public Order Order { get; set; }
        public Discount Discount { get; set; }
    }
}
