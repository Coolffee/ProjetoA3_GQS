using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTicketChamada.Sistema.definicaoDeClasses
{
    internal class Ticket

    {
        private int id { get; set; }
        private string titulo { get; set; }
        private string descricao { get; set; }
        private bool resolvido { get; set; }

        public Ticket(int id, string titulo, string descricao, bool resolvido)
        {
            this.id = id;
            this.titulo = titulo;
            this.descricao = descricao;
            this.resolvido = resolvido;
        }
    }
}
