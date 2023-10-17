namespace Order1
{
    public abstract class Order : IComparable<Order>
    {
        private string _name;
        public string NameOfGoods {
            get
            {
                return _name;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Your name is null");
                }
                else
                {
                    _name = value;
                }
            }
        }// свойства(Property), геттеры сеттеры 

        private long _telephoneNumber;
        public long TelephoneNumber {
            get
            {
                return _telephoneNumber;
            }
            set 
            {
                string str = value.ToString();
                if (str.Length != 13)
                {
                    throw new ArgumentException("Incorrect input telephine number");
                }
                else
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
                if (value <= 0)
                {
                    throw new ArgumentException("Wrong price!!!");
                }
                else
                {
                    _price = value;
                }
            }
        }
        private string _adress;
        public string Adress
        {
            get
            {
                return _adress;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Input adress");
                }
                else
                {
                    _adress = value;    
                }
            }
        }

        public Order(string nameOfGoods1, long telephoneNumber1, float price1, string adress1)
        {
        //}// конструктор, никогда ничего не возвращает
        
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
        
    
        public override bool Equals(object? obj)
        {
            
           if (obj is Order)
            {
                var compareOrder = obj as Order;
                return compareOrder.NameOfGoods == NameOfGoods && compareOrder.Price == Price && compareOrder.TelephoneNumber == TelephoneNumber && compareOrder.Adress == Adress;

            }

            return false;
          
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
