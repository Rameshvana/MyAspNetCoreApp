using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClass
{
    public class FindPrimeNumber_class
    {
        public string FindPrimeNumber(int x)
        {

            int numInput = x;

            int count = 0;
            string result = "";

            for (int i = 1; i <= numInput; i++)
            {

                if (numInput % i == 0)
                {
                    count++;
                }
            }


            if (count == 2)
            {
                result = "Prime";
            }
            else
            {
                result = "not Prime";
            }


            return result;

        }
    }
}
