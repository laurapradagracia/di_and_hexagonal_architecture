using ShopingCart.API.Orders;

namespace ShopingCart.API.Billing
{
    public interface IBillingService
    {
        BillStatment GetBillinStatement(Order order);
    }
}