using TestClass;

namespace TestProject1;

public class test_AreEqualMatrix
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        int[,] matrix_a = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

        int[,] matrix_b = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

        var cl = new AreEqualMatrix_class();

        var result = cl.AreMatricesEqual(matrix_a, matrix_b);

        Assert.IsTrue(result);  // Matrices are equal
    }
    [Test]
    public void Test2()
    {
        int[,] matrix_a = {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };

        int[,] matrix_b = {
                { 1, 2, 3 },
                { 4, 5, 7 }
            };

        var cl = new AreEqualMatrix_class();

        var result = cl.AreMatricesEqual(matrix_a, matrix_b);
        Assert.IsFalse(result);  // Matrices are not equal due to different elements
    }

    [Test]
    public void Test3()
    {
        int[,] matrix_a = {
                { 1, 2 },
                { 3, 4 }
            };

        int[,] matrix_b = {
                { 1, 2 },
                { 3, 4 }
            };

        var cl = new AreEqualMatrix_class();

        var result = cl.AreMatricesEqual(matrix_a, matrix_b);
        Assert.IsTrue(result);  // Matrices are equal
    }

    [Test]
    public void Test4()
    {
        int[,] matrix_a = {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };

        int[,] matrix_b = {
                { 1, 2 },
                { 3, 4 }
            };

        var cl = new AreEqualMatrix_class();

        var result = cl.AreMatricesEqual(matrix_a, matrix_b);
        Assert.IsFalse(result);  // Matrices are not equal due to different dimensions
    }
}
