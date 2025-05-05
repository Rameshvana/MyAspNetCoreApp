using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClass
{
    public class FindLargNumber_class
    {
        public int FindLargeNumber(int[] arr)
        {

            int maxValue = arr[0];

            for (int i = 1; i < arr.Length; i++)

            {
                if (arr[i] > maxValue)
                {
                    maxValue = arr[i];
                }
            }

            return maxValue;
        }
    }
}
