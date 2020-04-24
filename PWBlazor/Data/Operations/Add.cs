using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PWBlazor.Data.Operations
{
    public class Add : IOperation
    {
        private double lastResult;
        private double lastBuffered;
        public Add()
        {
            this.Clear();
        }
        public void BufferNumber(double number)
        {
            this.lastBuffered = number;
        }

        public double Calculate()
        {
            this.lastResult = this.lastResult + this.lastBuffered;

            return this.lastResult;
        }

        public void Clear()
        {
            this.lastBuffered = 0;
            this.lastResult = 0;
        }

        public string GetName() => "Add";

        public string GetSymbol() => "+";
    }
}
