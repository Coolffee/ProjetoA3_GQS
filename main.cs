using SistemaTicketChamada.Sistema.definicaoDeClasses;
using SistemaTicketChamada.Sistema.interfaceCommand;
using SistemaTicketChamada.SistemaTicket.cadastroLoginUsuario;

namespace SistemaTicketChamada.Sistema.factoryMethod.factoryMethodUsuario
{
    internal class main
    {
        static void Main(string[] args)/*segundo esse artigo, https://deskmanager.com.br/blog/sistema-de-tickets/, nele cita a questão de prioridades de tickets, depois dá uma olhada sobre*/
        {
            //interfaceUsuario  inter = new interfaceUsuario();

            Console.WriteLine("1 - Digite seu login: 2 - Cadastro");
            int choice =Convert.ToInt32( Console.ReadLine());

            switch (choice)
            {
                case 1:
                    //achar uma forma de colocar aqui as informações usando o command
                    break;
                case 2:
                    
                    break;
            }
            
            
        }
    }
}
