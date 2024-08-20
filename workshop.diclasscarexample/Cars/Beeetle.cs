using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workshop.diclasscarexample.CarParts;

namespace workshop.diclasscarexample.Cars
{
    public class Beeetle
    {
        private CarEngine _engine;

        public Beeetle(CarEngine carEngine)
        {
            _engine = carEngine;
        }

        public void Start()
        {
            _engine.Start();
        }
    }
}
