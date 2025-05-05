using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClass
{
    public class SumOfDifNumbers_class
    {
        public string SumOfDifNumbers(int a, int b)
        {

            int sumOfnumbers = a + b;
            int differenceOnumbers = a - b;

            return ($"{sumOfnumbers} {differenceOnumbers}");
        }
    }
}
