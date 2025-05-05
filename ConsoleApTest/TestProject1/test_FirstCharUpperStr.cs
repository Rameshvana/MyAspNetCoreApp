using System;
using TestClass;

namespace TestProject1;

public class test_FirstCharUpperStr
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var cl = new FirstCharUpperString_class();

        string mainString = "hello world";

        var result = cl.FirstCharUpperString(mainString);
        string expected_output = "Hello World";

        Assert.AreEqual(expected_output, result);
    }

    [Test]
    public void Test2()
    {
        var cl = new FirstCharUpperString_class();

        string mainString = "Hello india and This is text is for Testing";

        var result = cl.FirstCharUpperString(mainString);
        string expected_output = "Hello India And This Is Text Is For Testing";

        Assert.AreEqual(expected_output, result);
    }

    [Test]
    public void Test3()
    {
        var cl = new FirstCharUpperString_class();

        string mainString = "The quick brown fox jumps over the lazy dog";

        var result = cl.FirstCharUpperString(mainString);
        string expected_output = "The Quick Brown Fox Jumps Over The Lazy Dog"; ;

        Assert.AreEqual(expected_output, result);
    }
}
