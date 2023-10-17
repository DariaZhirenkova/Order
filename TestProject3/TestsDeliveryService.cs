using Order1;
using Order1.MyOrders;
using Order1.MyOrders.DeliversALL;

namespace TestProject3
{
    [TestClass]
    public class TestsDeliveryService
    {
        [TestMethod]
        public void TestMethod1()
        {
            DeliveryService aliexpress = new DeliveryService("AliExpress");
           
            Assert.AreEqual(true, aliexpress.AddOrder(new VIPOrder("Iphone", 3759154036666L, 899, "Minsk","")));

        }

        [TestMethod]
        public void TestMethod()
        {

            List<Order> _orders = new List<Order>();
            DeliveryService aliexpress = new DeliveryService("AliExpress");
            aliexpress.AddOrder(new VIPOrder("Iphone", 3759154036666L, 899, "Minsk", ""));
            aliexpress.AddOrder(new VIPOrder("I", 3759154036666L, 899, "Minsk", ""));

            aliexpress.RemoveOrder(new VIPOrder("I", 3759154036666L, 899, "Minsk", ""));


            Assert.AreEqual(1,_orders.Count);
        }


        [TestMethod]
        public void TestMethod2()
        {
           // DeliveryService aliexpress = new DeliveryService("AliExpress");
            List<Order> _orders = new List<Order>();

            _orders.Add(new VIPOrder("Iphone", 3759154036666L, 899, "Minsk", ""));
            _orders.Add(new VIPOrder("I", 3759154036666L, 10, "Minsk", ""));

            CarDiliverMan car = new CarDiliverMan(_orders);
            car.DeliverOrder(new VIPOrder("Iphone", 3759154036666L, 899, "Minsk", ""));


            Assert.AreEqual(1,_orders.Count);



        }


    }
}