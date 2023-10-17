using Order1.MyOrders.DeliversALL;

namespace Order1.MyOrders
{
    public class DeliveryService
    {
        List<Order> _orders = new List<Order>();
        List<IDelivery> _delivers = new List<IDelivery>();
        public string Name { get; }

        public DeliveryService(string name) 
        {
            Name = name;
            _delivers.Add(new WalkingDiliverMan(_orders));
            _delivers.Add(new DronDeliver(_orders));
            _delivers.Add(new CarDiliverMan(_orders));
            _delivers.Add(new MotoDeliverMan(_orders));
        }

    
        public Order OrderProduct(Order order)
        {           
            var minTimeDeliver = _delivers.Where(x => x.ExpectedDeliveryTime(order) == _delivers.Min(x => x.ExpectedDeliveryTime(order)));
            return minTimeDeliver.First().DeliverOrder(order);
        }


        public bool AddOrder(Order order)
        {
            _orders.Add(order);
            return true;
           
        }

        public void RemoveOrder(Order order) 
        {
            _orders.Remove(order);
        }


    }
}
