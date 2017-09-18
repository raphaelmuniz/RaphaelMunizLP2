using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8_Empresas
{
    class gerente : funcionario
    {
      public double BONUS { get; set; }
      public string Setor { get; set; }
      public gerente(string nome, int cpf, string registro, string email, string data,string setor): base(nome, cpf, registro, email, data)
      {
          this.Setor = setor;
      }
      public string fomulario(string nome, int cpf, string registro, string email, string data,string setor)
      {   
       return String.Format(nome, cpf, registro, email, data,setor);
       }
      }
   }

