/*Task 5

1.Создать список(System.Generic.List) из объектов класса Order +
2. Реализовать в классе Order интерфейс IComparable для сортироваке по умолчанию (по телефону заказчика)+
3.Создать отдельные классы сортировщики заказов по имени, стоимости, адресу доставки, отсортировать список по этим параметрам
и вывести на экран (метод Sort())+
4.Провести сортировку списка по критериям из п.3 с использованием LINQ (метод OrderBy)+
5.С использованием LINQ вывести на экран названия всех товаров из заказов, цена которых не превышает 100$, 
отсортированный по имени товара (методы Where, Select, OrderBy)+
6 *.Вывести на экран название товара, наиболее часто встречающееся в списке заказов+
*/


using Order.Compare;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;


namespace Order
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
           List<Order> orderList = new List<Order>(){ new VIPOrder("Burger", 3759154035666L, 10.23f, "Minsk","pres"),
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

          
            MyMethods.Print(orderList);

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