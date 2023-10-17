
namespace Order1.MyOrders
{
    internal interface IDelivery
    {
        
        Order DeliverOrder(Order order); //
        int ExpectedDeliveryTime(Order order);// время в минутах доставка
    }
}
