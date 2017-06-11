using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace corrriddaa
{
    class speedforce
    {
    
        public string nome;
        public double tempo1;
        public double tempo2;
        public double tempo3;

        public double Tempo()
        {
            double[] temp = new double[3] { tempo1, tempo2, tempo3 };
            Array.Sort(temp);
            return temp[0] + temp[1];
    }
}
