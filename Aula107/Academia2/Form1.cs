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

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 2)  //PROCEDIMENTOS
                {

                }
                else
                {
                    MessageBox.Show("Acesso não permitido.");
                }
            }
            else
            {
                MessageBox.Show("É necessário ter usuário logado.");
            }
        }

        private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 1)  //PROCEDIMENTOS
                {
                    F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();
                    f_NovoUsuario.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Acesso não permitido.");
                }
            }
            else
            {
                MessageBox.Show("É necessário ter usuário logado.");

            }
        }

        private void gestãoDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 1)  //PROCEDIMENTOS
                {
                    F_GestaoUsuarios f_GestaoUsuarios = new F_GestaoUsuarios();
                    f_GestaoUsuarios.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Acesso não permitido.");
                }
            }
            else
            {
                MessageBox.Show("É necessário ter usuário logado.");

            }
        }

        private void novoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
            }
            else
            {
                MessageBox.Show("É necessário ter usuário logado.");
            }
        }
    }
}