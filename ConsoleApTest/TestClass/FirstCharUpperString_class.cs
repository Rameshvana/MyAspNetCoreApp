using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClass
{
    public class FirstCharUpperString_class

    {
        public string FirstCharUpperString(string str)
        {

            string[] words = Array.ConvertAll(str.Split(' '), Convert.ToString);

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                {
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
                }
            }

            
            return string.Join(" ", words);


        }
    }
}
