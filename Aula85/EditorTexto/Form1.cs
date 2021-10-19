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
    }
}
