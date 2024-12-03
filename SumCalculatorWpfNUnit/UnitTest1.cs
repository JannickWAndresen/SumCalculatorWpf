using SumCalculatorWpf.Entitites;
using System.Security.Cryptography.X509Certificates;
using NUnit.Framework;
using System.Collections;
using SumCalculatorWpf.ApplicationLayer;

namespace SumCalculatorWpfNUnit
{
    public class Tests
    {
        public static IEnumerable TestCasesCalcMethod 
        {
            get
            {
                yield return new TestCaseData(new MethodSelectionInfo(10, 30, "Essential Funds", 80, 30, 1)).Returns(3).SetName("methodcalctest_calc_based_on_five_parameters_return_3_valid_value");
                yield return new TestCaseData(new MethodSelectionInfo(50, 70, "danger", 10, 25, 2)).Returns(0).SetName("methodcalctest_calc_based_on_five_parameters_return_0_invalid_value");
                yield return new TestCaseData(new MethodSelectionInfo(40, 90, "Many Lives", 100, 1, 3)).Returns(1).SetName("methodcalctest_calc_based_on_five_parameters_return_1_highest_values");
                yield return new TestCaseData(new MethodSelectionInfo(0, 10, "Comfort", 10, 50, 1)).Returns(5).SetName("methodcalctest_calc_based_on_five_parameters_return_5_lowest_values");
            }
        }

        [Test, TestCaseSource(nameof(TestCasesCalcMethod))]
        public int MethodCalcTest(MethodSelectionInfo selectionInfo)
        {
            return CalcMethod.CalculateMethodology(selectionInfo);
        }
    }
}