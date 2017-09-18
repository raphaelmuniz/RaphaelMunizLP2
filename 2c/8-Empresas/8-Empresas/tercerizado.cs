using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8_Empresas
{
    class tercerizado :funcionario
    {
        public string EmpresaM;
        
        public tercerizado(string nome, int cpf, string registro, string email, string data, string empresa) : base(nome, cpf, registro, email, data)
        {
            this.EmpresaM = empresa;
        }
        public string fomulario (string nome, int cpf, string registro, string email, string data,string empresa)
        {
          return String.Format(nome, cpf, registro, email, data,empresa);
        }
    }
}
