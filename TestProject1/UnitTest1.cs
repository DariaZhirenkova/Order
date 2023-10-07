using Order;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TelephoneNumberCheckPossitive()
        {
            Order.Order order = new Order.Order("we",2345512388456,45,"ff");
            Assert.AreEqual(2345512388456, order.TelephoneNumber);
        }

        [TestMethod]
        public void TelephoneNumberCheckNegative()
        {
            Order.Order order = new Order.Order("we", 23455123886, 45, "ff");
            Assert.AreEqual(0, order.TelephoneNumber);
        }

        [TestMethod]
        public void CheckTelephoneNumberNegative()
        {
            Order.Order order = new Order.Order("we", 2345512388456, 45, "ff");
            order.TelephoneNumber = 343434;
            Assert.AreEqual(2345512388456, order.TelephoneNumber);
        }

        [TestMethod]
        public void CheckTelephoneNumberPossitive()
        {
            Order.Order order = new Order.Order("we", 2345512388456, 45, "ff");
            order.TelephoneNumber = 1234567891234;
            Assert.AreEqual(1234567891234, order.TelephoneNumber);
        }

        [TestMethod]
        public void PriceCheckPossitive()
        {
            Order.Order order = new Order.Order("we", 2345512388456, 45, "ff");
            Assert.AreEqual(45, order.Price);
        }

        [TestMethod]
        public void PriceCheckNegative()
        {
            Order.Order order = new Order.Order("ee",232323,-6,"ww");
            Assert.AreEqual(0, order.Price);
        }

        [TestMethod]
        public void CheckPricePossitive()
        {
            Order.Order order = new Order.Order("ee", 232323, 6, "ww");
            order.Price = 45;
            Assert.AreEqual(45, order.Price);

        }

        [TestMethod]
        public void CheckPriceNegative()
        {
            Order.Order order = new Order.Order("ee", 232323, 6, "ww");
            order.Price = -45;
            Assert.AreEqual(6, order.Price);

        }
    }
}