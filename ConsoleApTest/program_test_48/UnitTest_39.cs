using program_48;

namespace program_test_48
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
            var pr48 = new Class39();
            int[] arr = { 1, 2, 3, 2, 1, 4, 5 };
            var result = pr48.CountDublicateArray(arr);
            int expectedOutput = 2;
            Assert.AreEqual(expectedOutput,result);
        }
        [Test]
        public void Test2()
        {
            var pr48 = new Class39();
            int[] arr = { -1,-2,-3,-4,-2,-3,-5 };
            var result = pr48.CountDublicateArray(arr);
            int expectedOutput = 2;
            Assert.AreEqual(expectedOutput, result);
        }
        [Test]
        public void Test3()
        {
            var p48 = new Class39();
            int[] arr = { -1, 0, 1, 2, 1, 2, 5, 0, 4, -1 };
            var result = p48.CountDublicateArray(arr);
            int expectedOutput = 4;
            Assert.AreEqual(expectedOutput, result);
        }

        [Test]
        public void Test4()
        {
            var p48 = new Class39();
            int[] arr = { 1,2,3,4,5,1,2,3,5,1,2,3 };
            var repertedElements_count_Result = p48.CountDublicateArray(arr);
            int expectedoutput = 4;
            Assert.AreEqual(expectedoutput, repertedElements_count_Result);
        }


    }
}