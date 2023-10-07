using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Compare
{
    internal class SortAdress : IComparer<Order>
    {
        public int Compare(Order? x, Order? y)
        {
            return x.Adress.CompareTo(y.Adress);
        }
    }
}
