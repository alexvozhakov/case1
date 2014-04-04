﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case1.FirstCalculations
{
    public class Cos : IOneCalculation
    {
        public string Calculate(double firstArgument)
        {
            double result = Math.Cos(firstArgument);
            return result.ToString();
        }
    }
}
