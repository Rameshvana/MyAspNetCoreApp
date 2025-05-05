using TestClass;

namespace TestProject1;

public class test_FindPrimeNumer
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
       // Cheecking with odd number

        var clasAp = new FindPrimeNumber_class();
        var result = clasAp.FindPrimeNumber(3);

        var expected_output = "Prime";
        Assert.AreEqual(expected_output, result);
    }
    [Test]
    public void Test2()
    {
        //checking with negative number 

        var clasAp = new FindPrimeNumber_class();
        var result = clasAp.FindPrimeNumber(0);

        var expected_output = "not Prime";
        Assert.AreEqual(expected_output, result);
    }
    [Test]
    public void Test3()
    {
        //checking with positive number

        var clasAp = new FindPrimeNumber_class();
        var result = clasAp.FindPrimeNumber(23);

        var expected_output = "Prime";
        Assert.AreEqual(expected_output, result);
    }

    [Test]
    public void Test4()
    {
        // checking with negative number

        var clasAp = new FindPrimeNumber_class();
        var result = clasAp.FindPrimeNumber(-4);

        var expected_output = "not Prime";
        Assert.AreEqual(expected_output, result);
    }

    [Test]
    public void Test5()
    {


        var clasAp = new FindPrimeNumber_class();
        var result = clasAp.FindPrimeNumber(5233);

        var expected_output = "Prime";
        Assert.AreEqual(expected_output, result);
    }
}
