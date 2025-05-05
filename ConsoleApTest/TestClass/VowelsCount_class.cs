using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClass
{
    public class VowelsCount_class
    {
        public string VowelsCount(string str)
        {
            List<string> vowels = new List<string> { "a", "e", "i", "o", "u" };

            string str1 = str.ToLower();
            Console.WriteLine(str1);
            int vowels_count = 0, consonants_count = 0;

            foreach (var item in str1)
            {
                Console.WriteLine();
                if (vowels.Contains(item.ToString()))
                {
                    vowels_count++;
                }
                else
                {
                    consonants_count++;
                }
               
            }
            return $"{vowels_count} {consonants_count}";
        }
    }
}
