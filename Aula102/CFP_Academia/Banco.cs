using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace CFP_Academia
{
    class Banco
    {
        private static SQLiteConnection conexao;

        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source=Z:\\DEV\\CFBC\\_DB\\bd_academia.db");
            conexao.Open();
            return conexao;
        }

        public static DataTable ObterTodosUsuarios()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd=ConexaoBanco().CreateCommand()) 
                {
                    cmd.CommandText = "SELECT * FROM tb_usuarios";
                    da = new SQLiteDataAdapter(cmd.CommandText,ConexaoBanco());
                    da.Fill(dt);
                    return dt;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }
    }
}
