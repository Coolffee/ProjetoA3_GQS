using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaTicketChamada.Sistema.definicaoDeClasses;
using SistemaTicketChamada.Sistema.interfaceCommand;


namespace SistemaTicketChamada.Sistema.factoryMethod
{
    internal class IfactoryMethodTicket : interfaceTicket
    {
        List<Ticket> listTicket = new List<Ticket>();//aqui é que vai passar as informações dos tickets

        Ticket interfaceTicket.GetById(int id)
        {
            foreach (Ticket ticket in listTicket)
            {
                if (listTicket.id == id)
                {
                    return ticket;//Eu acho que está errado, depois verificar a lógica
                }
            }

            throw new NotImplementedException();
        }
        public void Add(Ticket ticket)
        {
            listTicket.Add(ticket);

            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            listTicket.Remove(id);

            throw new NotImplementedException();
        }

        public void Update(Ticket ticket)
        {


            throw new NotImplementedException();
        }


    }
}
