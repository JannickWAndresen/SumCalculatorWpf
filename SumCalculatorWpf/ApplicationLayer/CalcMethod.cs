using SumCalculatorWpf.Entitites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumCalculatorWpf.ApplicationLayer
{
    static public class CalcMethod
    {

        static Dictionary<double, int> PersonnelMap = new Dictionary<double, int>()
        {
            {0,1}, {10,2}, {20,3}, {30,4}, {40,5}
        };

        static Dictionary<double, int> CultureMap = new Dictionary<double, int>() 
        {
            {10,1}, {30,2}, {50,3}, {70,4}, {90,5}
        };

        static Dictionary<string, int> CriticalityMap = new Dictionary<string, int>()
        {
            {"Comfort",1 }, {"Discretionary Comfort",2}, {"Essential Funds",3 }, {"Single Life",4 }, {"Many Lives",5 }
        };

        static Dictionary<int, int> SizeMap = new Dictionary<int, int>() 
        {
            {10,1}, {25,2}, {50,3}, {80,4}, {100,5}            
        };

        static Dictionary<double, int> DynamismMap = new Dictionary<double, int>()
        {
            {50,1}, {30,2}, {10,3}, {5,4}, {1,5}
        };

        static public int CalculateMethodology(MethodSelectionInfo methodInfo)
        {
            List<double> neutralWeights = new List<double> { 1.4, 1.2, 1.5, 1.1, 1.3 };
            List<double> agileWeights = new List<double> { 1.6, 1.5, 1.7, 1.3, 1.6 };
            List<double> structuredWeights = new List<double> { 1.3, 1.0, 1.2, 1.0, 1.1 };

            var chooseFactoringList = (double intF) => intF switch
            {
                double i when i == 1 => FactoringPicker(neutralWeights, methodInfo),
                double i when i == 2 => FactoringPicker(agileWeights, methodInfo),
                double i when i == 3 => FactoringPicker(structuredWeights, methodInfo)
            };

            double total = chooseFactoringList(methodInfo.SelectedFactoring);

            var methodInt = (double mDouble) => mDouble switch
            {
                double i when i >= 5 && i <= 9 => 5,    // Agile
                double i when i >= 10 && i <= 14 => 4,  //  |
                double i when i >= 15 && i <= 19 => 3,  //  |
                double i when i >= 20 && i <= 24 => 2,  //  V
                _ => 1                                  // Structured
            };
            return methodInt(total);
        }
        static public double FactoringPicker(List<double> factoringList, MethodSelectionInfo methodInfo) 
        {
            double total = (PersonnelMap[methodInfo.Personnel] * factoringList[0]) + 
                (CultureMap[methodInfo.Culture] * factoringList[1]) + 
                (CriticalityMap[methodInfo.Criticality] * factoringList[2] +
                (SizeMap[methodInfo.Size] * factoringList[3]) + 
                (DynamismMap[methodInfo.Dynamism] * factoringList[4]));

            Debug.WriteLine(total);

            return total;
        }
    }
}
