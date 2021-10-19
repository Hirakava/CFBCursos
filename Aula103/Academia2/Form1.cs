using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia2
{
    public partial class Frm_main : Form
    {
        public Frm_main()
        {
            InitializeComponent();
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
        }

        private void Frm_main_Load(object sender, EventArgs e)
        {

        }

        private void logInToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();

        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lb_acesso.Text = "0";
            lb_usuarioNome.Text = " - - - ";
            pb_ledLogado.Image = Properties.Resources.RED;
            Globais.nivel = 0;
            Globais.logado = false;
        }
    }
}
