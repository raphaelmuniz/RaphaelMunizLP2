using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContagemDeVogais
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = 0;
            int[] j = new int[r];
            string palavrinha= Console.ReadLine().ToLower();

            for (int i = 0; i < palavrinha.Length; i++)
            {
                if (palavrinha[i] == 'a' || palavrinha[i] == 'e' || palavrinha[i] == 'i' || palavrinha[i] == 'o' || palavrinha [i] == 'u')
                {
                   r++;
                }
            }
            Console.WriteLine(" {0} vogais.", r);
        }

    }
}
