using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
        
           

            string nomel,autor,numerol,genero,classificacao,nomec,senha,email,endereco,cpf,data,;
            int idL,idC,R;
            int P = 0;

            Console.WriteLine("O que deseja fazer?\n1-Efetuar o login;\n2-Fazer o regitro;\n3-Sair;"); // entrada//
            R = int.Parse(Console.ReadLine());

            if (R == 1)//login incompleto //
            {
                Console.WriteLine("senha");
                senha = Console.ReadLine();
                Console.WriteLine("email");
                email = Console.ReadLine();
                while (P < 4) // AÇÕES DEPOIS DO LOGIN//
                {
                    Console.WriteLine("O que voce deseja fazer? \n1-Alugue;\n2-Comprar;\n3-Apenas uma consulta;\n4-Sair;");
                    P = int.Parse(Console.ReadLine());

                    if (P == 1)
                    {
                        // alugueu do livro //
                    }
                    else if (P == 2)
                    {
                        // compra do livro//
                    }
                    else if (P == 3)
                    {
                        // consulta //
                    }
                    else
                    {
                        break;
                    }
                }
                
            }
            else if (R == 2) // O registro da pessoa//
            {
                Console.WriteLine("\nNome:");
                nomec = Console.ReadLine();

                Console.WriteLine("\nCPF:");
                cpf = Console.ReadLine();

                Console.WriteLine("\nNúmero de registro:");
                idC = int.Parse(Console.ReadLine());

                Console.WriteLine("\nE-mail:");
                email = Console.ReadLine();

                Console.WriteLine("\nData de nascimento (dd/mm/aaaa:");
                data = Console.ReadLine();

                Console.WriteLine("\nSenha:");
                senha = Console.ReadLine();

                Console.WriteLine("\n Endereco:");
                endereco = Console.ReadLine();

                Registro f = new Registro(nomec, cpf, idC, email, data, senha, endereco);
                Console.WriteLine(f.cadastro(nomec, cpf, idC, email, data, senha, endereco));//conexão com banco de dados está na classe registro//
                while (P < 4 )// AÇÕES DEPOIS DO LOGIN//
                { Console.WriteLine("O que voce deseja fazer? \n1-Alugue;\n2-Comprar;\n3-Apenas uma consulta;\n4-Sair;"); 
                P =int.Parse(Console.ReadLine());

                if (P == 1)
                { 
                // alugueu do livro //
                }
                else if (P == 2)
                {
                    // compra do livro//
                }
                else if (P == 3)
                {
                    // consulta //

                }
                else
                {
                    break; //sair//
                }
                }
            }
            else
            {
                Console.ReadKey();
            }
        }
    }
}
