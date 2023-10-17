using Order1;

namespace TestsVIP
{
    [TestClass]
    public class VipOrderTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PriceCheckNeggative()
        {
            VIPOrder vip = new VIPOrder("Iphone", 3759154036666L, -9, "Minsk", "pres");
        }


        [TestMethod]
        public void PriceCheckPossitive()
        {
            VIPOrder vip = new VIPOrder("Iphone", 3759154036666L, 23, "Minsk", "pres");

            Assert.AreEqual(23, vip.Price);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NameCheckNeggative()
        {
            VIPOrder vip = new VIPOrder(null, 3759154036666L, 9, "Minsk", "pres");
        }


        [TestMethod]
        public void NameCheckPossitive()
        {
            VIPOrder vip = new VIPOrder("Iphone", 3759154036666L, 23, "Minsk", "pres");
            string res = vip.NameOfGoods;
            Assert.AreEqual("Iphone", res);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TelephoneCheckNeggative()
        {
            VIPOrder vip = new VIPOrder("Iphone", 375915455036666L, 9, "Minsk", "pres");
        }


        [TestMethod]
        public void TelephoneCheckPossitive()
        {
            VIPOrder vip = new VIPOrder("Iphone", 3759154036666L, 23, "Minsk", "pres");

            Assert.AreEqual(3759154036666L, vip.TelephoneNumber);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AdressCheckNeggative()
        {
            VIPOrder vip = new VIPOrder("Iphone", 3759154036666L, 89, null, "pres");
        }


        [TestMethod]
        public void AdressCheckPossitive()
        {
            VIPOrder vip = new VIPOrder("Iphone", 3759154036666L, 23, "Minsk", "pres");
            //Assert.IsTrue("Minsk" == vip.Adress);
            Assert.AreEqual("Minsk", vip.Adress);

        }

        public void PresentAdressCheckNeggative()
        {
            VIPOrder vip = new VIPOrder("Iphone", 3759154036666L, 89, "Minsk", null);
        }


        [TestMethod]
        public void PresentCheckPossitive()
        {
            VIPOrder vip = new VIPOrder("Iphone", 3759154036666L, 23, "Minsk", "pres");
            //Assert.IsTrue("Minsk" == vip.Adress);
            Assert.AreEqual("pres", vip.Present);
        }



            [TestMethod]
        public void OrderCheckPossitive()
        {
            VIPOrder vip = new VIPOrder("Iphone", 3759154036666L, 23, "Minsk", "pres");
            VIPOrder vip2 = new VIPOrder("Iphone", 3759154036666L, 23, "Minsk", "pres");
            Assert.IsTrue(vip.Equals(vip2));
        }


        [TestMethod]
        [DataRow ("Iphone", 3759154036666L, 3, "Minsk", "pres")]
        [DataRow("Iphone", 3759154036666L, 23, "Minsk1", "pres")]
        [DataRow("Iphone", 3759154011366L, 23, "Minsk", "pres")]
        [DataRow("Iphone1", 3759154036666L, 23, "Minsk", "pres")]
        [DataRow("Iphone", 3759154036666L, 23, "Minsk", "pres1")]
        public void OrderCheckNeggative(string name, long tel, float price, string city, string present)
        {
            VIPOrder vip = new VIPOrder("Iphone", 3759154036666L, 23, "Minsk", "pres");
            VIPOrder vip2 = new VIPOrder(name,tel,price,city,present);
            Assert.IsFalse(vip.Equals(vip2));
        }

        [TestMethod]
        public void OrderCheckPossitiveGetInfo()
        {
            VIPOrder vip = new VIPOrder("Iphone", 3759154036666L, 23, "Minsk", "pres");
            Assert.AreEqual("Info: название товара: Iphone, номер телефона: 3759154036666, цена: 23, адресс: Minsk, подарок: pres",vip.GetInfo());
        }

    

    }
}