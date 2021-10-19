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
    public partial class F_comboBox : Form
    {
        public F_comboBox()
        {
            InitializeComponent();
        }

        private void F_Combobox_Load(object sender, EventArgs e)
        {

        }

        private void btnmostrarSelecionados_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cb_transportes.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cb_transportes.Items.Clear();
        }

        private void btnresetarElementos_Click(object sender, EventArgs e)
        {
            cb_transportes.Items.Add("Carro");
            cb_transportes.Items.Add("Avião");
            cb_transportes.Items.Add("Navio");
            cb_transportes.Items.Add("Ônibus");
            cb_transportes.Items.Add("Trem");
        }

        private void cb_transportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_transporte.Text = cb_transportes.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string tct;
            if (cb_transportes.Text != "")
            {
                if (cb_transportes.FindString(txt_transporte.Text) < 0)                 
                cb_transportes.Items.Add(txt_transporte.Text);
            }
        }
    }
}
