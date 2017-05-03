using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0305
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma palavra ou uma frase:");
            string palavra = Console.ReadLine();

            char vogal = Console.ReadLine().ToUpper()[0];
            int quant = 0;

            for (int i = 0; i < palavra.Length; i++)
            {
                if (vogal == 'a' || vogal == 'e' || vogal == 'i' || vogal == 'o' || vogal == 'u')
                    quant++;

                else
                    Console.WriteLine("Sua palavra/frase não possui vogais");
            }

            Console.WriteLine("{0}", quant);
        }
    }
}
