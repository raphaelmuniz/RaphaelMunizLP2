using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05_Produtos
{
    class Produto
    {
        private int id;
        public int Id 
        {
            get { return id; }
        }
        public double preco { get; set; }
      
        private string nome;
        public string Nome
        {
            get { return nome; }
        }
        private int quantidade;
        public int Quant
        { get 
        { return quantidade; } 
        }


        public Produto (int id ,string nome , double preco,int quantidade)
        {
            this.id = id;
            this.nome = nome;
            this.preco = preco;
            quantidade = 0;
            
        }
        public void Receber(int qtd)
        {
            
                this.quantidade += qtd;
            
        }
         public void Retirada (int qtd)
        {
             if (this.Quant >=qtd)
             {
                 this.quantidade -= qtd;
             }
             else
             {
                 throw new Exception();

             } 

        }
        public string Imprimir()
         {
             return string.Format("{0}, {1}, {2:0.00}", id, nome, preco,Quant);
         }
    }

    }

