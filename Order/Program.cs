/*Task 7
1. Для всех свойств в классах заказа ввести проверку валидности значений в set части, в случае невалидности введенного значения выбрасывать исключения 
2. Написать юнит тесты для всех сущностей, включая DeliveryService
*/
using Order1.MyOrders;
using Order1.MyOrders.DeliversALL;

namespace Order1
{
    internal class Program
    {     

        static void Main(string[] args)
        {
            DeliveryService aliexpress = new DeliveryService("AliExpress");
            try
            {
                aliexpress.AddOrder(new VIPOrder("Iphone", 3759154036666L, 899, "Minsk", "pres"));
                aliexpress.AddOrder(new DiscountOrder("Pasta", 8029644095519L, 10f, "Brest", 2));
                aliexpress.AddOrder(new DiscountOrder("TV", 1119546374885L, 234, "Ainsk", 5));
                aliexpress.AddOrder(new DiscountOrder("Cake", 4529644095519L, 500, "Vrest", 2));
                aliexpress.AddOrder(new VIPOrder("Whyski", 8029644095519L, 11f, "Brest", "pres2"));
                aliexpress.AddOrder(new VIPOrder("Burger", 3759154035666L, 10.23f, "Minsk", "pres"));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

           aliexpress.OrderProduct(new VIPOrder("Burger", 3759154035666L, 10.23f, "Minsk", "pres"));
           aliexpress.OrderProduct(new VIPOrder("Whyski", 8029644095519L, 11f, "Brest", "pres2"));
            //aliexpress.RemoveOrder(new VIPOrder("Whyski", 8029644095519L, 11f, "Brest", "pres2"));

            /* List<Order> orderList = new List<Order>(){ new VIPOrder("Burger", 3759154035666L, 10.23f, "Minsk","pres"),
                                   new VIPOrder("Whyski", 8029644095519L, 11f, "Brest","pres2"),
                                   new DiscountOrder("Pasta", 8029644095519L, 10f, "Brest",2),
                                   new DiscountOrder("TV",1119546374885L,234,"Ainsk",5),
                                   new VIPOrder("Soap", 8029644095519L, 123, "Brest","pres2"),
                                   new DiscountOrder("Cake", 4529644095519L, 500, "Vrest",2),
                                   new DiscountOrder("TV",7829544374885L,2,"Yvnsk",5),
                                   new DiscountOrder("Cake", 4529644095519L, 500, "Vrest",2),
                                   new DiscountOrder("Cake", 4521644095519L, 523, "Vrest",2),
                                   new DiscountOrder("Cake", 4521644095519L, 523, "Vrest",2),
                                   new DiscountOrder("TV",7829544374885L,2,"Yvnsk",5)
            };
            */

            /*    MyMethods.Print(orderList);

             int max = 0;

              for(int i = 0; i < orderList.Count; i++)
              {
                    int count = 0;
                    for(int j = 1; j<orderList.Count; j++)
                    {
                       // if (orderList[i] == orderList[j])
                       // if (orderList[i].NameOfGoods == orderList[j].NameOfGoods && orderList[i].TelephoneNumber== orderList[j].TelephoneNumber && orderList[i].Price == orderList[j].Price && orderList[i].Adress== orderList[j].Adress)
                        if(orderList[i].NameOfGoods == orderList[j].NameOfGoods)
                        {
                            count++;
                        }
                        if (count > max)
                        {
                            max = count;
                        }

                    }
                }

                var groupList = orderList.GroupBy(x => x.NameOfGoods).Where(x => x.Count() == max).Select(x => x.Key);

                Console.WriteLine("\nНаиболее повторяющееся название товара:\n");


                foreach (var item in groupList)
                    {
                       Console.WriteLine(item);
                    }


                var newList = orderList.Where(x => x.Price <= 100).OrderBy(x => x.NameOfGoods).Select(x => x.NameOfGoods);
                Console.WriteLine("\nФильтрование по цене менее 100 $ + сортировка по имени LINQ:\n");

                foreach (var item in newList)
                {
                    Console.WriteLine(item);
                }

                var listPrice = orderList.OrderBy(x => x.Price);

                Console.WriteLine("\nСортировка по цене LINQ:\n");
                MyMethods.Print(listPrice.ToList());

                var listName = orderList.OrderBy(x => x.NameOfGoods);

                Console.WriteLine("\nСортировка по названию LINQ:\n");
                MyMethods.Print(listName.ToList());

                var listAdress = orderList.OrderBy(x => x.Adress);

                Console.WriteLine("\nСортировка по адресу LINQ:\n");
                MyMethods.Print(listAdress.ToList());
                /*
                SortPrice sortPrice = new SortPrice();
                SortName sortName = new SortName();
                SortAdress sortAdress = new SortAdress();


                orderList.Sort(sortAdress);
                Console.WriteLine("\nList after sort:");

                MyMethods.Print(orderList);
                 */

            // MyMethods.GetPhoneNumberStarsWith(orderList);
            // MyMethods.GetNameStartsWith(orderList);

            Console.WriteLine();
              
        }
    }
}