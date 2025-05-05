using TestClass;

namespace TestProject1;

public class test_ReversetheWords
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var cl = new ReversetheWords_class();

        string myString = "My name is Ramesh";

        var result = cl.Reversethewords(myString);

        string expected_result = "Ramesh is name My";

        Assert.AreEqual(expected_result, result);
    }

    [Test]
    public void Test2()
    {
        var cl = new ReversetheWords_class();

        string myString = "Hello World";

        var result = cl.Reversethewords(myString);

        string expected_result = "World Hello";

        Assert.AreEqual(expected_result, result);
    }
}
