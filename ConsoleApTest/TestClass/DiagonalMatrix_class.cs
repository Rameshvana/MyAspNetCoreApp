using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClass
{
    public class DiagonalMatrix_class
    {
        public List<int> DiagonalMatricx(int[,] arr)
        {


            int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
           };

            List<int> diagonal = new List<int>();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine(arr[i, i]);
                diagonal.Add(arr[i, i]);
            }

            return diagonal;

            //($"diogonal elements is: {String.Join(" ", diagonal)}");



        }
    }
}
