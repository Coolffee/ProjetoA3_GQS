using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTicketChamada.definicaoDeClasses
{
    internal class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string NumeroCelular { get; set; }
        public string CPF { get; set; }
        public string CEP { get; set; }

        public Usuario(int id, string nome, string email, string endereco, string numeroCelular, string cpf, string cep)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Endereco = endereco;
            NumeroCelular = numeroCelular;
            CPF = cpf;
            CEP = cep;
        }
    }
}
