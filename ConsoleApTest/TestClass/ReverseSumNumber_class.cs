using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClass
{
    public class ReverseSumNumber_class
    {
        public string ReverseSumNumber(int num)
        {
            int Sum = 0;
            foreach (char ch in num.ToString())
            {
                Sum += int.Parse(ch.ToString());
            }
            Console.WriteLine(Sum);

            string ReverseSum = "";
            foreach (var item in Sum.ToString())
            {

                ReverseSum = item + ReverseSum;
            }
            return ReverseSum;
        }
    }
}
