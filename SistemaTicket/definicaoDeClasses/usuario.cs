using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTicketChamada.Sistema.definicaoDeClasses
{
    internal class Usuario
    {
        
        private object value;
        private object email;
        private object endereco;
        private object numeroCelular;
        private object cpf;
        private object cep;

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string NumeroCelular { get; set; }
        public string CPF { get; set; }
        public string CEP { get; set; }

        public Usuario(int id, string nome, string email, string endereco, string numeroCelular, string cPF, string cEP)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Endereco = endereco;
            NumeroCelular = numeroCelular;
            CPF = cPF;
            CEP = cEP;
        }

        public Usuario(object value, object email, object endereco, object numeroCelular, object cpf, object cep)
        {
            this.value = value;
            this.email = email;
            this.endereco = endereco;
            this.numeroCelular = numeroCelular;
            this.cpf = cpf;
            this.cep = cep;
        }
    }
}
