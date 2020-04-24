using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PWBlazor.Data.Functions
{
    public class Abs : IFunction
    {
        public double Compute(double input)
        {
            return Math.Abs(input);
        }

        public string GetName()
        {
            return "Abs";
        }
    }
}
