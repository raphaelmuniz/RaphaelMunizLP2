using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etapa_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int j;

            string mol, potencia, idade, inf;

            Console.WriteLine("Qual o número de carros ?");
            j = int.Parse(Console.ReadLine());

            for (int i = 0; i < j; i++)
            {


                Console.WriteLine(" o modelo do carro");
                mol = Console.ReadLine();

                inf = classificar(idade,potencia);
                Console.WriteLine("{0},{1},{2}", mol, idade, potencia);
            }

        }

        static string classificar(string idade, string potencia)
        {
            double pot, km;

            string ida, pote;
            Console.WriteLine(" o número de km rodados");
            km = double.Parse(Console.ReadLine());

            Console.WriteLine(" potência do motor");
            pot = double.Parse(Console.ReadLine());

            if (km <= 5000)
            {
                ida = "Novo";
            }

            else if (km >= 3000)
            {
                ida = "Seminovo";
            }

            else
            {
                ida = "Velho";
            }

            //aqui começa o if da potencia

            if (pot >= 200)
            {
                pote = "Potente";
            }

            else if (pot < 200 && pot >= 120)
            {
                pote = "Forte";
            }

            else
            {
                pote = "Popular";
            }

            return String.Format("{0},{1},", ida, pote);
        }
    }
}
