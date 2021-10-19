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

        private void abreForm(int nivel, Form f)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= nivel)  //PROCEDIMENTOS
                {                   
                    f.ShowDialog();

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
            F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();
            abreForm(1,f_NovoUsuario);
        }

        private void gestãoDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
                        F_GestaoUsuarios f_GestaoUsuarios = new F_GestaoUsuarios();
                        abreForm(1, f_GestaoUsuarios);                
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

        private void horáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Horarios f_Horarios = new F_Horarios();
            abreForm(2, f_Horarios);
        }

        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GestaoProfessores f_GestaoProfessores = new F_GestaoProfessores();
            abreForm(2,f_GestaoProfessores);
        }

        private void turmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GestaoTurmas f_GestaoTurmas = new F_GestaoTurmas();
            abreForm(2,f_GestaoTurmas);
        }
    }
}