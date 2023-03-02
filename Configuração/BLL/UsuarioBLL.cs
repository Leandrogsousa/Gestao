using DAL;
using Models;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace BLL
{
    public class UsuarioBLL
    {
        public void Inserir(Usuario _usuario)
        {

            ValidarDados(_usuario);
            Usuario usuario = new Usuario();

            usuario = BuscarPorNomeUsuario(_usuario.Username);

            if (usuario.Username == _usuario.Username)
            {
                throw new Exception("O nome de usuário já existe!");
            }
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Inserir(_usuario);

        }
            private static void ValidarDados(Usuario _usuario)
            {


                if (_usuario.Username.Length <= 3 || _usuario.Username.Length >= 50)
                {
                    throw new Exception(" O nome de usuário deve ter mais de três caracteres.");
                }

                if (_usuario.Username.Contains(" "))
                {
                    throw new Exception("O nome não pode conter espaços.");
                }

                if (_usuario.Passoword.Contains("1234567"))
                {
                    throw new Exception("Não é permitido um número sequencial.");
                }

                if (_usuario.Passoword.Length < 7 || _usuario.Passoword.Length > 11)
                {
                    throw new Exception("A senha deve ter entre 7 e 11 caracteres.");
                }

            }

        public Usuario BuscarPorNomeUsuario(string _Username)
        {
            if (String.IsNullOrEmpty(_Username))
            {
                throw new Exception("Informe o nome do Usuário:");
            }

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.BuscarPorNomeUsuario(_Username);

        }

        public List<Usuario> BuscarTodos()
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.BuscarTodos();
        }
        public void Alterar(Usuario _alterarUsuario)
        {
            ValidarDados(_alterarUsuario);

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Alterar(_alterarUsuario);
        }
        public void Excluir(Usuario _usuario)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Excluir(_usuario);
        }
    }
}

