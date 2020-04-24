using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PWBlazor.Data.Operations
{
    public class Subtract : IOperation
    {
        private double lastResult;
        private bool baseSet;
        private bool readySubtract;
        private double lastBuffered;
        public Subtract()
        {
            this.Clear();
        }

        public void BufferNumber(double number)
        {
            if (!this.baseSet)
            {
                this.lastResult = number;
                this.baseSet = true;
            }
            else
                this.readySubtract = true;

            this.lastBuffered = number;
        }
        public double Calculate()
        {
            if (this.readySubtract)
                this.lastResult = this.lastResult - this.lastBuffered;

            return this.lastResult;
        }

        public void Clear()
        {
            this.baseSet = false;
            this.lastResult = 0;
            this.lastBuffered = 0;
            this.readySubtract = false;
        }

        public string GetName() => "Subtract";

        public string GetSymbol() => "-";
    }
}
