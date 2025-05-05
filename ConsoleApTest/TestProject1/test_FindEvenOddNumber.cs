using System;
using TestClass;

namespace TestProject1;

public class test_FindEvenOddNumber
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var classAp = new FindEvenOddNumber_class();

        var result = classAp.findEventOddNumber(3);
        var expected_result = "Odd";

        Assert.AreEqual(expected_result, result);
    }

    [Test]
    public void Test2()
    {
        var classAp = new FindEvenOddNumber_class();

        var result = classAp.findEventOddNumber(8);
        var expected_result = "Even";

        Assert.AreEqual(expected_result, result);
    }

    [Test]
    public void Test3()
    {
        var classAp = new FindEvenOddNumber_class();

        var result = classAp.findEventOddNumber(0);
        var expected_result = "Even";

        Assert.AreEqual(expected_result, result);
    }
    [Test]
    public void Test4()
    {
        var classAp = new FindEvenOddNumber_class();

        var result = classAp.findEventOddNumber(-3);
        var expected_result = "Odd";

        Assert.AreEqual(expected_result, result);
    }
}
