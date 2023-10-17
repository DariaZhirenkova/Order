
namespace Order1
{
    public class VIPOrder : Order
    {
        public string _present;
        public string Present
        {
            get
            {
                return _present;

            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Without present????");
                }
                else
                {
                    _present = value;
                }
            }
        }

        public VIPOrder(string nameOfGoods1, long telephoneNumber1, float price1, string adress1, string present):base(nameOfGoods1, telephoneNumber1, price1, adress1)
        {
            Present = present;
        }

        public override string GetInfo()
        {
            return $"Info: название товара: {NameOfGoods}, номер телефона: {TelephoneNumber}, цена: {Price}, адресс: {Adress}, подарок: {Present}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is VIPOrder)
            {
                var compareOrder = obj as VIPOrder;
                return compareOrder.NameOfGoods == NameOfGoods && compareOrder.Price == Price && compareOrder.TelephoneNumber == TelephoneNumber && compareOrder.Adress == Adress && compareOrder.Present == Present;
            }
            return false;
        }
    }
}
