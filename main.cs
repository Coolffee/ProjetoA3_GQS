using SistemaTicketChamada.Sistema.definicaoDeClasses;
using SistemaTicketChamada.Sistema.interfaceCommand;
using SistemaTicketChamada.SistemaTicket.cadastroLoginUsuario;

namespace SistemaTicketChamada.Sistema.factoryMethod.factoryMethodUsuario
{
    internal class main
    {
        static void Main(string[] args)/*segundo esse artigo, https://deskmanager.com.br/blog/sistema-de-tickets/, nele cita a questão de prioridades de tickets, depois dá uma olhada sobre*/
        {
       
            //aqui é que vai passar as informações do usuário seja cliente ou funcionário (é no factory method seria distiguir)
            //a ideia que toda vez que for logar seja cliente e em seguida o for fazer o login sendo funcionário seja capaz de ver status
            //

            Console.WriteLine("1 - Digite seu login: 2 - Cadastro");
            int choice =Convert.ToInt32( Console.ReadLine());

            switch (choice)
            {
                case 1:
                   
                    break;
                case 2:
                    
                    break;
            }
            
            
        }
    }
}
