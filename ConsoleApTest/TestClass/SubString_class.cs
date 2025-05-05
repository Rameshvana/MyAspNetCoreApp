using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClass
{
    public class SubString_class
    {
        public void FindSubString(string str, int start, int end)
        {
            string SubString = str.Substring(start,end);

            Console.WriteLine(SubString);

        }
    }
}
