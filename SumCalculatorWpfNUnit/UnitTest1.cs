using SumCalculatorWpf.Entitites;
using System.Security.Cryptography.X509Certificates;

namespace SumCalculatorWpfNUnit
{
    public class Tests
    {
        public MethodSelectionInfo selectionInfo;
        
        [SetUp]
        public void Setup()
        {
            selectionInfo = new MethodSelectionInfo(50.0,70.0,"comfort",10,25.0);
        }

        
        [Test]
        public void MethodologiesTest() 
        {
            MethodSelectionInfo methodSelectInfo = new MethodSelectionInfo(50.0,70.0,"comfort",10,25.0);
            Assert.That(methodSelectInfo, Is.EqualTo(selectionInfo)); 
        }
    }
}