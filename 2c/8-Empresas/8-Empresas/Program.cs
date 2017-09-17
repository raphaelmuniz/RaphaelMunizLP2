using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8_Empresas
{
    class Program
    {
        static void Main(string[] args)
        {

            int tipo;
            Console.WriteLine("Os tipos de funionarios SÃO Empregados (1),gerente (2),TERCERIZADO (3)");
            tipo = int.Parse(Console.ReadLine());
            
            string email,nome ,data ,registro;
            int cpf;
            Console.WriteLine("Nome:");
            nome = Console.ReadLine();

            Console.WriteLine("CPF:");
            cpf = int.Parse (Console.ReadLine());

            Console.WriteLine("Número de registro:");
           registro = Console.ReadLine();
            
            Console.WriteLine("E-mail:");
            email = Console.ReadLine();
            
            Console.WriteLine("Data :");
            data = Console.ReadLine();
            

            funcionario f = new funcionario(nome,cpf, registro, email, data);
            gerente g = new gerente(nome, cpf, registro, email, data);
            Empregado e = new Empregado(nome, cpf, registro, email, data);
            tercerizado t = new tercerizado(nome, cpf, registro, email, data);
            
            if (tipo == 1)
            {
                Console.Write(e.fomulario(nome, cpf, registro, email, data));
            }

            else if (tipo == 2)
            {
                Console.Write(g.fomulario(nome, cpf, registro, email, data));
            }

            else if (tipo == 3)
            {
                Console.Write(t.fomulario(nome, cpf, registro, email, data));
            }        
         

        }
    }
}
