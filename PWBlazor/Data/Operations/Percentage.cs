using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PWBlazor.Data.Operations
{
    public class Percentage : IOperation
    {
        private double lastResult;
        private bool baseSet;
        private bool ready;
        private double lastBuffered;
        public Percentage()
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
                this.ready = true;

            this.lastBuffered = number;
        }
        public double Calculate()
        {
            if (this.ready)
                this.lastResult = this.lastResult * this.lastBuffered / 100;

            return this.lastResult;
        }

        public void Clear()
        {
            this.baseSet = false;
            this.lastResult = 0;
            this.lastBuffered = 0;
            this.ready = false;
        }

        public string GetName() => "Perc";

        public string GetSymbol() => "%";
    }
}
