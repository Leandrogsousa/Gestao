using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class Conexao
    {
        public static string StringDeConexao 
        {
            get
            {
                return @"User ID=SA;Initial Catalog=Gestao;Data Source=.\SQLEXPRESS2019;Password=Senailab02";
            }
        }
    }
}
