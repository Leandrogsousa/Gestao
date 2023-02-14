using DAL;
using Models;

namespace BLL
{
    public class UsuarioBLL
    {
        public void Inserir(Usuario _usuario)
        {
            if (_usuario.Username.Length <=3 || _usuario.Username.Length >= 50)
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


            //TODO: Validar se a senha é 1234.


            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Inserir(_usuario);
        }
        public  Usuario Buscar(string _nomeUsuario)
        {
            throw new NotImplementedException();
        }
        public void Alterar(Usuario _usuario)
        {
            
        }
        public void Excluir(Usuario _usuario)
        {

        }
    }
}