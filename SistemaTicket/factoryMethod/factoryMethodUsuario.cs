using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaTicketChamada.Sistema.definicaoDeClasses;
using SistemaTicketChamada.Sistema.interfaceCommand;
using SistemaTicketChamada.SistemaTicket.cadastroLoginUsuario;



namespace SistemaTicketChamada.Sistema.factoryMethod
{
    internal class FactoryMethodUsuario : interfaceUsuario
    {
        //private static int nextID = 1;
        public void Add(Usuario usuario)//cadastro do usuario
        {

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

            BDconnect.Instance.adicionarUsuario(new Usuario(/*nextID++,*/nomeInput, emailInput, enderecoInput, celularInput, cpfInput, cepInput));

            throw new NotImplementedException();
        }

        public void Delete(int id)
        {


            throw new NotImplementedException();
        }

        public Usuario GetById(int id)//Aqui será o login do usuario ou simplesmente consulta ao usuario, não sei
        {
            List<Usuario> loginList = BDconnect.Instance.consultLogin;
            //List<Usuario> usuarioInformacao = new List<Usuario>();

            bool usuarioEncontrado = false;

            while (usuarioEncontrado)
            {
                //Console.WriteLine("Digite os campos do login: nome");//percebe-se que a falta de colocar a senha para o usuario
                //string nomeLogin = Console.ReadLine();
                foreach (var index in loginList)
                {
                    if (id == index.Id)//pela lógica ao entrar no indice da lista que contem nome, email celular etc, e consiguir especificar ao que quero comparar
                    {
                        usuarioEncontrado = true;
                        Console.WriteLine($"Bem vindo {index.Nome}");/// muda a mensagem para achou o usuario do id + nome
                    }
                }
                if (!usuarioEncontrado)
                {
                    Console.WriteLine("Não foi encontrado o login do usuario");
                    break;
                }
            }


            throw new NotImplementedException();
        }

        public void Update(Usuario usuario)
        {




            throw new NotImplementedException();
        }
    }
}
