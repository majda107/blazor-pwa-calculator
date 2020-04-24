using PWBlazor.Data.Functions;
using PWBlazor.Data.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PWBlazor.Data
{
    public class CalculatorService
    {
        public List<IOperation> Operations { get; private set; }
        public List<IFunction> Functions { get; private set; }
        public IOperation LastOperation { get; set; }
        public CalculatorService()
        {
            this.Operations = new List<IOperation>();
            this.Functions = new List<IFunction>();

            this.Init();
            this.LastOperation = null;
        }

        private void Init()
        {
            this.Operations.Add(new Add());
            this.Operations.Add(new Subtract());
            this.Operations.Add(new Multiply());
            this.Operations.Add(new Divide());
            this.Operations.Add(new Modulo());
            this.Operations.Add(new Percentage());
            //this.Operations.Add(new SquareRoot());
            //this.Operations.Add(new CubeRoot());
            //this.Operations.Add(new Power2());
            //this.Operations.Add(new Inverse());


            this.Functions.Add(new Power2());
            this.Functions.Add(new SquareRoot());
            this.Functions.Add(new CubeRoot());
            this.Functions.Add(new Inverse());
            this.Functions.Add(new Abs());
            this.Functions.Add(new Exp());
            this.Functions.Add(new Factorial());
        }
    }
}
