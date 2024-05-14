using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using SistemaTicketChamada.Sistema.definicaoDeClasses;

namespace SistemaTicketChamada.Sistema.interfaceCommand
{
    internal interface interfaceUsuario
    {
        Usuario GetById(int id);
        void Add(Usuario usuario);
        void Update(Usuario usuario);
        void Delete(int id);
    }
}
