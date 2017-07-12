using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_LivrosHermione
{
    class livros
    {
        public string titulo;
        public int pag;
        public int diasrestantes;

        public int cal(int pagporhoras, int pagpordia)
        {
            int Paglidas = pagpordia * pagporhoras;
            int leitura = pag / Paglidas;
            return leitura;

        }
    }
}