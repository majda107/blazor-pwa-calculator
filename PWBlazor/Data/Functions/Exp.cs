using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PWBlazor.Data.Functions
{
    public class Exp : IFunction
    {
        public double Compute(double input)
        {
            return Math.Exp(input);
        }

        public string GetName()
        {
            return "Exp";
        }
    }
}
