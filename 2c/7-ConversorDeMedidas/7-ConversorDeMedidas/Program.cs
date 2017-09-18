using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7_ConversorDeMedidas
{
    class Program
    {
        static void Main(string[] args)
        {
            double temperatura = 0;
            Console.WriteLine("Qual é a sua distacia ? ");
            temperatura = int.Parse(Console.ReadLine());
            int TIPO;
            Console.WriteLine("Os tipos de temperatura : cel para far (1), far para cel (2), cel para kel (3),kel para cel (4) , kel para far (5),far para kel");
            TIPO = int.Parse(Console.ReadLine());
            if (TIPO == 1)
            {
                Console.WriteLine(conversor.convercelparafar(temperatura));

            }
            else if (TIPO == 2)
            {
                Console.WriteLine(conversor.converfarparacelsu(temperatura));

            }
            else if (TIPO == 3)
            {
                Console.WriteLine(conversor.convercelparakel(temperatura));

            }
            else if (TIPO == 4)
            {
                Console.WriteLine(conversor.converkelparacel(temperatura));

            }
            else if (TIPO == 5)
            {
                Console.WriteLine(conversor.converkelparafar(temperatura));


            }
            else if (TIPO == 6)
            {
                Console.WriteLine(conversor.converfarparakel(temperatura));

            } 
            
        
        }
    }
}
