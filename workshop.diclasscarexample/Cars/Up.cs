using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workshop.diclasscarexample.CarParts;

namespace workshop.diclasscarexample.Cars
{
    public class Up
    {
        private CarEngine _engine;

        public Up(CarEngine carEngine)
        {
            _engine = carEngine;
        }

        public void Start()
        {
            _engine.Start();
        }
    }
}
