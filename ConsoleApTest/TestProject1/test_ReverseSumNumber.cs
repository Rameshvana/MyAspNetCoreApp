using TestClass;

namespace TestProject1;

public class test_ReverseSumNumber
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var cl = new ReverseSumNumber_class();
        var result = cl.ReverseSumNumber(456);

        var expected_output = "51";

        Assert.AreEqual(expected_output, result);
    }

    [Test]
    public void Test2()
    {
        var cl = new ReverseSumNumber_class();
        var result = cl.ReverseSumNumber(72954);

        var expected_output = "72";

        Assert.AreEqual(expected_output, result);
    }
}
