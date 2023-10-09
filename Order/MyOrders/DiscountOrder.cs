namespace Order
{
    public class DiscountOrder : Order
    {
        public float Sale { get; set; }

        public DiscountOrder(string nameOfGoods1, long telephoneNumber1, float price1, string adress1,float sale): base(nameOfGoods1,telephoneNumber1, price1, adress1)
        {
            Sale = sale;
        }

        public override string GetInfo()
        {
            return $"Info: название товара: {NameOfGoods}, номер телефона: {TelephoneNumber}, цена: {Price}, адресс: {Adress}, скидка: {Sale}";
        }
    }
}
