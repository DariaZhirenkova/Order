using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    public class MyMethods //: Order
    {
        /*  public static void GetOrder(OrderClass[] array)
          {
              for (int i = 0; i < array.Length; i++)
              {
                  Console.WriteLine("{0} Order: {1} {2} {3} {4}", i + 1, array[i].nameOfGoods, array[i].price,array[i].telephoneNumber, array[i].adress);
              }
          }*/
        public static void Print(List<Order> orderL)
        {
            foreach (var order in orderL)
            {
                Console.WriteLine(order);
            }
        }
        public static void GetPhoneNumberStarsWith(List<Order> orderList)
        {
            foreach (Order order in orderList)
            {
                string tel = order.GetInfoTelNumber();
                if (tel.StartsWith("375"))
                {
                    Console.WriteLine("\nНомер телефона начинается с 375:\n" + order.GetInfo());

                }

            }
        }

        public static void GetNameStartsWith(List<Order> orderList)
        {
            foreach (Order order in orderList)
            {
                if (order.Price <= 20 && order.NameOfGoods.StartsWith("Whys"))
                {
                    Console.WriteLine("\nИмя продукта начинется на Whys и цена менее 20$:\n" + order.GetInfo());
                }
            }
        }
    }
}
    


