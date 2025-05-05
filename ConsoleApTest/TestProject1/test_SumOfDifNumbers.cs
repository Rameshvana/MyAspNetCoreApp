using TestClass;

namespace TestProject1;

public class test_SumOfDifNumbers
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var cl = new SumOfDifNumbers_class();
        var result = cl.SumOfDifNumbers(20,30);

        var expected_result = "50 -10";
        Assert.AreEqual(expected_result, result);

    }
    [Test]
    public void Test2()
    {
        var cl = new SumOfDifNumbers_class();
        var result = cl.SumOfDifNumbers(50 ,10);

        var expected_result = "60 40";
        Assert.AreEqual(expected_result, result);

    }
}
