using SumCalculatorWpf.Entitites;
using System.Security.Cryptography.X509Certificates;
using NUnit.Framework;
using System.Collections;
using SumCalculatorWpf.ApplicationLayer;

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
                yield return new TestCaseData(new MethodSelectionInfo(50.0, 70.0, "comfort", 10, 25.0)).Returns(1).SetName("Stop tihi");
                yield return new TestCaseData(new MethodSelectionInfo(50.0, 70.0, "danger", 10, 25.0)).Returns(0).SetName("Don't fuck off");
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
        public int MethodCalcTest(MethodSelectionInfo selectionInfo)
        {
            return CalcMethod.CalculateMethodology();
        }
    }
}