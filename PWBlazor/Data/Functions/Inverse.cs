using PWBlazor.Data.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PWBlazor.Data.Operations
{
    public class Inverse : IFunction
    {
        public double Compute(double input)
        {
            return 1.0d / input;
        }

        public string GetName()
        {
            return "1/x";
        }
    }
}
