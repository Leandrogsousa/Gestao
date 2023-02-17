using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    internal class GrupoUsuarioDAL
    {
        public void Inserir(Usuario _usuario)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"Insert Into GrupoUsario(NomeGrupo)
                                  Values (@NomeGrupo)";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("NomeGrupo", _usuario.NomeGrupo);

                cn.Open();
                cmd.ExecuteScalar();

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir no banco: " + ex.Message);
            }
            finally 
            { 
                cn.Close();
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
