
namespace Order
{
    public class VIPOrder : Order
    {
        public string Present { get; set; }

        public VIPOrder(string nameOfGoods1, long telephoneNumber1, float price1, string adress1, string present):base(nameOfGoods1, telephoneNumber1, price1, adress1)
        {
            Present = present;
        }

        public override string GetInfo()
        {
            return $"Info: название товара: {NameOfGoods}, номер телефона: {TelephoneNumber}, цена: {Price}, адресс: {Adress}, подарок: {Present}";
        }
    }
}
