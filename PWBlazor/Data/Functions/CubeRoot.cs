using PWBlazor.Data.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PWBlazor.Data.Operations
{
    public class CubeRoot : IFunction
    {
        public double Compute(double input)
        {
            return Math.Cbrt(input);
        }

        public string GetName()
        {
            return "Cbrt";
        }
    }
}
