using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public static class array
    {
        public static int FindSum(List<int> list)
        {
            int total = 0;

            foreach (int i in list)
            {
                total += i;
            }

            return total;
        }
    }
}
