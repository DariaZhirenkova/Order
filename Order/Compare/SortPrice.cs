using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Compare
{
    internal class SortPrice : IComparer<Order>
    {
      
        public int Compare(Order? x, Order? y)
        {
            if (x.Price < y.Price)
            {
                return -1;
            }
            else if (x.Price > y.Price)
            {
                return 1;
            }
            return 0;
        }


    }
}
