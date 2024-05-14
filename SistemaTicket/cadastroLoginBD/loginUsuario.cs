using SistemaTicketChamada.Sistema.definicaoDeClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTicketChamada.SistemaTicket.cadastroLoginUsuario
{
    internal class loginUsuario
    {
        
        public static void loginUsuarioBD()
        {
            List<Usuario> loginList = DBconnect.Instance.consultLogin;
            bool usuarioEncontrado = false;

            while (usuarioEncontrado)
            {
                Console.WriteLine("Digite os campos do login: nome");//percebe-se que a falta de colocar a senha para o usuario
                string nomeLogin = Console.ReadLine();
                foreach (var index in loginList)
                {
                    if (nomeLogin == index.Nome)//pela lógica ao entrar no indice da lista que contem nome, email celular etc, e consiguir especificar ao que quero comparar
                    {
                        usuarioEncontrado = true;
                        Console.WriteLine($"Bem vindo {nomeLogin}");
                    }
                }
                if (!usuarioEncontrado)
                {
                    Console.WriteLine("Não foi encontrado o login do usuario");
                }
            }
            
        }
    }
}
