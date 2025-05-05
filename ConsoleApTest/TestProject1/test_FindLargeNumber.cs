using TestClass;

namespace TestProject1;

public class test_FindLargeNumber
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var cl = new FindLargNumber_class();
        var result = cl.FindLargeNumber([1, 2, 3, 4, 5, 6]);

        int expected_output = 6;
        Assert.AreEqual(expected_output, result);
    }

    [Test]
    public void Test2()
    {
        var cl = new FindLargNumber_class();
        var result = cl.FindLargeNumber([4,9,2,5,1,7,6]);

        int expected_output = 9;
        Assert.AreEqual(expected_output, result);
    }

    [Test]
    public void Test3()
    {
        var cl = new FindLargNumber_class();
        var result = cl.FindLargeNumber([4, -2,6,-4,0,-10,9]);

        int expected_output = 9;
        Assert.AreEqual(expected_output, result);
    }

    [Test]
    public void Test4()
    {
        var cl = new FindLargNumber_class();
        var result = cl.FindLargeNumber([-4, -9, -2, -5, -1, -7, -6]);

        int expected_output = -1;
        Assert.AreEqual(expected_output, result);
    }
}
