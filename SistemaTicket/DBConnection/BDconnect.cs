using SistemaTicketChamada.Sistema.definicaoDeClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTicketChamada.SistemaTicket.cadastroLoginUsuario
{
    internal class BDconnect//aqui seria como se fosse o singleton onde posso acessar em qualquer lugar
    {//qualquer coisa é faço formato de fila dentro armazeno seja o endereço ou um hashset 
        private static BDconnect instance;
        private List<Usuario> cadastrousuario;//aqui é como se fosse o banco de dados que tem os cadastros do cliente

        private BDconnect()
        {
            cadastrousuario = new List<Usuario>();
        }

        public static BDconnect Instance
        {
            get
            {
                if(instance== null){
                    instance = new BDconnect();
                }
                return instance;
            }
        }
        /*------------------------------------------------*/
        public void adicionarUsuario(Usuario usuario)
        {
            cadastrousuario.Add(usuario);
        }

        public List<Usuario> consultLogin
        {
            get
            {
                return cadastrousuario;
            }
        }
        /*----------------------------------------------*/


        //aqui é que vai passar as informações dos tickets, id o texto

    }
}
