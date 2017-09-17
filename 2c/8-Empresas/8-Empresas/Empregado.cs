using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8_Empresas
{
    class Empregado
    {   public string Registro { get; set; }
        public string Data { get; set; }
        public string Nome { get; set; }
        public int CPF { get; set; }
        public string Email { get; set; }
        public double Salario { get; set; }

        public Empregado(string nome, int cpf, string registro, string email, string data)
        {
            this.Nome = nome;
            this.Data = data;
            this.Registro = registro;
            this.CPF = cpf;
            this.Email = email;
        }
    }
}
