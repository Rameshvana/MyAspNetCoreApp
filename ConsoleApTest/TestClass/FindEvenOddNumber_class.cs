using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClass
{
    public class FindEvenOddNumber_class
    {
        public String findEventOddNumber(int num)
        {
            string result;
            if (num % 2 == 0)
            {
                result = "Even";
            }
            else
            {
                result = "Odd";
            }
            return result;
        }
    }
}
