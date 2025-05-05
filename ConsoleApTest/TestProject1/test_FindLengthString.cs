using TestClass;

namespace TestProject1;

public class test_FindLengthString
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var cl = new FindLengthString_class();
        string myString = "Hello World.";
        int result = cl.FindLengthString(myString);

        int expected_output = 12;
        Assert.AreEqual(expected_output,result);
    }
}
