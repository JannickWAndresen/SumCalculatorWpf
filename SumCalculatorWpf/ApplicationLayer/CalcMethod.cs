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
            List<double> neutralWeights = new List<double>{1.4, 1.2, 1.5, 1.1, 1.3};
            List<double> agileWeights = new List<double>{1.4, 1.3, 1.8, 1.2, 1.4};
            List<double> structuredWeights = new List<double>();

            //double personnelWeight = 1.4;
            //double cultureWeight = 1.2;
            //double criticalityWeight = 1.5;
            //double sizeWeight = 1.1;
            //double dynamismWeight = 1.3;

            double totalPersonnel = personnelWeight * PersonnelMap[methodInfo.Personnel];
            double totalCulture = cultureWeight * CultureMap[methodInfo.Culture];
            double totalCriticality = criticalityWeight * CriticalityMap[methodInfo.Criticality];
            double totalSize = sizeWeight * SizeMap[methodInfo.Size];
            double totalDynamism = dynamismWeight * DynamismMap[methodInfo.Dynamism];

            var methodInt = (double mDouble) => mDouble switch
            {
                double i when i >= 5 && i <= 7 => 5,
                double i when i >= 8 && i <= 12 => 4,
                double i when i >= 13 && i <= 17 => 3,
                double i when i >= 18 && i <= 22 => 2,
                _ => 1

            };

            double total =
                totalPersonnel +
                totalCulture +
                totalCriticality +
                totalSize +
                totalDynamism;

            return methodInt(total);
        }
    }
}
