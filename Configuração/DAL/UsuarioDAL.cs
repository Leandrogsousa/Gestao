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
                cmd.Parameters.AddWithValue("@Passoword", _usuario.Passoword);
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
                cn.Close();
            }
        }
        public Usuario BuscarPorNomeUsuario(string _Username)
        {
            Usuario usuario = new Usuario();
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            

            try
            {

                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT id_usuario, Nome, CPF, Email, Ativo FROM Usuario WHERE Username =@Username";
                cmd.Parameters.AddWithValue("@Username", _Username);
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        usuario = new Usuario();
                        usuario.id_usuario = Convert.ToInt32(rd["id_usuario"]);
                        usuario.Nome = rd["Nome"].ToString();
                        usuario.Username = rd["Username"].ToString();
                        usuario.Cpf = rd["Cpf"].ToString();
                        usuario.Email = rd["Email"].ToString();
                        usuario.Ativo = Convert.ToBoolean(rd["Ativo"]);

                    }
                    else
                    {
                        throw new Exception("Usuário não encontrado");
                    }
                }
                return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o usuario por nome: " + ex.Message);

            }
            finally
            {
                cn.Close();
            }

        }
        public List<Usuario> BuscarTodos()
        {
            List<Usuario> usuarios = new List<Usuario>();
            Usuario usuario;
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            
            try
            {

                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = "select id_usuario,Nome,Username,CPF,Email,Ativo from Usuario";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        usuario = new Usuario();
                        usuario.id_usuario = Convert.ToInt32(rd["id_usuario"]);
                        usuario.Nome = rd["Nome"].ToString();
                        usuario.Username = rd["Username"].ToString();
                        usuario.Cpf = rd["Cpf"].ToString();
                        usuario.Email = rd["Email"].ToString();
                        usuario.Ativo = Convert.ToBoolean(rd["Ativo"]);

                        usuarios.Add(usuario);
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos os usuarios: "+ ex.Message);
               
            }
            finally
            {
                cn.Close();
            }

            return usuarios;
        }
        public void Alterar(Usuario _alterarusuario)
        {
            ValidarDados(_alterarusuario);

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Alterar(_alterarusuario);
        }
        
        public void Excluir(int _id)
        {

        }

    }
}