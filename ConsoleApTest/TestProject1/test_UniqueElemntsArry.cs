using TestClass;

namespace TestProject1;

public class test_UniqueElemntsArry
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()

    {
        // cheecking with positive numbers ...
        var cl = new uniqueElmentsArry_class();
        int[] numArry = [1, 4, 2, 5, 3, 1, 4];
        var expected_result = new HashSet<int> { 1, 4, 2, 5, 3 };
        var result = cl.UniqueElementsArry(numArry);

        Assert.AreEqual(expected_result, result);
        
    }
    [Test]
    public void Test2()
    {
        // cheecking with positive numbers ...
        var cl = new uniqueElmentsArry_class();
        int[] numArry = { 10, 40, 10, 20, 40, 30, 50 };

        var expected_result = new HashSet<int> { 10,40,20,30,50 };
        var result = cl.UniqueElementsArry(numArry);

        Assert.AreEqual(expected_result, result);

    }
    [Test]
    public void Test3()
    {
        // cheecking with negative numbers ...
        var cl = new uniqueElmentsArry_class();
        int[] numArry = { -1,-3,-6,-3,-1,-5,-4,-2};

        var expected_result = new HashSet<int> { -1,-3,-6,-5,-4,-2 };
        var result = cl.UniqueElementsArry(numArry);

        Assert.AreEqual(expected_result, result);

    }
    [Test]
    public void Test4()
    {
        // cheecking with positive and negative numbers ...
        var cl = new uniqueElmentsArry_class();
        int[] numArry = { 1,2,3,2,-3,-1,-3,4,-5,-6 };

        var expected_result = new HashSet<int> { 1,2,3,-3,-1,4,-5,-6 };
        var result = cl.UniqueElementsArry(numArry);

        Assert.AreEqual(expected_result, result);

    }
}
