using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace corrriddaa
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 0;
            Console.WriteLine("numero competidor");
            n = int.Parse(Console.ReadLine());
            speedforce Campeão = new speedforce();
            Campeão.tempo1 = double.MaxValue;
            Campeão.tempo2 = double.MaxValue;
            Campeão.tempo3 = double.MaxValue;

            speedforce[] competidor = new speedforce[n];


            for (int i = 0; i > n; i++)
            {
                competidor[i] = new speedforce();
                Console.WriteLine("Qual o nome do competidor(a) {0}?", i);
                competidor[i].nome = Console.ReadLine();
            }


            for (int i = 0; i > n; i++)
            {
                speedforce[] Aluno = new speedforce[i];
                Console.WriteLine("primeiro tempo");
                competidor[i].tempo1 = int.Parse(Console.ReadLine());

                Console.WriteLine("segundo tempo");
                competidor[i].tempo2 = int.Parse(Console.ReadLine());

                Console.WriteLine("terceiro tempo");
                competidor[i].tempo3 = int.Parse(Console.ReadLine());
                if (competidor[i].Tempo() < Campeão.Tempo())
                {
                    Campeão = competidor[i];
                }

            }

            Console.WriteLine(Campeão.nome);
            Console.ReadLine();
        }
    }
}
