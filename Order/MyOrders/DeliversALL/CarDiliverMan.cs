using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order1.MyOrders.DeliversALL
{
    public class CarDiliverMan : IDelivery
    {
        List<Order> _orders;

        public CarDiliverMan(List<Order> orders)
        {
            _orders = orders;
        }

       // public int id =3;

        public Order DeliverOrder(Order order)
        {
            Order resultOrder = _orders.Where(x => Equals(x,order)).FirstOrDefault();

            if (resultOrder != null)
            {
                _orders.Remove(resultOrder);

                Console.WriteLine("Ваш заказ будет доставлен водителем!!!");

                return resultOrder;

            }
           return null;
        }

        public int ExpectedDeliveryTime(Order order)
        {
            return 30;
        }
    }
}
