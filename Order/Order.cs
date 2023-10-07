using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    public abstract class Order : IComparable<Order>
    {
        public string NameOfGoods { get; set;}// свойства(Property), геттеры сеттеры 

        private long _telephoneNumber;
        public long TelephoneNumber {
            get
            {
                return _telephoneNumber;
            }
            set 
            {
                string str = value.ToString();
                if (str.Length == 13)
                {
                    _telephoneNumber = value;
                }

            }
        }
        private float _price;
        public float Price {
            get
            {
                return _price;
            }
            set
            {
                if (value > 0f && value <= 1000f)
                {
                    _price = value;
                }
            }
        }
        public string Adress { get; set; }

        public Order(string nameOfGoods1, long telephoneNumber1, float price1, string adress1)// конструктор, никогда ничего не возвращает
        {
            NameOfGoods = nameOfGoods1;
            TelephoneNumber = telephoneNumber1;
            Price = price1;
            Adress = adress1;
        }
        /* public static void GetOrder(OrderClass[] array)
         {
             for (int i = 0; i < array.Length; i++)
             {
                 Console.WriteLine("{0} Order: {1} {2} {3} {4}", i + 1, array[i].nameOfGoods, array[i].price, array[i].telephoneNumber, array[i].adress);
             }
         }
        */
        public abstract string GetInfo();
        

        public override string ToString()
        {
            return GetInfo();
        }
         
        public string GetInfoTelNumber()
        {
            return _telephoneNumber.ToString();
        }

        public int CompareTo(Order? other)
        {
            if (TelephoneNumber < other.TelephoneNumber)
            {
                return -1;
            }
            else if (TelephoneNumber > other.TelephoneNumber)
            {
                return 1;
            }
            return 0;
        }
    }
}
