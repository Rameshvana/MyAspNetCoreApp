using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClass
{
    public class ReverseString_class
    {
        public string ReverseString(string mystring)
        {
            string ReverseString = "";

            for (int i = mystring.Length - 1; i >= 0; i--)
            {
                ReverseString += mystring[i];
            }
            return ReverseString;
        }
    }
}
