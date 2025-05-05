using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClass
{
    public class SecondDiagonalMatrix_class
    {
 


         public List<int> SecondDiagonalMatrix(int[,] arr)
        {
            int rows = arr.GetLength(0);   // Get the number of rows
            int cols = arr.GetLength(1);   // Get the number of columns
            List<int> diagonal = new List<int>();

            // Ensure that the matrix is square to have a second diagonal
            if (rows != cols)
            {
                throw new InvalidOperationException("Matrix must be square to have a second diagonal.");
            }

            for (int i = 0; i < rows; i++)
            {
                // Calculate the second diagonal element
                int value = arr[i, cols - 1 - i];
                diagonal.Add(value);
            }

            return diagonal;
        }
    }
}
