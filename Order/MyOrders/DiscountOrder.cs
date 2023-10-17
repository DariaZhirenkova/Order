namespace Order1
{
    public class DiscountOrder : Order
    {
        private float _sale;
        public float Sale 
        { get
            {
                return _sale;
            } set 
            { 
                if (value < 0)
                {
                    throw new ArgumentException("SALE!!!!");
                }
                else
                {
                    _sale = value;
                }
            } 
        }

        public DiscountOrder(string nameOfGoods1, long telephoneNumber1, float price1, string adress1,float sale): base(nameOfGoods1,telephoneNumber1, price1, adress1)
        {
            Sale = sale;
        }

        public override string GetInfo()
        {
            return $"Info: название товара: {NameOfGoods}, номер телефона: {TelephoneNumber}, цена: {Price}, адресс: {Adress}, скидка: {Sale}%";
        }

        public override bool Equals(object? obj)
        {
            if(obj is DiscountOrder)
            {
                var compareOrder = obj as DiscountOrder;
                return compareOrder.NameOfGoods == NameOfGoods && compareOrder.Price == Price && compareOrder.TelephoneNumber == TelephoneNumber && compareOrder.Adress == Adress && compareOrder.Sale == Sale;
            }
            return false;
        }
    }
}
