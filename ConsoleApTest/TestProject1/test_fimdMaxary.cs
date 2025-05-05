using TestClass;

namespace TestProject1;

public class test_fimdMaxary
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var cl = new FindMaxArry_class();

        var output = cl.FindMaxArray(new int[] { 1, 2, 3, 4, 5, 6 });

        var expectedOutput = 6;

        Assert.AreEqual(expectedOutput, output);
    }

    [Test]
    public void Test2()
    {
        var cl = new FindMaxArry_class();

        var output = cl.FindMaxArray(new int[] { 5 });

        var expectedOutput = 5;

        Assert.AreEqual(expectedOutput, output);
    }

    [Test]
    public void Test3()
    {
        var cl = new FindMaxArry_class();

        var output = cl.FindMaxArray(new int[] { -1, -2, -3, -4, -5 });
        var expectedOutput = -1;  

        Assert.AreEqual(expectedOutput, output);
    }

    // Test 4: Array with mixed positive and negative numbers
    [Test]
    public void Test4()

    {
        var cl = new FindMaxArry_class();

        var output = cl.FindMaxArray(new int[] { -1, 5, 3, -2, 7, 4 });

        var expectedOutput = 7;
        Assert.AreEqual(expectedOutput, output);
    }
}
