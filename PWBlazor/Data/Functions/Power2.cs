using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PWBlazor.Data.Functions
{
    public class Power2 : IFunction
    {
        public double Compute(double input)
        {
            return Math.Pow(input, 2);
        }

        public string GetName()
        {
            return "Pow2";
        }
    }
}
