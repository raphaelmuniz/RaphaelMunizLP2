using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8_Empresas
{
    class tercerizado :funcionario
    {  
       public tercerizado(string nome, int cpf, string registro, string email, string data) : base(nome, cpf, registro, email, data)
        {
        }
        public string fomulario (string nome, int cpf, string registro, string email, string data)
        {
          return String.Format(nome, cpf, registro, email, data);
        }
    }
}
