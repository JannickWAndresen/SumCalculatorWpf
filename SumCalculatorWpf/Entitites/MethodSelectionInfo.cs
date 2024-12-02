using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumCalculatorWpf.Entitites
{
    internal class MethodSelectionInfo
    {
        public MethodSelectionInfo(double personnel, double culture, string criticality, int size, double dynanism) 
        {
            this.Personnel = personnel;
            this.Culture = culture;
            this.Criticality = criticality;
            this.Size = size;
            this.Dynamism = dynanism;
        }

        
        public double Personnel { get; set; }
        public double Culture { get; set; }
        public string Criticality { get; set; }
        public int Size { get; set; }
        public double Dynamism { get; set; }

        /*
        Personnel
        Culture
        Criticality
        Size
        Dynamism
         */
    }
}
