﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumCalculatorWpf.Entitites
{
    public class MethodSelectionInfo
    {
        public MethodSelectionInfo(double personnel, double culture, string criticality, int size, double dynanism, int selectedFactoring) 
        {
            this.Personnel = personnel;
            this.Culture = culture;
            this.Criticality = criticality;
            this.Size = size;
            this.Dynamism = dynanism;
            this.SelectedFactoring = selectedFactoring;
        }

        
        public double Personnel { get; set; }
        public double Culture { get; set; }
        public string Criticality { get; set; }
        public int Size { get; set; }
        public double Dynamism { get; set; }
        public int SelectedFactoring { get; set; }

        /*
        Personnel
        Culture
        Criticality
        Size
        Dynamism
         */
    }
}
