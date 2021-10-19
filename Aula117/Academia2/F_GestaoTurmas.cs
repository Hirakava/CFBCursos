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

    public partial class F_GestaoTurmas : Form
    {
        string idSelecionado;
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
            dgv_turmas.DataSource = Banco.consulta(vqueryDGV);
            dgv_turmas.Columns[0].Width = 40;
            dgv_turmas.Columns[1].Width = 120;
            dgv_turmas.Columns[2].Width = 85;

            string vqueryProfessores = @"
                SELECT
                    N_IDPROFESSOR,
                    T_NOMEPROFESSOR,
                FROM
                    tb_professores
                ORDER BY
                    N_IDPROFESSOR
            ";
            
            cb_professor.Items.Clear();
            cb_professor.DataSource = Banco.consulta(vqueryProfessores);
            cb_professor.DisplayMember = "T_NOMEPROFESSOR";
            cb_professor.ValueMember = "N_IDPROFESSOR";

            //Popular combox status (Ativa=A, Paralisa=P, Cancelada=C)

            Dictionary<string, string> st = new Dictionary<string, string>();
            st.Add("A","Ativa");
            st.Add("P","Paralisada");
            st.Add("C","Cancelada");
            cb_status.Items.Clear();
            cb_status.DataSource = new BindingSource(st,null);
            cb_status.DisplayMember = "Value";
            cb_status.ValueMember = "Key";

            //Popular Combobox Horários

            string vqueryHorarios = @"
                SELECT 
                    *
                FROM
                    tb_horarios
                ORDER BY
                    N_IDPROFESSOR                  
            ";
            cb_horarios.Items.Clear();
            cb_horarios.DataSource = Banco.consulta(vqueryHorarios);
            cb_horarios.DisplayMember = "T_DSCHORARIO";
            cb_horarios.ValueMember = "N_IDHORARIO";          
                           
        }

        private void dgv_turmas_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv=(DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
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
                        N_IDTURMA="+ idSelecionado;
                DataTable dt = Banco.consulta(vqueryCampos);
                tb_dscTurma.Text = dt.Rows[0].Field<string>("T_DSCTURMA");
                cb_professor.SelectedValue = dt.Rows[0].Field<Int64>("N_IDPROFESSOR").ToString();
                n_maxAlunos.Value = dt.Rows[0].Field<Int64>("N_MAXALUNOS");
                cb_status.SelectedValue = dt.Rows[0].Field<string>("T_STATUS");
                cb_horarios.SelectedValue = dt.Rows[0].Field<Int64>("N_IDHORARIO");
            }
        }

        private void btn_novaTurma_Click(object sender, EventArgs e)
        {
            tb_dscTurma.Clear();
            cb_professor.SelectedIndex = -1;
            n_maxAlunos.Value = 0;
            cb_status.SelectedIndex = -1;
            cb_horarios.SelectedIndex = -1;                   
        }      
        private void btn_salvaEdicoes_Click(object sender, EventArgs e)
        {
            int linha = dgv_turmas.SelectedRows[0].Index;
            string queryAtualizarTurma = String.Format(@"
                UPDATE
                    tb_turmas
                SET
                    T_DSCTURMA='{0}',
                    N_IDPROFESSOR={1},
                    N_IDHORARIO={2},
                    N_MAXALUNOS={3},
                    T_STATUS='{4}'
                WHERE
                    N_IDTURMA={5}",tb_dscTurma.Text,cb_professor.SelectedValue,cb_horarios.SelectedValue,Int32.Parse(Math.Round(n_maxAlunos.Value,0).ToString()),cb_status.SelectedValue,idSelecionado);

            Banco.consulta(queryAtualizarTurma);
            dgv_turmas[1, linha].Value = tb_dscTurma.Text;
            dgv_turmas[2, linha].Value = cb_horarios.Text;
            MessageBox.Show("Dados Gravados");
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
                Banco.consulta(queryExcluirTurma);
                dgv_turmas.Rows.Remove(dgv_turmas.CurrentRow);
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
