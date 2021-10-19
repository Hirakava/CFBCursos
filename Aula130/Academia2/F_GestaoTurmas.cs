using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace Academia2
{

    public partial class F_GestaoTurmas : Form
    {
        string idSelecionado;
        int modo = 0; //0=padrao 1=edicao 2=insercao
        string vqueryDGV;

        public F_GestaoTurmas()
        {
            InitializeComponent();
        }

        private void F_GestaoTurmas_Load(object sender, EventArgs e)
        {
            string vqueryDGV = @"
                  SELECT 
                    tbt.N_IDTURMA as 'ID', 
                    tbt.T_DSCTURMA as 'Turma',
                    tbh.T_DSCHORARIO as 'Horário'
                  FROM
                    tb_turmas as tbt
                  INNER JOIN
                    tb_horarios as tbh on tbh.N_IDHORARIO=tbh.N_IDHORARIO
            ";
            dgv_turmas.DataSource = Banco.dql(vqueryDGV);
            dgv_turmas.Columns[0].Width = 40;
            dgv_turmas.Columns[1].Width = 120;
            dgv_turmas.Columns[2].Width = 85;

            string vqueryProfessores = @"
                SELECT
                    N_IDPROFESSOR,
                    T_NOMEPROFESSOR
                FROM
                    tb_professores
                ORDER BY
                    N_IDPROFESSOR
            ";

            cb_professor.Items.Clear();
            cb_professor.DataSource = Banco.dql(vqueryProfessores);
            cb_professor.DisplayMember = "T_NOMEPROFESSOR";
            cb_professor.ValueMember = "N_IDPROFESSOR";

            //Popular combox status (Ativa=A, Paralisa=P, Cancelada=C)

            Dictionary<string, string> st = new Dictionary<string, string>();
            st.Add("A", "Ativa");
            st.Add("P", "Paralisada");
            st.Add("C", "Cancelada");
            cb_status.Items.Clear();
            cb_status.DataSource = new BindingSource(st, null);
            cb_status.DisplayMember = "Value";
            cb_status.ValueMember = "Key";

            //Popular Combobox Horários

            string vqueryHorarios = @"
                SELECT 
                    *
                FROM
                    tb_horarios
                ORDER BY
                    N_IDHORARIO                  
            ";
            cb_horarios.Items.Clear();
            cb_horarios.DataSource = Banco.dql(vqueryHorarios);
            cb_horarios.DisplayMember = "T_DSCHORARIO";
            cb_horarios.ValueMember = "N_IDHORARIO";

        }

        private void dgv_turmas_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                modo = 0;
                idSelecionado = dgv_turmas.Rows[dgv_turmas.SelectedRows[0].Index].Cells[0].Value.ToString();
                string vqueryCampos = @"
                    SELECT 
                        T_DSCTURMA,
                        N_IDPROFESSOR,
                        N_IDHORARIO,
                        N_MAXALUNOS,
                        T_STATUS
                    FROM
                        tb_turmas
                    WHERE
                        N_IDTURMA=" + idSelecionado;
                DataTable dt = Banco.dql(vqueryCampos);
                tb_dscTurma.Text = dt.Rows[0].Field<string>("T_DSCTURMA");
                cb_professor.SelectedValue = dt.Rows[0].Field<Int64>("N_IDPROFESSOR").ToString();
                n_maxAlunos.Value = dt.Rows[0].Field<Int64>("N_MAXALUNOS");
                cb_status.SelectedValue = dt.Rows[0].Field<string>("T_STATUS");
                cb_horarios.SelectedValue = dt.Rows[0].Field<Int64>("N_IDHORARIO");

                //calculo de vagas


                tb_vagas.Text = calcVagas();
                               
            }
        }

        private string calcVagas()
        {
            string queryVagas = String.Format(@"
                    SELECT 
                        count(N_IDALUNO) as 'contVagas'
                    FROM
                        tb_alunos
                    WHERE
                        T_STATUS='A' and N_IDTURMA={0}", idSelecionado);
            DataTable dt = Banco.dql(queryVagas);
            int vagas = Int32.Parse(Math.Round(n_maxAlunos.Value, 0).ToString());
            vagas -= Int32.Parse(dt.Rows[0].Field<Int64>("contVagas").ToString());
            return vagas.ToString();
        }

        private void btn_novaTurma_Click(object sender, EventArgs e)
        {
            tb_dscTurma.Clear();
            cb_professor.SelectedIndex = -1;
            n_maxAlunos.Value = 0;
            cb_status.SelectedIndex = -1;
            cb_horarios.SelectedIndex = -1;
            tb_dscTurma.Focus();
            modo = 2;
        }
        private void btn_salvaEdicoes_Click(object sender, EventArgs e)
        {
            if (modo != 0)
            {
                string queryTurma="";
                string msg = "";

                if (modo == 1)
                {
                    msg = "Dados Alterados";
                    queryTurma = String.Format(@"
                    UPDATE
                        tb_turmas
                    SET
                        T_DSCTURMA='{0}',
                        N_IDPROFESSOR={1},
                        N_IDHORARIO={2},
                        N_MAXALUNOS={3},
                        T_STATUS='{4}'
                    HERE
                        N_IDTURMA={5}", tb_dscTurma.Text, cb_professor.SelectedValue, cb_horarios.SelectedValue, Int32.Parse(Math.Round(n_maxAlunos.Value, 0).ToString()), cb_status.SelectedValue, idSelecionado);

                }
                else
                {
                    msg = "Nova turma Inserida";
                    queryTurma = String.Format(@"
                        INSERT INTO
                            tb_turmas
                             (T_DSCTURMA,N_IDPROFESSOR,N_IDHORARIO,N_MAXALUNOS,T_STATUS)
                                VALUES('{0}',{1},{2},'{3}','{4}')",tb_dscTurma.Text,cb_professor.SelectedValue,cb_horarios.SelectedValue, Int32.Parse(Math.Round(n_maxAlunos.Value, 0).ToString()),cb_status.SelectedValue);
                                                          
                }
                int linha = dgv_turmas.SelectedRows[0].Index;

                Banco.dml(queryTurma);
                if (modo == 1)
                {
                    dgv_turmas[1, linha].Value = tb_dscTurma.Text;
                    dgv_turmas[2, linha].Value = cb_horarios.Text;
                    tb_vagas.Text = calcVagas();
                }
                else
                {
                    dgv_turmas.DataSource = Banco.dql(vqueryDGV);
                }
                MessageBox.Show("Dados Gravados");
            }           
        }
        private void btn_excluirTurma_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma Exclusão", "Excluir?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string queryExcluirTurma = String.Format(@"
                   DELETE
                   FROM
                        tb_turmas
                    WHERE
                        N_IDTURMA={0}", idSelecionado);
                Banco.dml(queryExcluirTurma);
                dgv_turmas.Rows.Remove(dgv_turmas.CurrentRow);
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tb_dscTurma_TextChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;
            }
           
        }

        private void cb_professor_SelectedIndexChanged(object sender, EventArgs e)
        {
            modo = 1;
        }

        private void n_maxAlunos_ValueChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;
            }
            calcVagas();
        }

        private void cb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;
            }
        }

        private void cb_horarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            modo = 1;
        }

        private void btn_imprimirTurma_Click(object sender, EventArgs e)
        {
            string nomeArquivo = Globais.caminho + @"\_FILE\turmas.pdf";
            FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);
            Document doc = new Document(PageSize.A4);
            PdfWriter escritorPDF = PdfWriter.GetInstance(doc, arquivoPDF);

            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Globais.caminho+ @"\logocfb.png");
            logo.ScaleToFit(140f,120f);
            logo.Alignment=Element.ALIGN_LEFT;
            //logo.SetAbsolutePosition(100f,700f); //X, -Y
            
            string dados = "";
            Paragraph paragrafo1 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL,14,(int)System.Drawing.FontStyle.Bold));  /// nao terminado.
            paragrafo1.Alignment = Element.ALIGN_CENTER;
            paragrafo1.Add("Relatorio de Turmas \n\n");                        
            //paragrafo1.Add("CFB Cursos");

            
            //paragrafo1.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL,14,(int)System.Drawing.FontStyle.Italic);///NAO TERMINADO
            //paragrafo1.Add("Cursor de C#");
            //string texto = "youtube.com/cfbcursos";
            //paragrafo1.Add(texto);

            Paragraph paragrafo2 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Bold));  /// nao terminado.
            paragrafo2.Alignment = Element.ALIGN_CENTER;
            paragrafo2.Add("CFB Cursos - Curso de C#");

            //texto = "Este é o Texto do Segundo Paragrafo";
            //paragrafo2.Add(texto);

            PdfPTable tabela = new PdfPTable(3);//3Colunas
            tabela.DefaultCell.FixedHeight = 20;

            //PdfPCell celula1 = new PdfPCell(new Phrase("tabela de Preços"));
            //celula1.Colspan = 3;//linha 1 mesclada
            //celula1.Rotation = 90;
            //tabela.AddCell(celula1);

            tabela.AddCell("ID Turma");
            tabela.AddCell("Turma");
            tabela.AddCell("Horário");

            //tabela.AddCell("01");
            //tabela.AddCell("Mouse");
            //tabela.AddCell("25,00");

            //tabela.AddCell("02");
            //tabela.AddCell("Teclado");
            //tabela.AddCell("65,00");

            //PdfPCell celula2 = new PdfPCell(new Phrase("tabela de Preços"));

            //celula.Phrase.Add("Tabela de Preço");
            //celula.Colspan = 3;//Linha 1 mesclada
            //celula.FixedHeight = 40;
            //celula.HorizontalAlignment = Element.ALIGN_CENTER;
            //celula.VerticalAlignment = Element.ALIGN_MIDDLE;
            //tabela.AddCell(celula);

            DataTable dtTurmas = Banco.dql(vqueryDGV);
            for (int i = 0; i < dtTurmas.Rows.Count; i++)
            {
                tabela.AddCell(dtTurmas.Rows[i].Field<Int64>("ID").ToString());
                tabela.AddCell(dtTurmas.Rows[i].Field<string>("Turma"));
                tabela.AddCell(dtTurmas.Rows[i].Field<string>("Horário"));
            }            
            
            doc.Open();
            doc.Add(logo);
            doc.Add(paragrafo1);
            doc.Add(tabela);
            doc.Add(paragrafo2);
            //doc.Add(tabela);
            doc.Close();

            DialogResult res = MessageBox.Show("Deseja abrir o Relatório?","Relatório",MessageBoxButtons.YesNo);  ///
            if (res == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(Globais.caminho + @"\_FILE\turma.pdf");
            }
        }
    }
}
