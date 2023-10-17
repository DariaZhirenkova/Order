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
            Assert.AreEqual("Info: �������� ������: Pasta, ����� ��������: 8029644095519, ����: 10, ������: Brest, ������: 2%", orderList[0].ToString());
            Assert.AreEqual("Info: �������� ������: Whyski, ����� ��������: 8029644095519, ����: 11, ������: Brest, �������: pres2", orderList[1].ToString());
            Assert.AreEqual("Info: �������� ������: Burger, ����� ��������: 3759154035666, ����: 123, ������: Brest, �������: pres", orderList[2].ToString());
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
            Assert.AreEqual("Info: �������� ������: Burger, ����� ��������: 3759154035666, ����: 123, ������: Minsk, �������: pres", orderList[0].ToString());
            Assert.AreEqual("Info: �������� ������: Pasta, ����� ��������: 8029644095519, ����: 10, ������: Grodno, ������: 2%", orderList[1].ToString());
            Assert.AreEqual("Info: �������� ������: Whyski, ����� ��������: 8029644095519, ����: 11, ������: Brest, �������: pres2", orderList[2].ToString());

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

            Assert.AreEqual("Info: �������� ������: Whyski, ����� ��������: 8029644095519, ����: 11, ������: Brest, �������: pres2", orderList[0].ToString());
            Assert.AreEqual("Info: �������� ������: Pasta, ����� ��������: 8029644095519, ����: 10, ������: Grodno, ������: 2%", orderList[1].ToString());
            Assert.AreEqual("Info: �������� ������: Burger, ����� ��������: 3759154035666, ����: 123, ������: Minsk, �������: pres", orderList[2].ToString());

        }
    }
}