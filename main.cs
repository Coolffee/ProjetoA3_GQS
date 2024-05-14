using SistemaTicketChamada.SistemaTicket.cadastroLoginUsuario;

namespace SistemaTicketChamada.Sistema.factoryMethod.factoryMethodUsuario
{
    internal class main
    {
        static void Main(string[] args)/*segundo esse artigo, https://deskmanager.com.br/blog/sistema-de-tickets/, nele cita a questão de prioridades de tickets, depois dá uma olhada sobre*/
        {
            Console.WriteLine("1 - Digite seu login: 2 - Cadastro");
            int choice =Convert.ToInt32( Console.ReadLine());

            switch (choice)
            {
                case 1: loginUsuario.loginUsuarioBD();
                    break;
                case 2: cadastroUsuario.cadastroUsuarioDB();
                    break;
            }
            
            
        }
    }
}
