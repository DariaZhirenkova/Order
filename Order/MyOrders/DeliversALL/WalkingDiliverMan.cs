
namespace Order1.MyOrders.DeliversALL
{
    internal class WalkingDiliverMan :  IDelivery
    {
        List<Order> _orders;

        public WalkingDiliverMan(List<Order> orders)
        {
            _orders = orders;
        }

        public int id = 1;

        public Order DeliverOrder(Order order)
        {
            Order resultOrder = _orders.Where(x => Equals(x,order)).FirstOrDefault();

            if (resultOrder != null)
            {
                _orders.Remove(resultOrder);


                Console.WriteLine("Ваш заказ будет доставлен пешим доставщиком!!!");
                return resultOrder;
            }

            return null;

        }

        public int ExpectedDeliveryTime(Order order)
        {
            return 60;
        }
    }
}
