using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClass
{
    public class CompareStrings_class
    {
        public bool ComapteStrings(string str1, string str2)
        {
            bool result = false;

            if(str1.Length == str2.Length)
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    if (str1[i] != str2[i])
                    {
                        break;
                        result = false;
                    }
                }
                result= true;
            }
            else
            {
                result = false;
            }

            return result;
        }
    }
}
