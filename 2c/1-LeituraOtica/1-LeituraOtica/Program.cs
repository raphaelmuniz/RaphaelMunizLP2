using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_LeituraOtica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Número de questões: ");
            int n = int.Parse(Console.ReadLine());

            string resp = "";

            int a = 0, b = 0, c = 0, d = 0, e = 0;
            for (int i = 0; i < n; i++)
            {
                int certo = 0;
                int amb = 0;
                int branco = 0;
                Console.WriteLine("Qual o valor da alternativa A?");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Qual o valor da alternativa B?");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("Qual o valor da alternativa C?");
                c = int.Parse(Console.ReadLine());
                Console.WriteLine("Qual o valor da alternativa D?");
                d = int.Parse(Console.ReadLine());
                Console.WriteLine("Qual o valor da alternativa E?");
                e = int.Parse(Console.ReadLine());

                if (a <= 100)
                {
                    resp = "A";
                    certo++;

                }
                else if (a >= 155)
                {
                    amb++;
                }
                else
                {
                    branco++;
                }
                if (b <= 100)
                {
                    resp = "B";
                    certo++;
                }
                else if (b >= 155)
                {
                    amb++;
                }
                else
                {
                    branco++;
                }
                if (c <= 100)
                {
                    resp = "C";
                    certo++;
                }
                else if (c >= 155)
                {
                    amb++;
                }
                else
                {
                    branco++;
                }
                if (d <= 100)
                {
                    resp = "D";
                    certo++;
                }
                else if (d >= 155)
                {
                    amb++;
                }
                else
                {
                    branco++;
                }
                if (e <= 100)
                {
                    resp = "E";
                    certo++;
                }
                else if (e >= 155)
                {
                    amb++;
                }
                else
                {
                    branco++;

                }
                if (certo > 1 || branco > 1 || amb > 4)
                {
                    Console.WriteLine(resp);
                }
                else
                {
                    Console.WriteLine("*");
                }


            }
        }
    }
}
