
namespace Order1.Compare
{
    public class SortPrice : IComparer<Order>
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
