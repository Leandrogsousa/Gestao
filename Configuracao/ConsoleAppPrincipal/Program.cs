using BLL;
using Models;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleAppPrincipal
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int opcao = 0;
            Console.WriteLine(@"Escolha uma opção:
                            \n\n1 - Cadastrar usuário
                            \n2 - Excluir usuário
                            \n3 - Buscar todos os usuários
                            \n4 - Buscar Por Nome Usuario");


            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    CadastrarUsuario();
                    break;
                case 2:
                    ExcluirUsuario();
                    break;
                case 3:
                    BuscarTodosOsUsuarios();
                    break;
                case 4:
                    BuscarPorNomeUsuario();
                    break;
                default:
                    break;
            }
        }

        private static void BuscarPorNomeUsuario()
        {

            UsuarioBLL usuarioBLL = new UsuarioBLL();
            Usuario usuarios = UsuarioBLL.BuscarPorNomeUsuario();

       
        }

        private static void ExcluirUsuario()
        {
            Console.WriteLine("Excluir usuário");
        }

        private static void BuscarTodosOsUsuarios()
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            List<Usuario> usuarios = usuarioBLL.BuscarTodos();

            foreach (Usuario item in usuarios)
            {
                Console.WriteLine("Id: " + item.id_usuario);
                Console.WriteLine("Nome de usuário: " + item.Username);
                Console.WriteLine("E-mail: " + item.Email);
            }

        }


        private static void CadastrarUsuario()
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
                        usuario.Ativo = Console.ReadLine().ToUpper() == "S";

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
