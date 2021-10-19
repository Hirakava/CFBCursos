using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Academia2
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
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM tb_usuarios";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                ConexaoBanco().Close();
                throw ex;
            }

        }

        public static DataTable consulta(string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;
                }

            }
            catch (Exception ex)
            {
                ConexaoBanco().Close();
                throw ex;
            }
        }

        //FUNCOES DO FORM F_USUARIO

        public static void NovoUsuario(Usuario u) 
        {
            if (existeUsername(u)) 
            {
                MessageBox.Show("Username já existe");
                return;
            }
            try
            {
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "INSERT INTO tb_usuarios (T_NOMEUSUARIO, T_USERNAME, T_SENHAUSUARIO,T_STATUSUSUARIO, N_NIVELUSUARIO) VALUES (@nome,@username,@senha,@status,@nivel )";
                cmd.Parameters.AddWithValue("@nome", u.nome);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@senha", u.senha);
                cmd.Parameters.AddWithValue("@status", u.status);
                cmd.Parameters.AddWithValue("@nivel", u.nivel);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Novo usuário inserido");
                ConexaoBanco().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ao gravar novo usuario");
                ConexaoBanco().Close();
            }
        }
        //FIM FO FORM F_USUARIO

        public static bool existeUsername(Usuario u)
        {
            bool res;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var cmd = ConexaoBanco().CreateCommand();
            cmd.CommandText = "SELECT * T_USERNAME FROM tb_usuarios WHERE T_USERNAME='"+u.username+"'";
            da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                res = false;
            }
            return res;            
        }
    }
}
