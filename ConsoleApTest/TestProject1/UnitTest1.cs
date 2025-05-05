using TestClass;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var cl = new Class1();

            var output = cl.FindMaxArray(new int[] { 1, 2, 3, 4, 5, 6 });

            var expectedOutput = 6;

            Assert.AreEqual(expectedOutput, output);
        }
        [Test]
        public void Test2()
        {
            var cl = new Class1();
            int[,] arr1 = { { 1, 2, 3 }, { 3, 4, 5 } };

            int[,] arr2 = { { 1, 2, 3 }, { 3, 4, 5 } };


            int[,] a = cl.AddMatrix(arr1, arr2);

            int[,] expected = { { 2, 4, 6 }, { 6, 8, 10 } };

            Assert.AreEqual(expected, a);

        }
        [Test]
        public void Test3()
        {
            var cl = new Class1();
            int[,] arr1 = { { 1, 2, 3, 1 }, { 3, 4, 5, 6 }, { 3, 4, 5, 8 } };
            List<int> expectedResult = new List<int> { 1, 4, 5 };
            var result = cl.DiagonalMatricx(arr1);

            Assert.AreEqual(expectedResult, expectedResult);
        }
        [Test]
        public void Test4()
        {
            var cl = new Class1();
            int[,] arr1 = { { 1, 2, 3 }, { 3, 4, 5 }, { 3, 40, 5 } };
            int expectedOutput = 40;
            int result = cl.FindMaxMatrix(arr1);
            Assert.AreEqual(expectedOutput, result);

        }
        [Test]
        public void Test5()
        {
            var cl = new Class1();
            int[,] arr1 = { { 11, 22, 33, 44 }, { 21, 22, 33, 34 }, { 10, 11, 12, 13 } };
            int expedOutput = 70;
            //int result = cl.Sum(arr1);
            //Assert.AreEqual(expectedOutput, result);
        }
    }
}