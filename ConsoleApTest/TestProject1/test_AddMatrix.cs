using TestClass;

namespace TestProject1;

public class test_AddMatrix
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
   
        {
            var cl = new Class1();
            int[,] arr1 = { { 1, 2, 3 }, { 3, 4, 5 } };

            int[,] arr2 = { { 1, 2, 3 }, { 3, 4, 5 } };


            int[,] a = cl.AddMatrix(arr1, arr2);

            int[,] expected = { { 2, 4, 6 }, { 6, 8, 10 } };

            Assert.AreEqual(expected, a);

        }
    [Test]
    public void Test2()
    {
        var cl = new Class1();
        int[,] arr1 = { { 1, 2, 3,4 }, { 3, 4, 5,6 } };

        int[,] arr2 = { { 1, 2, 3,4 }, { 3, 4, 5,6 } };


        int[,] a = cl.AddMatrix(arr1, arr2);

        int[,] expected = { { 2, 4, 6,8 }, { 6, 8, 10,12 } };

        Assert.AreEqual(expected, a);

    }

    [Test]
    public void Test3()
    {
        var cl = new Class1();
        int[,] arr1 = { { 1, 2, 3, 4,5 }, { 3, 4, 5, 6 ,7} };

        int[,] arr2 = { { 1, 2, 3, 4,5 }, { 3, 4, 5, 6,7 } };


        int[,] a = cl.AddMatrix(arr1, arr2);

        int[,] expected = { { 2, 4, 6, 8 ,10}, { 6, 8, 10, 12 ,14} };

        Assert.AreEqual(expected, a);

    }

    [Test]
    public void Test4()
    {
        var cl = new Class1();
        int[,] arr1 = { { 1, 2 }, { 3, 4 } };

        int[,] arr2 = { { 1, 2 }, { 3, 4 } };


        int[,] a = cl.AddMatrix(arr1, arr2);

        int[,] expected = { { 2, 4 }, { 6, 8 } };

        Assert.AreEqual(expected, a);

    }

    [Test]
    public void Test5()
    {
        var cl = new Class1();
        int[,] arr1 = { { 1, -2, 3 }, { 3, 4, -5 } };

        int[,] arr2 = { { 1, 2, 3 }, { 3, -4, 5 } };


        int[,] a = cl.AddMatrix(arr1, arr2);

        int[,] expected = { { 2, 0, 6}, { 6, 0, 0 } };

        Assert.AreEqual(expected, a);

    }
}
