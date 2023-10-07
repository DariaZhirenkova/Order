using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Compare
{
    internal class SortName : IComparer<Order>
    {
        public int Compare(Order? x, Order? y)
        {
            if (x.NameOfGoods[0] < y.NameOfGoods[0])
            {
                return -1;
            }

            else if (x.NameOfGoods[0] > y.NameOfGoods[0])
            {
                return 1;
            }
            return 0;
          //  return x.NameOfGoods.CompareTo(y.NameOfGoods);
        }

    }
}
