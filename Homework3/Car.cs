using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public class Car
    {
        public int Number { get; set; }

        public Engine Engine  { get; set; }

        public Car(int number, Engine engine)
        {
            Number = number;
            Engine = engine;
        }
    }
}
