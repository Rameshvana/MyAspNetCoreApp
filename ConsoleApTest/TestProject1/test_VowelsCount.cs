using TestClass;

namespace TestProject1;

public class test_VowelsCount
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        string myString = "Wellcome to India";

        var cl = new VowelsCount_class();

        string result = cl.VowelsCount(myString);

        string expected_output = "7 10";

        Assert.AreEqual(expected_output, result);

    }
    [Test]
    public void Test2()
    {
        string myString = "Hello World";

        var cl = new VowelsCount_class();
        string result = cl.VowelsCount(myString);

        string expected_output = "3 8";

        Assert.AreEqual(expected_output, result);

    }
}
