using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order1.MyOrders.DeliversALL
{
    internal class MotoDeliverMan : IDelivery
    {
        List<Order> _orders; 

        public MotoDeliverMan(List<Order> orders)
        {
            _orders = orders;
        }
        public Order DeliverOrder(Order order)
        {
            Order resultOrder = _orders.Where(x => Equals(x, order)).FirstOrDefault();

            if (resultOrder != null)
            {
                _orders.Remove(resultOrder);


                Console.WriteLine("Ваш заказ будет доставлен мотоциклистом!!!");
                return resultOrder;
            }

            return null;

        }


        public int ExpectedDeliveryTime(Order order)
        {
            return 45;
        }
    }
}
