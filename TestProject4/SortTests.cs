using Order1;
using Order1.Compare;
namespace SortTests
{
    [TestClass]
    public class SortTests
    {
        [TestMethod]
        public void TestSortPrice()
        {
            SortPrice sortPrice = new SortPrice();

            List<Order> orderList = new List<Order>(){ new VIPOrder("Burger", 3759154035666L, 123f, "Brest","pres"),
                                    new VIPOrder("Whyski", 8029644095519L, 11f, "Brest","pres2"),
                                    new DiscountOrder("Pasta", 8029644095519L, 10f, "Brest",2)                           
            };

            orderList.Sort(sortPrice);
            Assert.AreEqual(orderList.Count, 3);
            Assert.AreEqual("Info: название товара: Pasta, номер телефона: 8029644095519, цена: 10, адресс: Brest, скидка: 2%", orderList[0].ToString());
            Assert.AreEqual("Info: название товара: Whyski, номер телефона: 8029644095519, цена: 11, адресс: Brest, подарок: pres2", orderList[1].ToString());
            Assert.AreEqual("Info: название товара: Burger, номер телефона: 3759154035666, цена: 123, адресс: Brest, подарок: pres", orderList[2].ToString());
        }
        [TestMethod]
        public void TestSortName()
        {
            SortName sortName = new SortName();

            List<Order> orderList = new List<Order>(){ new VIPOrder("Burger", 3759154035666L, 123f, "Minsk","pres"),
                                    new VIPOrder("Whyski", 8029644095519L, 11f, "Brest","pres2"),
                                    new DiscountOrder("Pasta", 8029644095519L, 10f, "Grodno",2)
            };

            orderList.Sort(sortName);

            Assert.AreEqual(orderList.Count, 3);
            Assert.AreEqual("Info: название товара: Burger, номер телефона: 3759154035666, цена: 123, адресс: Minsk, подарок: pres", orderList[0].ToString());
            Assert.AreEqual("Info: название товара: Pasta, номер телефона: 8029644095519, цена: 10, адресс: Grodno, скидка: 2%", orderList[1].ToString());
            Assert.AreEqual("Info: название товара: Whyski, номер телефона: 8029644095519, цена: 11, адресс: Brest, подарок: pres2", orderList[2].ToString());

        }
        [TestMethod]
        public void TestSortAdress()
        {
            SortAdress sortAdress = new SortAdress();

            List<Order> orderList = new List<Order>(){ new VIPOrder("Burger", 3759154035666L, 123f, "Minsk","pres"),
                                    new VIPOrder("Whyski", 8029644095519L, 11f, "Brest","pres2"),
                                    new DiscountOrder("Pasta", 8029644095519L, 10f, "Grodno",2)
            };

            orderList.Sort(sortAdress);
            Assert.AreEqual(orderList.Count, 3);

            Assert.AreEqual("Info: название товара: Whyski, номер телефона: 8029644095519, цена: 11, адресс: Brest, подарок: pres2", orderList[0].ToString());
            Assert.AreEqual("Info: название товара: Pasta, номер телефона: 8029644095519, цена: 10, адресс: Grodno, скидка: 2%", orderList[1].ToString());
            Assert.AreEqual("Info: название товара: Burger, номер телефона: 3759154035666, цена: 123, адресс: Minsk, подарок: pres", orderList[2].ToString());

        }
    }
}