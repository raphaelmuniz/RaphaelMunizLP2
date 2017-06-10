using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etapa_2
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

            string modelo;
            double km  ;
            int potenc ;


           
            for(int j= 0; j <= i; j++)
            {
                Console.WriteLine("Digite o modelo do carro");
                modelo = Console.ReadLine();

                Console.WriteLine("Digite sua quilometragem rodada:");
                km = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite a potência do motor:");
                potenc = int.Parse(Console.ReadLine());

                if (km <= 5000)
                    idade = "novo";

                 else if (km > 5000 && km[j] <= 30000)
                    idade = "seminovo";

                else
                    idade = "velho";

                //
                
                if(km[x] > 200)
                 {   
                    condition = "potente";
                  }
                 else if(km[x] == 120 && km[x] <= 200)
                  {   
                     condition = "forte";
                  }
                  else 
                   {  
                     condition = "fraco";
                   }
                Console.WriteLine("{0}{1},{2}",idade,condition,modelo);
        
        }

    }
}
