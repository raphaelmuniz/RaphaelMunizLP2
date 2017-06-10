using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetonoplano
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 600, L = 800;

            Console.Write("digite x");
            int x = int.Parse(Console.ReadLine());

            Console.Write("digite y");
            int y = int.Parse(Console.ReadLine());

            Objeto obj = new Objeto();
            obj.x = x;
            obj.y = y;
            Console.Write("digite comado");
            ConsoleKey comado = Console.ReadKey().Key;
            
            for (int i = 0; i )
            if (comado == ConsoleKey.RightArrow)
             {
                 obj.andarparadireita();
                 Console.WriteLine(obj.coordenadas());
             }
            else
            {

            }
        }
    }
}
