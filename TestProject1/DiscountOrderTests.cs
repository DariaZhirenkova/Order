using Order1;


namespace DiscountTests
{
    [TestClass]
    public class DiscountOrderTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))] 
        public void SaleNeggativeCheck()
        {
            DiscountOrder dis = new DiscountOrder("Pasta", 8029644095519L, 10f, "Brest", -5);

        }

        [TestMethod]
        public void SalePossitiveCheck()
        {
            DiscountOrder dis = new DiscountOrder("Pasta", 8029644095519L, 10f, "Brest", 2);
            Assert.AreEqual(2, dis.Sale);

        }

        [TestMethod]
        public void DiscountGetInfoCheck() { 

        DiscountOrder dis = new DiscountOrder("Iphone", 3759154036666L, 23, "Minsk", 20);
        Assert.AreEqual("Info: название товара: Iphone, номер телефона: 3759154036666, цена: 23, адресс: Minsk, скидка: 20%",dis.GetInfo());
        }

        [TestMethod]
        public void SaleEqualsCheckNeggative()
        {
            DiscountOrder dis = new DiscountOrder("Iphone", 3759154036666L, 23, "Minsk", 20);
            DiscountOrder dis2 = new DiscountOrder("Iphone", 3759154036666L, 23, "Minsk", 2);
            Assert.IsFalse(dis.Equals(dis2));
        }

        public void SaleEqualsCheckPossitive()
        {
            DiscountOrder dis = new DiscountOrder("Iphone", 3759154036666L, 23, "Minsk", 20);
            DiscountOrder dis2 = new DiscountOrder("Iphone", 3759154036666L, 23, "Minsk", 20);
            Assert.IsTrue(dis.Equals(dis2));
        }
    }
}