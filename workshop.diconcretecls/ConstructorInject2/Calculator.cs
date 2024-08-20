using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop.diconcretecls.ConstructorInject2
{
    public class Calculator
    {
        CalculationEngine _engine;
        public Calculator(CalculationEngine engine)
        {
            _engine = engine;
        }
        public int Calculate(int a, int b)
        {
            return _engine.Calculate(a, b);
        }
    }
}
