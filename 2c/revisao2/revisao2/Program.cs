using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace revisao2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod = 0,i;
            Console.ReadLine();
            cod = int.Parse(Console.ReadLine());
            
            Consultar  produto = new Consultar ();
            Console.ReadLine();
            produto.quant = int.Parse(Console.ReadLine());
            Console.WriteLine("VC DEJESA 1 - DELETAR UM ITEM 2 - Inseri um item 3 - selecionar um item  ");
            i = int.Parse(Console.ReadLine());
            if (i == 1)
            {
                Console.WriteLine(produto.deleta(cod));
            }
            else if (i == 2)
            {
                Console.ReadLine();
                produto.cod = int.Parse(Console.ReadLine());
                Console.ReadLine();
                produto.Produto= Console.ReadLine();
                Console.ReadLine();
                produto.Preco = double.Parse(Console.ReadLine());
                Console.ReadLine();
                produto.Kcal = double.Parse(Console.ReadLine());

            }
            else if (i == 3)
            {
                Console.ReadLine();
                produto.quant = int.Parse(Console.ReadLine());
                Console.WriteLine(produto.Cardapio());
            }
          


        }

        
    }
}
