using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class F_Principal : Form
    {
        public int num;
        public F_Principal()
        {
            InitializeComponent();
            num = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            if (tb_veiculo.Text == "") {
                MessageBox.Show("Digie um Veiculo");
                tb_veiculo.Focus();
                return;
            }
            tb_listaveiculos.Text += tb_veiculo.Text + ", ";
            //tb_listaVeiculos.Text=tb_listaVeiculos.Text + tb_veiculo.Text;

            tb_veiculo.Clear();
            tb_veiculo.Focus();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            tb_listaveiculos.Clear();
            tb_veiculo.Clear();
            tb_veiculo.Focus();

        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            F_Veiculos f_Veiculos = new F_Veiculos(tb_listaveiculos.Text,this);
            f_Veiculos.ShowDialog();
        }

        private void btn_valNum_Click(object sender, EventArgs e)
        {
            MessageBox.Show(num.ToString());
        }

        private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckBox f_CheckBox = new F_CheckBox();
            f_CheckBox.ShowDialog();
        }

        private void checkedListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckedListBox f_CheckedListBox = new F_CheckedListBox();
            f_CheckedListBox.ShowDialog();
        }
    }
}
