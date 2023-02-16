using BLL;
using Models;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleAppPrincipal
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            try
            {   
                Usuario usuario = new Usuario();
                UsuarioBLL usuarioBLL = new UsuarioBLL();

                Console.WriteLine("Digite [1] para cadastrar usuário ou [0] para sair");
                int X;
                X = Convert.ToInt32(Console.ReadLine());
                while (X != 0)
                {

                    Console.WriteLine("Informe o seu Nome:");
                    usuario.Nome = Console.ReadLine();
                    Console.WriteLine("Informe o seu usuário:");
                    usuario.Username = Console.ReadLine();
                    Console.WriteLine("Informe a sua senha:");
                    usuario.Passoword = Console.ReadLine();
                    Console.WriteLine("Informe o seu Email:");
                    usuario.Email = Console.ReadLine();
                    Console.WriteLine("Informe o seu CPF:");
                    usuario.Cpf = Console.ReadLine();
                    Console.WriteLine("O usuário está ativo [S] ou [N]");
                    usuario.Ativo = Console.ReadLine().ToUpper()=="S";

                    Console.WriteLine("\n\nDigite [1] para cadastrar mais um  usuário ou [0] para sair");
                    X = Convert.ToInt32(Console.ReadLine());
                }

                
                usuarioBLL.Inserir(usuario);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            
        }
    }
}