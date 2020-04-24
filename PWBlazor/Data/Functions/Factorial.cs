using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PWBlazor.Data.Functions
{
    public class Factorial : IFunction
    {
        public double Compute(double input)
        {
            if (input < 0) return 0;
            if (input == 0) return 1;
            if (input == 2) return 2;
            if (input == 1) return 1;

            return input * this.Compute(input - 1);
        }

        public string GetName()
        {
            return "n!";
        }
    }
}
