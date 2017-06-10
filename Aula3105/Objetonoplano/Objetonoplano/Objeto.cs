using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetonoplano
{
    class Objeto
    {
        public int x;
        public int y;
        public int andarparadireita ()
        {
            x = x + 3;
            return x;

        }
        public string coordenadas()
        {
            return String.Format("[{0},{1}]",x,y);
        }
     
    }
}
