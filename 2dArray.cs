using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public static class _2dArray
    {
        public static int FindSum(List<List<int>> nestedlist)
        {
            int total = 0;

            foreach (List<int> list in nestedlist)
            {
                foreach (int i in list)
                {
                    total += i;
                }
            }

            return total;
        }
    }
}
