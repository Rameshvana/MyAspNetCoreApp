using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClass
{
    public class AreEqualMatrix_class
    {
        public bool AreMatricesEqual(int[,] matrix_a, int[,] matrix_b)
        {
            // Get dimensions of matrices
            int rows = matrix_a.GetLength(0);
            int cols = matrix_a.GetLength(1);

            // Check if dimensions are equal
            bool checkRows = matrix_a.GetLength(0) == matrix_b.GetLength(0);
            bool checkCols = matrix_a.GetLength(1) == matrix_b.GetLength(1);

            // If dimensions don't match, matrices can't be equal
            if (!checkRows || !checkCols)
            {
                return false;
            }

            // Check if each element in the matrices is equal
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix_a[i, j] != matrix_b[i, j])
                    {
                        return false;
                    }
                }
            }

            // If no differences found, matrices are equal
            return true;
        }
    }
}
