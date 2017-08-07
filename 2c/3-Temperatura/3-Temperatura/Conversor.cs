using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3_Temperatura
{
    class Conversor
    {
        public double celsus, fahrenheit, kelvin;

        public double converemfar(double temp)
        { 
            return fahrenheit = (celsus * 1.8) + 32;
        }

        public double converemkel(double temp)
        {
            return kelvin = celsus + 273;
        }
    }
}
