using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia2
{
    class Globais
    {
        public static string versao = "1.0";
        public static Boolean logado = false;
        public static int nivel = 0;  // 1 - Basico 2 - Gerente 3 - Master
        public static string caminho = System.Environment.CurrentDirectory;
        public static string nomeBanco = "bd_academia.db";
        public static string caminhoBanco = caminho + @"Z:\DEV\CFBC\_DB\";
        public static string caminhoFotos= caminho + @"Z:\DEV\CFBC\_IMG";
    }
}
