using System.Collections.Generic;

namespace UserComparer
{
    public class IntComparator : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            int result = x.CompareTo(y);
            if(x % 2 != 0)
            {
                if(y % 2 == 0)
                result = y.CompareTo(x);
            }
            if (x % 2 == 0)
            {
                if(y % 2 != 0)
                result = x.CompareTo(y);
            }
            return result;
        }
    }

}
