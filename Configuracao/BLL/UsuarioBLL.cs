using DAL;
using Models;
using System.Data.SqlClient;

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
        public  Usuario BuscarPorNomeUsuario(string _nomeUsuario)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            Usuario usuario;

            if (String.IsNullOrEmpty(_nomeUsuario))
            {
                throw new Exception("Informe o nome de usuario.");
            }
            try
            {

                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = "select id_usuario,Nome, from Usuario where Nome =@Nome";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        usuario = new Usuario();
                        usuario.id_usuario = Convert.ToInt32(rd["id_usuario"]);
                        usuario.Nome = rd["Nome"].ToString();


                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o usuario: " + ex.Message);

            }
            finally
            {
                cn.Close();
            }


            return new Usuario();

    
            UsuarioDAL usuarioDAL =new UsuarioDAL();
            return usuarioDAL.BuscarPorNomeUsuario(_nomeUsuario);
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

                throw new Exception("Ocorreu um erro ao tentar buscar todos os usuarios: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }

            return usuarios;
        }
        public void Alterar(Usuario _usuario)
        {
            
        }
        public void Excluir(Usuario _usuario)
        {

        }

        public static  Usuario BuscarPorNomeUsuario()
        {
            Usuario usuario = new Usuario();
            return usuario;
        }
         
    }
}