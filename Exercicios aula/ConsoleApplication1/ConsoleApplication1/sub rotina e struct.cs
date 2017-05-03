using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    { struct Carro
        {
            public string mol;
            public double km;
            public double pot;
        }
         
        
          

        static void Main(string[] args)
        {
            int j;
            string inf;

            Console.WriteLine("Qual o número de carros ?");
            j = int.Parse(Console.ReadLine());

            for (int i = 0; i < j; i++)
            {
                Carro carro1= new Carro();

                Console.WriteLine(" o modelo do carro");
                carro1.mol = Console.ReadLine();

                Console.WriteLine(" o número de km rodados");
                carro1.km = double.Parse(Console.ReadLine());

                Console.WriteLine(" potência do motor");
                carro1.pot = double.Parse(Console.ReadLine());

                inf = classificar(carro1);
                Console.WriteLine("{0}", inf);
            }
          
          }

        static string classificar(Carro carro1)
        {
            string ida, pote;

            if (carro1.km <= 5000)
            {
                ida = "Novo";
            }

            else if (carro1.km >= 3000)
            {
                ida = "Seminovo";
            }

            else
            {
                ida = "Velho";
            }

            //aqui começa o if da potencia

            if (carro1.pot >= 200)
            {
                pote = "Potente";
            }

            else if (carro1.pot < 200 && carro1.pot >= 120)
            {
                pote = "Forte";
            }

            else
            {
                pote = "Popular";
            }

            return String.Format("{0},{1},{2}", carro1.mol, ida, pote);
        }

    }
}
        }
    }
}
