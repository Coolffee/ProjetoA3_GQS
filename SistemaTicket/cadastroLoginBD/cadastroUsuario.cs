using SistemaTicketChamada.Sistema.definicaoDeClasses;
using SistemaTicketChamada.Sistema.factoryMethod.factoryMethodUsuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTicketChamada.SistemaTicket.cadastroLoginUsuario
{
    internal class cadastroUsuario
    {
        
        public static void cadastroUsuarioDB()
        {
            //List<Usuario> user = new List<Usuario>();

        Console.WriteLine("Digite as informações");
            int nextID = 1;
            Console.WriteLine("Nome");
            string nomeInput=Console.ReadLine();
            Console.WriteLine("Email");
            string emailInput = Console.ReadLine();
            Console.WriteLine("Endereço");
            string enderecoInput = Console.ReadLine();
            Console.WriteLine("NumeroCelular");
            string celularInput = Console.ReadLine();
            Console.WriteLine("CPF");
            string cpfInput = Console.ReadLine();
            Console.WriteLine("CEP");
            string cepInput = Console.ReadLine();

            DBconnect.Instance.adicionarUsuario(new Usuario (nextID++,nomeInput,emailInput,enderecoInput,celularInput,cpfInput,cepInput));

            
            

        }
    }
}
