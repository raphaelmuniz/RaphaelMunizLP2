using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MêsPorExtenso
{
    class Program
    {
        static void Main(string[] args)
        {
            string dia, data, ano, mes;
            Console.WriteLine("digite a data");
            data = (Console.ReadLine());
            dia = data.Substring(0, 2);
            mes = data.Substring(3, 2);
            ano = data.Substring(6, 4);
            if (mes == "01")
                mes = "janeiro";
            else if (mes == "02")
                mes = "Fevereiro";
            else if (mes == "03")
                mes = " Março";
            else if (mes == "04")
                mes = "Abril";
            else if (mes == "05")
                mes = "Maio";
            else if (mes == "06")
                mes = "Junho";
            else if (mes == "07")
                mes = "Julho";
            else if (mes == "08")
                mes = "Agosto";
            else if (mes == "09")
                mes = "Setembro";
            else if (mes == "10")
                mes = "Outubro";
            else if (mes == "11")
                mes = "Novembro";
            else if (mes == "12")
                mes = "Dezembro";
            Console.WriteLine("{0} de {1} de {2}", dia, mes, ano);
            Console.ReadLine();
        }
    }
}
