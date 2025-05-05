using TestClass;

namespace TestProject1;

public class test_secondDiagonalMatrix
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var cl = new SecondDiagonalMatrix_class();

        int[,] matrix1 = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
        var result = cl.SecondDiagonalMatrix(matrix1);

        var expected_output = new List<int> { 3,5,7};

        Assert.AreEqual(result,expected_output);
    }

    [Test]
    public void Test2()
    {
        int[,] matrix = {
                { 1, 2 },
                { 3, 4 }
            };
        var cl = new SecondDiagonalMatrix_class();

        var result = cl.SecondDiagonalMatrix(matrix);
        var expected = new List<int> { 2, 3 };
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test3()
    {
        int[,] matrix = {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 },
                { 13, 14, 15, 16 }
            };
        var cl = new SecondDiagonalMatrix_class();

        var result = cl.SecondDiagonalMatrix(matrix);
        var expected = new List<int> { 4, 7, 10, 13 };
        Assert.AreEqual(expected, result);
    }
}
