using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClass
{
    public class ReversetheWords_class
    {
        public string Reversethewords(string str)
        {
            string[] s = Array.ConvertAll(str.Split(' '), Convert.ToString);

            var result = new List<string>();

            for (int i = s.Length - 1; i >= 0; i--)
            {
                //result += s[i] + " ";
                result.Add(s[i]);
            }

            return String.Join(" ",result);
        }
    }
}
