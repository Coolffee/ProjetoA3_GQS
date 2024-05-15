using SistemaTicketChamada.Sistema.definicaoDeClasses;
using SistemaTicketChamada.Sistema.interfaceCommand;
using SistemaTicketChamada.SistemaTicket.cadastroLoginUsuario;

namespace SistemaTicketChamada.Sistema.factoryMethod.factoryMethodUsuario
{
    internal class main
    {
        static void Main(string[] args)/*segundo esse artigo, https://deskmanager.com.br/blog/sistema-de-tickets/, nele cita a questão de prioridades de tickets, depois dá uma olhada sobre*/
        {
            interfaceUsuario inter= new FactoryMethodUsuario();// não sei se a lógica está certa mas parou de mostra o erro: Erro CS0144	Não é possível criar uma instância do tipo abstrato ou da interface 'interfaceUsuario'	SistemaTicketChamada


            Console.WriteLine("1 - Digite seu login: 2 - Cadastro");
            int choice =Convert.ToInt32( Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Digite os campos do login: id");
                    int idLogin = Convert.ToInt32(Console.ReadLine());
                    inter.GetById(idLogin); //achar uma forma de fazer com que entre na função
                    break;
                case 2:
                    Console.WriteLine("Digite as informações");

                    Console.WriteLine("Nome");
                    string nomeInput = Console.ReadLine();
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

                    inter.Add(nomeInput, emailInput, enderecoInput, celularInput, cpfInput, cepInput);
                    break;
            }
            
            
        }
    }
}
