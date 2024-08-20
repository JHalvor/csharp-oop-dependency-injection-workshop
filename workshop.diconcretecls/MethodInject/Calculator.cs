using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop.diconcretecls.MethodInject
{
    public class Calculator
    {
        private MultiplyEngine _multiplyEngine;

      

        public int Multiply(int a, int b, MultiplyEngine multiplyEngine)
        {
            _multiplyEngine = multiplyEngine;
            return _multiplyEngine.Multiply(a, b);
        }

        public MultiplyEngine MultiplyEngine { get { return _multiplyEngine; } set { _multiplyEngine = value; } }
    }
}
