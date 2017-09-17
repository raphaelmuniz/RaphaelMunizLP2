using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6_Geometria
{
    class Triangulo
    {
        private double leicos;
        public double Leicos
        {
            get { return leicos; }
        }

        private double perimetro;
        public double Perimetro {
            get { return perimetro; }
        }
        private double area;
        public double Area
        {
            get { return area; }
        }
        public double Area(double BAS, double ALTU)
        {
            area = (BAS * ALTU) / 2;

            return area;
        }
        public double Perimetro(double ladoa, double ladob, double ladoc)
        {
            perimetro = ladoa + ladob + ladoc;
            return perimetro;
        }
       
        internal double Area()
        {
            throw new NotImplementedException();
        }
        internal double Perimetro()
        {
            throw new NotImplementedException();
        }

    }
}
