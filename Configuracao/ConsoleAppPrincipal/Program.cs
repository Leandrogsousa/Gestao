using BLL;
using Models;

namespace ConsoleAppPrincipal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            Usuario usuario = new Usuario();
            usuario.Nome = "Leandro Sousa";
            usuario.Username = "leandro";
            usuario.Ativo = true;
            usuario.Email = "Leandro.g.sousa@senai.com";
            usuario.Cpf = "954.151.16.14";
            usuario.Passoword = "123";
            usuarioBLL.Inserir(usuario);
        }
    }
}