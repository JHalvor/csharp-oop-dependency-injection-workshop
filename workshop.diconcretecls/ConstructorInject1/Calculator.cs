using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop.diconcretecls.ConstructorInject
{
    public class Calculator
    {
        private AddEngine _addEngine;

        //private AddEngine _addEngine = new AddEngine();

        public Calculator(AddEngine addEngine)
        {
            _addEngine = addEngine;
        }
        public int Add(int a, int b)
        {
           return _addEngine.Add(a, b);
        }
    }
}
