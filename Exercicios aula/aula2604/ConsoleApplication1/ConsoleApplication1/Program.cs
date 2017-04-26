using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {   
            int i = 0;
            Console.WriteLine("Digite um número:");
            i = int.Parse(Console.ReadLine());

            string idade= "";
            string condition = "";

            string[] modelo= new string[i];
            double[] km = new double[i];
            int[] potenc = new int[i];


            Console.WriteLine("Digite um número:");
            i= int.Parse(Console.ReadLine());
            

            for(int j= 0; j <= i; j++)
            {
                Console.WriteLine("Digite o modelo do carro");
                modelo[j] = Console.ReadLine();

                Console.WriteLine("Digite sua quilometragem rodada:");
                km[j] = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite a potência do motor:");
                potenc[j] = int.Parse(Console.ReadLine());

                if (km[j] <= 5000)
                    idade = "novo";

                if (km[j] > 5000 && km[j] <= 30000)
                    idade = "seminovo";


                else
                    idade = "velho";

                for(int x= 0; x <= i; x++)
                {
                    if(km[x] > 200
                        condition = "potente";

                    if(km[x] == 120 && km[x] <= 200)
                        //forte 120 a 200 popular menos q 200)
                }

                
            }



        }
    }
}
