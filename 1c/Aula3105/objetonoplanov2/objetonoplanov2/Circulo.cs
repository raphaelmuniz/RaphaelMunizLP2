﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace objetonoplanov2
{
    class Circulo
    {
        public int x = 0, y = 0, raio = 0;

        public void Direita()
        {
            x = x + 3;
        }

        public void Esquerda()
        {
            x = x - 3;
        }

        public void Cima()
        {
            y = y + 3;
        }

        public void Baixo()
        {
            y = y - 3;
        }
        public void RAIO()
        {

        }
        public string Coordenadas()
        {
            return String.Format("({0},{1})", x, y);
        }
    }
}
