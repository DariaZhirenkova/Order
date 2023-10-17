
namespace Order1.Compare
{
    public class SortAdress : IComparer<Order>
    {
        public int Compare(Order? x, Order? y)
        {
            return x.Adress.CompareTo(y.Adress);
        }
    }
}
