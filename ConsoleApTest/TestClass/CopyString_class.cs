using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClass
{
    public class CopyString_class
    {
        public string CopyString(string str)
        {
            string Copy_string = "";

            foreach (var item in str)
            {
                Copy_string += item;
            }
            return Copy_string;
        }
    }
}
