using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClass
{
    public class FindLengthString_class
    {
        public int FindLengthString(string mystring)
        {
            int char_count = 0;
            foreach (var item in mystring)
            {
                char_count++;
            }
            return char_count;
        }
    }
}
