using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PWBlazor.Data.Operations
{
    public interface IOperation
    {
        string GetName();
        string GetSymbol();
        void BufferNumber(double number);

        double Calculate();
        void Clear();
    }
}
