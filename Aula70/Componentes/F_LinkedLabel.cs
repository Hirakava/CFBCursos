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
    public partial class F_LinkedLabel : Form
    {
        public F_LinkedLabel()
        {
            InitializeComponent();
            lk_multiplosLinks.Links.Add(0,6,"www.google.com.br");
            lk_multiplosLinks.Links.Add(9,5,"www.youtube.com/cfbcursos");
            lk_multiplosLinks.Links.Add(17,7,"www.youtube.com");

            lk_multiplosLinks.Links[2].Enabled = false;
        }

        private void F_LinkedLabel_Load(object sender, EventArgs e)
        {

        }

        private void lk_canal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://youtube.com/cfbcursos?nome="+tb_nome.Text);
            LinkLabel ll=(LinkLabel)sender;
            ll.LinkVisited = true;
        }

        private void lk_calculadora_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void lk_multiplosLinks_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
            e.Link.Visited = true;
        }
    }
}
