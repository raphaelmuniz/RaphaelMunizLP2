using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6_Geometria
{
    class Program
    {
        static void Main(string[] args)
        {
            double bas, altura, ladoA, ladoB, ladoC;
            Console.WriteLine("LADO A");
            ladoA = double.Parse(Console.ReadLine());
            Console.WriteLine("LADO B");
            ladoB = double.Parse(Console.ReadLine());
            Console.WriteLine("LADO C");
            ladoC = double.Parse(Console.ReadLine());
            Console.WriteLine("BASE");
            bas= double.Parse(Console.ReadLine());
            Console.WriteLine("ALTURA");
            altura = double.Parse(Console.ReadLine());
            

            Triangulo c = new Triangulo();

            c.Area(bas, altura);
            c.Perimetro(ladoA, ladoB, ladoC);

            Console.WriteLine(c.Perimetro());
            Console.WriteLine(c.Area());

        }
    }
}
