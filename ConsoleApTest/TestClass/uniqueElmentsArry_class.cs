using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClass
{
    public class uniqueElmentsArry_class
    {
        public HashSet<int> UniqueElementsArry(int[] arr)
        {
           
            Console.WriteLine(arr.GetType());
            HashSet<int> uniqueEle = new HashSet<int>(arr);

            return uniqueEle;

            //return String.Join(" ", uniqueEle);
        }
    }
}
