using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PWBlazor.Data.Functions
{
    public interface IFunction
    {
        double Compute(double input);

        string GetName();
    }
}
