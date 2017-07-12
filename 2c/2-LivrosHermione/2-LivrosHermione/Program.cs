using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_LivrosHermione
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            int pagporhoras, pagpordia,n;
            Console.WriteLine("numero de livros");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("paginas por horas");
            pagporhoras = int.Parse(Console.ReadLine());
            Console.WriteLine("Paginas por dias");
            pagpordia = int.Parse(Console.ReadLine());
            
            livros[] livro = new livros[n];
            for (int i = 0; i <= n; i++)
            {
                livro[i] = new livros();
                Console.WriteLine("titulo");
                livro[i].titulo = Console.ReadLine();
                Console.WriteLine("paginas");
                livro[i].pag = int.Parse(Console.ReadLine());
                Console.WriteLine(" dias para delvolver ");
                livro[i].diasrestantes = int.Parse(Console.ReadLine());
                livro[i].cal(pagpordia, pagporhoras);


                if (livro[i].cal(pagpordia, pagporhoras) > livro[i].diasrestantes)
                {
                    
                    Console.WriteLine("Esse livro impossivel de ler :{0} ", livro[i].titulo);
                }
                else
                {
                    Console.WriteLine("Dias necessario{0}", livro[i].cal(pagpordia, pagporhoras));
                }
                
            }
             
        
        }
    }
}
