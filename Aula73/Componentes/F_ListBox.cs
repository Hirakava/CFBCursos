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
    public partial class F_ListBox : Form
    {
        List<string> carros = new List<string>();
        public F_ListBox()
        {
            InitializeComponent();
            carros.Add("HRV");
            carros.Add("Golf");
            carros.Add("Focus");

            lb_carros.DataSource = carros;
        }

        private void atualizaLB(ListBox lb, List<string>l)
        {
            lb_carros.DataSource = null;
            lb_carros.DataSource = l;
        }

        private void F_ListBox_Load(object sender, EventArgs e)
        {
        }
        private void btnadicionar_Click(object sender, EventArgs e)
        {
            if (tb_carro.Text == "")
            {
                MessageBox.Show("Digite um Carro");
                tb_carro.Focus();
            }
            else
            {
                carros.Add(tb_carro.Text);
                tb_carro.Clear();
                atualizaLB(lb_carros,carros);
            }
        }

        private void btnremover_Click(object sender, EventArgs e)
        {
            carros.RemoveAt(lb_carros.SelectedIndex);
            atualizaLB(lb_carros, carros);
        }

        private void btnobter_Click(object sender, EventArgs e)
        {
            tb_carro.Text = carros[lb_carros.SelectedIndex];
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            carros.Clear();
            atualizaLB(lb_carros, carros);
        }
    }
}
