using TestClass;

namespace TestProject1;

public class test_DiagonalMatrix
{
    [SetUp]
    public void Setup()
    {
        var cl = new DiagonalMatrix_class();
    }

    [Test]
    public void Test1()
    {
        var cl = new DiagonalMatrix_class();
        int[,] arr1 = { { 1, 2, 3, 1 }, { 3, 4, 5, 6 }, { 3, 4, 5, 8 } };

        List<int> expectedResult = new List<int> { 1, 4, 5 };

        var result = cl.DiagonalMatricx(arr1);

        Assert.AreEqual(expectedResult, expectedResult);

        Assert.Pass();
    }
    [Test]
    public void Test2()
    {
        int[,] arr2 = { { 7 } };
        var cl = new DiagonalMatrix_class();

        List<int> expectedResult = new List<int> { 7 };
        var result = cl.DiagonalMatricx(arr2);
        Assert.AreEqual(expectedResult, result);
    }

    [Test]
    public void Test3()
    {
        int[,] arr3 = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };

        var cl = new DiagonalMatrix_class();
        List<int> expectedResult = new List<int> { 0, 0, 0 };

        var result = cl.DiagonalMatricx(arr3);
        Assert.AreEqual(expectedResult, result);
    }

    [Test]
    public void Test4()
    {
        int[,] arr4 = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };
        var cl = new DiagonalMatrix_class();

        List<int> expectedResult = new List<int> { 1, 6 };

        var result = cl.DiagonalMatricx(arr4);

        Assert.AreEqual(expectedResult, result);
    }
}
