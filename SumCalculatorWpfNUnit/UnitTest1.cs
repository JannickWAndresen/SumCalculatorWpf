namespace SumCalculatorWpfNUnit
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(1, ExpectedResult = 3)]
        public int MethodologiesTest(int methodSelectionInfo) 
        {
            return 0;
        }
    }
}