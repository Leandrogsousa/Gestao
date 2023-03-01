using BLL;
using DAL;
using Models;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleAppPrincipal
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                int prog;
                do
                {
                    Console.Clear();
                    Console.Title = "MENU";
                    Console.WriteLine("\tMENU PRINCIPAL");
                    Console.WriteLine("1 - Cadastrar");
                    Console.WriteLine("2 - Alterar");
                    Console.WriteLine("3 - Buscar");
                    Console.WriteLine("4 - Excluir");
                    Console.WriteLine("0 - Sair");
                    Console.Write("Escolha uma opção: ");
                    prog = Convert.ToInt32(Console.ReadLine());

                    switch (prog)
                    {
                        case 1:
                            Cadastrar();
                            break;
                        case 2:
                            Alterar();
                            break;
                        case 3:
                            Buscar();
                            break;
                        case 4:
                            Excluir();
                            break;
                        case 0:
                            break;
                        default:
                            Console.WriteLine("Opção Inválida");
                            Console.ReadLine();
                            break;
                    }
                } while (prog != 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void Cadastrar()
        {
            int opc;

            Console.Clear();
            Console.Title = "MENU";
            Console.WriteLine("\tMENU CADASTRO");
            Console.WriteLine("1 - Usuario");
            Console.WriteLine("2 - Grupo");
            Console.WriteLine("3 - Permissão");
            Console.WriteLine("0 - Retornar ao Menu Principal");
            Console.Write("Escolha uma opção: ");

            opc = Convert.ToInt32(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    CadastrarUsuario();
                    break;
                case 2:
                    CadastrarGrupo();
                    break;
                case 3:
                    CadastrarPermissao();
                    break;
                case 0:
                    break;

                default:
                    Console.WriteLine("Opção Inválida");
                    Console.ReadLine();
                    break;
            }
        }
        private static void Alterar()
        {
            int opc;

            Console.Clear();
            Console.Title = "MENU";
            Console.WriteLine("\tMENU ALTERAR");
            Console.WriteLine("1 - Usuario");
            Console.WriteLine("2 - Grupo");
            Console.WriteLine("3 - Permissão");
            Console.WriteLine("0 - Retornar ao Menu Principal");
            Console.Write("Escolha uma opção: ");

            opc = Convert.ToInt32(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    AlterarUsuario();
                    break;
                case 2:
                    AlterarGrupo();
                    break;
                case 3:
                    AlterarPermissao();
                    break;
                case 0:
                    break;

                default:
                    Console.WriteLine("Opção Inválida");
                    Console.ReadLine();
                    break;
            }
        }
        private static void Buscar()
        {
            int opc;

            Console.Clear();
            Console.Title = "MENU";
            Console.WriteLine("\tMENU BUSCAR");
            Console.WriteLine("1 - Usuario Por Nome");
            Console.WriteLine("2 - Todos os Usuários");
            Console.WriteLine("3 - Grupo");
            Console.WriteLine("4 - Permissão");
            Console.WriteLine("0 - Retornar ao Menu Principal");
            Console.Write("Escolha uma opção: ");

            opc = Convert.ToInt32(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    BuscarUsuarioPorNome();
                    break;
                case 2:
                    BuscarTodosOsUsuarios();
                    break;
                case 3:
                    BuscarGrupo();
                    break;
                case 4:
                    BuscarPorId();
                    break;
                case 0:
                    break;

                default:
                    Console.WriteLine("Opção Inválida");
                    Console.ReadLine();
                    break;
            }
        }
        private static void Excluir()
        {
            int opc;

            Console.Clear();
            Console.Title = "MENU";
            Console.WriteLine("\tMENU EXCLUIR");
            Console.WriteLine("1 - Usuario");
            Console.WriteLine("2 - Grupo");
            Console.WriteLine("3 - Permissão");
            Console.WriteLine("0 - Retornar ao Menu Principal");
            Console.Write("Escolha uma opção: ");

            opc = Convert.ToInt32(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    ExcluirUsuario();
                    break;
                case 2:
                    ExcluirGrupo();
                    break;
                case 3:
                    ExcluirPermissao();
                    break;
                case 0:
                    break;

                default:
                    Console.WriteLine("Opção Inválida");
                    Console.ReadLine();
                    break;
            }
        }
        private static void ExcluirUsuario()
        {
            int sn;
            Usuario usuario = new Usuario();
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            Console.Clear();
            do
            {
                Console.WriteLine("\nExcluir Usuario\n\n");
                Console.WriteLine("Informe o Id que deseja excluir: ");
                usuario.IDUsuario = Convert.ToInt32(Console.ReadLine());

                usuarioBLL.Excluir(usuario);
                Console.WriteLine("Exclusão realizada com sucesso. \n\nDeseja realizar uma nova Exclusao: [1] Sim [2] Não ");
                sn = Convert.ToInt32(Console.ReadLine());
            } while (sn != 2);
        }
        private static void ExcluirPermissao()
        {
            int sn;
            Permissao permissao = new Permissao();
            PermissaoBLL permissaoBLL = new PermissaoBLL();
            Console.Clear();
            do
            {
                Console.WriteLine("\nExcluir Permissão");
                Console.WriteLine("Informe o Id que deseja excluir: ");
                permissao.IdDescricao = Convert.ToInt32(Console.ReadLine());
                permissaoBLL.Excluir(permissao);
                Console.WriteLine("Permissão excluúida com sucesso. \n\nDeseja realizar uma nova Exclusão: [1] Sim [2] Não ");
                sn = Convert.ToInt32(Console.ReadLine());
            } while (sn != 2);
        }
        private static void ExcluirGrupo()
        {
            int sn;
            GrupoUsuario grupousuario = new GrupoUsuario();
            GrupoUsuarioBLL grupousuarioBLL = new GrupoUsuarioBLL();
            Console.Clear();
            do
            {
                Console.WriteLine("\nExcluir Grupo\n\n");
                Console.WriteLine("Informe o Id que deseja excluir: ");
                grupousuario.IdGrupoUsuario = Convert.ToInt32(Console.ReadLine());

                grupousuarioBLL.Excluir(grupousuario);
                Console.WriteLine("Exclusão realizada com sucesso. \n\nDeseja realizar uma nova Exclusao: [1] Sim [2] Não ");
                sn = Convert.ToInt32(Console.ReadLine());
            } while (sn != 2);
        }
        private static void AlterarUsuario()
        {
            int sn;
            Usuario usuario = new Usuario();
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            Console.Clear();

            do
            {
                Console.WriteLine("\nAlteração de Cadastro de Usuário\n\n");
                Console.WriteLine("Informe o Id do Usuário: ");
                usuario.id_usuario = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Informe seu Nome Completo: ");
                usuario.Nome = Console.ReadLine();
                Console.WriteLine("Informe o nome de acesso do Usuário: ");
                usuario.Username = Console.ReadLine();
                Console.WriteLine("Informe seu Email: ");
                usuario.Email = Console.ReadLine();
                Console.WriteLine("Informe o seu CPF: ");
                usuario.Cpf = Console.ReadLine();
                Console.WriteLine("Cadastre sua Senha: ");
                usuario.Passoword = Console.ReadLine();
                Console.WriteLine("O usuário estará ativo (S) ou (N)");
                usuario.Ativo = Console.ReadLine().ToLower() == "s";//armazendo expressao booleana

                //Console.Clear();
                //testar
                usuarioBLL.Alterar(usuario);
                Console.WriteLine("Alteração de cadastrado realizado com sucesso.\n\nDeseja alterar um novo usuário: [1] Sim [2] Não ");
                sn = Convert.ToInt32(Console.ReadLine());
            } while (sn != 2);
        }
        private static void AlterarGrupo()
        {
            int sn;
            GrupoUsuario grupoUsuario = new GrupoUsuario();
            GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
            Console.Clear();

            do
            {
                Console.WriteLine("\nAlterar Grupo\n\n");
                Console.WriteLine("Infomre o Id do Grupo: ");
                grupoUsuario.IdGrupoUsuario = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Informe o nome do grupo: ");
                grupoUsuario.NomeGrupo = Console.ReadLine();
                //Console.Clear();
                grupoUsuarioBLL.Alterar(grupoUsuario);
                Console.WriteLine("Grupo alterado com sucesso.\n\nDeseja alterar um outro grupo: [1] Sim [2] Nao ");
                sn = Convert.ToInt32(Console.ReadLine());
            } while (sn != 2);
        }
        private static void AlterarPermissao()
        {
            int sn;
            Permissao permissao = new Permissao();
            PermissaoBLL permissaoBLL = new PermissaoBLL();
            Console.Clear();
            do
            {
                Console.WriteLine("\nAltera Permissão\n\n");
                Console.WriteLine("Informe o Id Permissão que deseja alterar: ");
                permissao.id_descricao = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Informe o novo Nome da Descricao");
                permissao.Descricao = Console.ReadLine();

                permissaoBLL.Alterar(permissao);
                Console.WriteLine("Permissão alterada com sucesso.\n\nDeseja alterar uma nova Permissão: [1] Sim [2] Nao ");
                sn = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            } while (sn != 2);
        }
        private static void CadastrarPermissao()
        {
            int sn;
            Permissao permissao = new Permissao();
            PermissaoBLL permissaoBLL = new PermissaoBLL();
            Console.Clear();

            do
            {
                Console.WriteLine("\nCria Permissão\n\n");
                Console.WriteLine("Insira o nome da Permissão: ");
                permissao.Descricao = Console.ReadLine();
                permissaoBLL.Inserir(permissao);
                Console.WriteLine("Permissão criado com sucesso.\n\nDeseja criar uma nova Permissão: [1] Sim [2] Nao ");
                sn = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            } while (sn != 2);
        }
        private static void CadastrarGrupo()
        {
            int sn;
            GrupoUsuario grupoUsuario = new GrupoUsuario();
            GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
            Console.Clear();

            do
            {
                Console.WriteLine("\nCria Grupo\n\n");
                Console.WriteLine("Insira o nome do grupo: ");
                grupoUsuario.NomeGrupo = Console.ReadLine();
                //Console.Clear();
                grupoUsuarioBLL.Inserir(grupoUsuario);
                Console.WriteLine("Grupo criado com sucesso.\n\nDeseja criar um novo grupo: [1] Sim [2] Nao ");
                sn = Convert.ToInt32(Console.ReadLine());
            } while (sn != 2);
        }
        private static void CadastrarUsuario()
        {
            int sn;
            Usuario usuario = new Usuario();
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            Console.Clear();
            do
            {
                Console.WriteLine("\nSistema de Cadastro\n\n");
                Console.WriteLine("Informe seu Nome Completo: ");
                usuario.Nome = Console.ReadLine();
                Console.WriteLine("Informe o nome de acesso do Usuário: ");
                usuario.Username = Console.ReadLine();
                Console.WriteLine("Informe seu Email: ");
                usuario.Email = Console.ReadLine();
                Console.WriteLine("Informe o seu CPF: ");
                usuario.Cpf = Console.ReadLine();
                Console.WriteLine("Cadastre sua Senha: ");
                usuario.Passoword = Console.ReadLine();
                Console.WriteLine("O usuário estará ativo (S) ou (N)");
                usuario.Ativo = Console.ReadLine().ToLower() == "s";//armazendo expressao booleana

                Console.Clear();

                usuarioBLL.Inserir(usuario);
                Console.WriteLine("Usuário cadastrado com sucesso.\n\nDeseja cadastrar um novo usuário: [1] Sim [2] Não ");
                sn = Convert.ToInt32(Console.ReadLine());
            } while (sn != 2);
        }
        private static void BuscarUsuarioPorNome()
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            Console.WriteLine("Informe o nome do usuário: ");
            string nomeUsuario = Console.ReadLine();
            Usuario usuario = usuarioBLL.BuscarPorNomeUsuario(nomeUsuario);
            Console.WriteLine("IDUsuario: " + usuario.id_usuario);
            Console.WriteLine("Nome: " + usuario.Nome);
            Console.WriteLine("NomeUsuario: " + usuario.Username);
            Console.WriteLine("CPF: " + usuario.Cpf);
            Console.WriteLine("Email: " + usuario.Email);
            Console.WriteLine("\n\nPressione ENTER para continuar.");
            Console.ReadLine();
            //throw new NotImplementedException();
        }
        private static void BuscarTodosOsUsuarios()
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            List<Usuario> usuarios = usuarioBLL.BuscarTodos();

            foreach (Usuario item in usuarios)
            {
                Console.WriteLine("IDUsuario: " + item.id_usuario);
                Console.WriteLine("Nome: " + item.Nome);
                Console.WriteLine("Nome do Usuario: " + item.Username);
            }

            Console.WriteLine("\n\nPressione ENTER para continuar.");
            Console.ReadLine();
            /*for (int i = 0; i < usuarios.Count; i++)
            {
                Console.WriteLine(usuarios[i]);
            }*/
        }
        private static void BuscarGrupo()
        {
            int sn;
            GrupoUsuario _idgrupoUsuario = new GrupoUsuario();
            GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
            Console.Clear();

            do
            {
                Console.WriteLine("\nListar Grupo\n\n");
                Console.WriteLine("Insira o Id do grupo: ");
                _idgrupoUsuario.id_grupousuario = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("");
                // _idgrupoUsuario.NomeGrupo = Console.ReadLine();
                //Console.Clear();

                GrupoUsuario grupoUsuario = grupoUsuarioBLL.Buscar(_idgrupoUsuario);
                Console.WriteLine("IdGrupoUsuario: " + grupoUsuario.IdGrupoUsuario);
                Console.WriteLine("NomeGrupo: " + grupoUsuario.NomeGrupo);

                Console.WriteLine("Grupo listado com sucesso.\n\nDeseja continuar listando: [1] Sim [2] Nao ");
                sn = Convert.ToInt32(Console.ReadLine());
            } while (sn != 2);
            //throw new NotImplementedException();
        }
        private static void BuscarPorId()
        {
            PermissaoBLL permissaoBLL = new PermissaoBLL();
            Console.WriteLine("Informe o Id da Permissão: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Permissao permissao = permissaoBLL.BuscarPorId(id);
            Console.WriteLine("IdDescricao: " + permissao.IdDescricao);
            Console.WriteLine("Descricao: " + permissao.Descricao);
            Console.WriteLine("\n\nPressione ENTER para continuar.");
            Console.ReadLine();
        }

    }
}
