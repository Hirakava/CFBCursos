using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EditorTexto
{
    public partial class F_editorTexto : Form
    {
        StreamReader leitura = null;
        public F_editorTexto()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            Novo();
        }
        private void Novo()
        {
            richTextBox1.Clear();
            richTextBox1.Focus();
        }
        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Novo();
        }
        private void Salvar()
        {
            try
            {
                if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileStream arquivo = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter cfb_streamWriter = new StreamWriter(arquivo);
                    cfb_streamWriter.Flush();
                    cfb_streamWriter.BaseStream.Seek(0, SeekOrigin.Begin);
                    cfb_streamWriter.Write(this.richTextBox1.Text);
                    cfb_streamWriter.Flush();
                    cfb_streamWriter.Close();

                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Erro na gravação: " + ex.Message,"Erro ao Gravar",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salvar();
        }
        private void Abrir()
        {
            this.openFileDialog1.Title = "Abrir Arquivo";
            openFileDialog1.InitialDirectory = @"Z:\DEV\CFBC";
            openFileDialog1.Filter = "(*.LHH)|*.LHH" ;

            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    FileStream arquivo = new FileStream(openFileDialog1.FileName,FileMode.Open,FileAccess.Read);
                    StreamReader cfb_streamReader = new StreamReader(arquivo);
                    cfb_streamReader.BaseStream.Seek(0,SeekOrigin.Begin);
                    this.richTextBox1.Text = "";
                    string linha = cfb_streamReader.ReadLine();
                    while (linha != null)
                    {
                        this.richTextBox1.Text += linha + "\n";
                        linha = cfb_streamReader.ReadLine();
                    }
                    cfb_streamReader.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro de Leitura: " + ex.Message, "Erro ao Ler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_abrir_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void Copiar()
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }

        }
        private void Colar()
        {
            richTextBox1.Paste();
        }
        private void Negrito()
        {
            string nome_da_fonte = null;
            float tamanho_da_fonte = 0;
            bool negr = false;

            nome_da_fonte = richTextBox1.Font.Name;
            tamanho_da_fonte = richTextBox1.Font.Size;
            negr = richTextBox1.Font.Bold;

            if (negr == false)
            {
                richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Regular);
            }

        }
            private void Italico()
            {
                string nome_da_fonte = null;
                float tamanho_da_fonte = 0;
                bool ita = false;

                nome_da_fonte = richTextBox1.Font.Name;
                tamanho_da_fonte = richTextBox1.Font.Size;
                ita = richTextBox1.Font.Italic;

                if (ita == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic);
                }
                else
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic);
                }

            }

        private void Sublinhado()
        {
            string nome_da_fonte = null;
            float tamanho_da_fonte = 0;
            bool sub = false;

            nome_da_fonte = richTextBox1.Font.Name;
            tamanho_da_fonte = richTextBox1.Font.Size;
            sub = richTextBox1.Font.Underline;

            if (sub == false)
            {
                richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Underline);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Underline);
            }

        }




        private void btn_copiar_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Colar();
        }

        private void btn_colar_Click(object sender, EventArgs e)
        {
            Colar();
        }

        private void btn_negrito_Click(object sender, EventArgs e)
        {
            Negrito();
        }

        private void negritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Negrito();
        }

        private void itálicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Italico();
        }

        private void btn_italico_Click(object sender, EventArgs e)
        {
            Italico();
        }

        private void btn_sublinhado_Click(object sender, EventArgs e)
        {
            Sublinhado();
        }

        private void sublinhadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sublinhado();
        }
    }
}
