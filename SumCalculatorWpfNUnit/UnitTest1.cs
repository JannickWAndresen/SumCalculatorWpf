using SumCalculatorWpf.Entitites;
using System.Security.Cryptography.X509Certificates;
using NUnit.Framework;
using System.Collections;

namespace SumCalculatorWpfNUnit
{
    public class Tests
    {
        public static IEnumerable TestCases 
        {
            get
            {
                yield return new TestCaseData(new MethodSelectionInfo(50.0, 70.0, "comfort", 10, 25.0)).SetName("tihi");
                yield return new TestCaseData(new MethodSelectionInfo(50.0, 70.0, "danger", 10, 25.0)).SetName("fuck off");
            }
        }
        public static IEnumerable TestCasesCalcMethod 
        {
            get
            {
                yield return new TestCaseData(new MethodSelectionInfo(50.0, 70.0, "comfort", 10, 25.0)).SetName("tihi");
                yield return new TestCaseData(new MethodSelectionInfo(50.0, 70.0, "danger", 10, 25.0)).SetName("fuck off");
            }
        }
        
        [SetUp]
        public void Setup()
        {
        }

        
        [Test, TestCaseSource(nameof(TestCases))]
        public void MethodologiesTest(MethodSelectionInfo methodSelectionInfo) 
        {
            Assert.That(methodSelectionInfo.Criticality, Is.EqualTo("comfort"));
        }

        [Test, TestCaseSource(nameof(TestCasesCalcMethod))]
        public string MethodologiesTest()
        {
            Assert.That(methodSelectionInfo.Criticality, Is.EqualTo("comfort"));
        }
    }
}