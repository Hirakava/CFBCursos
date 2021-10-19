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
    }
}
