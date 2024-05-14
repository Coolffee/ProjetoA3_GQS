using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaTicketChamada.Sistema.definicaoDeClasses;



namespace SistemaTicketChamada.Sistema.interfaceCommand
{
    internal interface interfaceTicket
    {
        Ticket GetById(int id);
        void Add(Ticket ticket);
        void Update(Ticket ticket);
        void Delete(int id);
    }
}
