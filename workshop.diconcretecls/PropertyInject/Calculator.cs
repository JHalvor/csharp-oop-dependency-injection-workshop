using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace workshop.diconcretecls.PropertyInject
{
    public class Calculator
    {
        CalculatorEngineForAdding _calculatorEngineForAdding;

        public int Add(int a, int b)
        {
            return _calculatorEngineForAdding.Adder(a, b);
        }

        public CalculatorEngineForAdding CalculatorEngineForAdding { get { return _calculatorEngineForAdding; } set { _calculatorEngineForAdding = value; } }
    }
}
