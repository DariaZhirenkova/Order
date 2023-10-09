

namespace Order
{
    internal class OrdinaryOrder : Order
    {
        public OrdinaryOrder(string nameOfGoods1, long telephoneNumber1, float price1, string adress1) : base(nameOfGoods1, telephoneNumber1, price1, adress1) { }

        public override string GetInfo()
        {
            return $"Info: название товара: {NameOfGoods}, номер телефона: {TelephoneNumber}, цена: {Price}, адресс: {Adress}";
        }

    }
}
