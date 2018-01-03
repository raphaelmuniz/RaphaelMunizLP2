using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
namespace ConsoleApplication1
{
    class Registro
    {
        public int Idc { get; set; }
        public string Data { get; set; }
        public string Nome { get; set; }
        public string CPF  { get; set; }
        public string Email{ get; set; }
        public string Senha{ get; set; }
        public string Endereco{ get; set; }
        
        SqlCommand cmd = new SqlCommand()
        {
            Connection = new SqlConnection("Data Source=localhost; Initial Catalog=BancoDeDados; Integrated Security=SSPI;"),
        };
       
        
        public Registro(string nome, string cpf, int idc, string email, string data, string senha, string endereco)
        {
            this.Nome = nome;
            this.Data = data;
            this.Idc = idc;
            this.CPF = cpf;
            this.Email = email;
            this.Senha = senha;
            this.Endereco = endereco;
                        
        }
        public string cadastro(string nome, string cpf, int idc, string email, string data, string senha, string endereco)
        {
              
              cmd.CommandText = String.Format(@"INSERT
                                              INTO cliente
                                              VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}');", Nome, Data, Idc, CPF, Email, Senha, Endereco);

              return String.Format("O seu registro foi concluindo:", nome);

          
        }
        public string Login(string nome, string email)
        { 
        
        
        }

    }
}
