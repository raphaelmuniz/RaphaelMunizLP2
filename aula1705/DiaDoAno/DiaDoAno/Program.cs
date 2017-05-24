using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiaDoAno
{
    class Program
    {
        static void Main(string[] args)
        {
            string  data, mes;
            int n = 0;
            int dia = 0;
            
            Console.WriteLine("digite a data");
            data = (Console.ReadLine());
            mes = data.Substring(6);
            dia = int.Parse(data.Substring(0, 2));
            if (mes == "janeiro")
            {
                n = dia;
            }
            else if (mes == "fevereiro")
            {
                n = 31 + dia;
            }
            else if (mes == "março")
            {
                n = dia + 59;
            }
            else if (mes == "abril")
            {
                n = dia + 90;
            }
            else if (mes == "maio")
            {
                n = dia + 120;
            }
            else if (mes == "junho")
            {
                n = dia + 151;
            }
            else if (mes == "julho")
            {
                n = dia + 181;
            }
            else if (mes == "agosto")
            {
                n = dia + 212;
            }
            else if (mes == "setembro")
            {
                n = dia + 243;
            }
            else if (mes == "outubro")
            {
                n = dia + 273;
            }
            else if (mes == "novembro")
            {
                n = dia + 304;
            }
            else
                n = 365 - dia;
             
            Console.WriteLine("{0} dia ",n);
            Console.ReadLine();


        }
    }
}
