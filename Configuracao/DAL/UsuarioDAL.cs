using Models;
using System.Data.SqlClient;

namespace DAL
{
    public class UsuarioDAL
    {
        public void Inserir(Usuario _usuario) 
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();    
                cmd.Connection = cn;
                cmd.CommandText = @"Insert Into Usuario(Nome,Username,CPF,Email,Passoword,Ativo)
                                  Values (@Nome,@Username,@CPF,@Email,@Passoword,@Ativo)";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", _usuario.Nome);
                cmd.Parameters.AddWithValue("@Username", _usuario.Username);
                cmd.Parameters.AddWithValue("@CPF", _usuario.Cpf);
                cmd.Parameters.AddWithValue("@Email", _usuario.Email);
                cmd.Parameters.AddWithValue("@Password", _usuario.Passoword);
                cmd.Parameters.AddWithValue("@Ativo", _usuario.Ativo);

                cn.Open();
                cmd.ExecuteScalar();

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir um Usuário no banco: " + ex.Message);
            }
            finally
            {
                cn.Open();
            }
        }
        public Usuario Buscar(string _nomeUsuario)
        {
            return new Usuario();
        }
        public void Alterar(Usuario _usuario)
        {

        }
        
        public void Excluir(int _id)
        {

        }

    }
}