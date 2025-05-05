using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClass
{
    class AddMatrix_class
    {
        public int[,] AddMatrix(int[,] arr1, int[,] arr2)
        {

            int rows = arr1.GetLength(0);
            int columns = arr1.GetLength(1);


            int[,] newMatrix = new int[rows, columns];


            string newMatrixstr = "";
            for (int i = 0; i < rows; i++)
            {

                for (int j = 0; j < columns; j++)
                {
                    //Console.WriteLine($"{arr1[i, j]},{arr2[i, j]} = {arr1[i, j] + arr2[i, j]}");
                    int value = arr1[i, j] + arr2[i, j];
                    newMatrix[i, j] = value;
                    newMatrixstr += value + " ";


                }
            }
                    ;


            return newMatrix;
        }
    }
}
