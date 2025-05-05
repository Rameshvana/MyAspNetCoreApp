using TestClass;

namespace TestProject1;

public class test_ReverseString
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var cl = new ReverseString_class();
        string my_string = "ramesh";

        string result = cl.ReverseString(my_string);
        string expected_result = "hsemar";

        Assert.AreEqual(expected_result,result);
    }
}
