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
    public partial class F_MaskedTextBox : Form
    {
        public F_MaskedTextBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (chbsomenteTexto.Checked)
            {
                mtbcpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            }
            else 
            {
                mtbcpf.TextMaskFormat = MaskFormat.IncludeLiterals;
            }
            string msg = mtbcpf.Text;
            MessageBox.Show(msg);
        }
    }
}
