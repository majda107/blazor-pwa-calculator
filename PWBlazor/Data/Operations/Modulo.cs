using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PWBlazor.Data.Operations
{
    public class Modulo : IOperation
    {
        private double lastResult;
        private bool baseSet;
        private bool ready;
        private double lastBuffered;
        public Modulo()
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
                this.lastResult = this.lastResult % this.lastBuffered;

            return this.lastResult;
        }

        public void Clear()
        {
            this.baseSet = false;
            this.lastResult = 0;
            this.lastBuffered = 0;
            this.ready = false;
        }

        public string GetName() => "Mod";

        public string GetSymbol() => "mod";
    }
}
