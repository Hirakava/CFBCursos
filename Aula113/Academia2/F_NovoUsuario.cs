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
    public partial class F_NovoUsuario : Form
    {
        public F_NovoUsuario()
        {
            InitializeComponent();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.nome = tb_nome.Text;
            usuario.username = tb_userName.Text;
            usuario.senha = tb_senha.Text;
            usuario.status = cb_status.Text;
            usuario.nivel = Convert.ToInt32(Math.Round(n_nivel.Value,0));
            Banco.NovoUsuario(usuario);

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            tb_nome.Clear();
            tb_userName.Clear();
            tb_senha.Clear();
            cb_status.Text = "";
            n_nivel.Value = 0;
            tb_nome.Focus();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            tb_nome.Clear();
            tb_userName.Clear();
            tb_senha.Clear();
            cb_status.Text = "";
            n_nivel.Value = 0;
            tb_nome.Focus();
        }
    }
}
