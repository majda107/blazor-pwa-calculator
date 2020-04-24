using PWBlazor.Data.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PWBlazor.Data.Operations
{
    public class SquareRoot : IFunction
    {
        public double Compute(double input)
        {
            if (input < 0)
                return double.NaN;

            return Math.Sqrt(input);
        }


        public string GetName()
        {
            return "Sqrt";
        }
    }
}
