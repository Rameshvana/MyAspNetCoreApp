using TestClass;

namespace TestProject1;

public class test_ComapreStrings
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var cl = new CompareStrings_class();
        string str1 = "Hello World";
        string str2 = "Hello World";
        bool result = cl.ComapteStrings(str1, str2);

        bool expected_output = true;
        Assert.AreEqual(expected_output, result);
    }
    [Test]
    public void Test2()
    {
        var cl = new CompareStrings_class();
        string str1 = "Hello Wo";
        string str2 = "Hello World";
        bool result = cl.ComapteStrings(str1, str2);

        bool expected_output = false;
        Assert.AreEqual(expected_output, result);
    }
    [Test]
    public void Test3()
    {
        var cl = new CompareStrings_class();
        string str1 = "Hello World";
        string str2 = "Hello Hello";
        bool result = cl.ComapteStrings(str1, str2);

        bool expected_output = true;
        Assert.AreEqual(expected_output, result);
    }
    [Test]
    public void Test4()
    {
        var cl = new CompareStrings_class();
        string str1 = "Telangana is state in India";
        string str2 = "Telangana is a state in India";
        bool result = cl.ComapteStrings(str1, str2);

        bool expected_output = false;
        Assert.AreEqual(expected_output, result);
    }
}
