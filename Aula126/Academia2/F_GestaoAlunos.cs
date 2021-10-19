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
    public partial class F_GestaoAlunos : Form
    {
        string vqueryDGV ="";
        string turmaAtual="";
        string idSelecionado = "";
        string turma = "";
        int linha = 0;
        public F_GestaoAlunos()
        {
            InitializeComponent();
        }

        private void F_GestaoAlunos_Load(object sender, EventArgs e)
        {
            vqueryDGV = @"
                SELECT 
                    N_IDALUNO as 'ID',
                    T_NOMEALUNO as 'Aluno'
                FROM
                    tb_alunos
            ";
            dgv_alunos.DataSource = Banco.consulta(vqueryDGV);  //Banco.dql
            dgv_alunos.Columns[0].Width = 40;
            dgv_alunos.Columns[1].Width = 120;


            tb_nome.Text = dgv_alunos.Rows[dgv_alunos.SelectedRows[0].Index].Cells[1].Value.ToString();  

            string vqueryTurmas = @"
            SELECT 
                N_IDTURMA,
                    ('Vagas: ' || (
                                  (N_MAXALUNOS)-(
                                                    SELECT
                                                        count(tba.N_IDALUNO)
                                                    FROM
                                                        tb_alunos as tba
                                                    WHERE
                                                         tba.T_STATUS='A' and tba.N_IDTURMA=N_IDTURMA
                                                    )
                                   ) || ' / Turma: ' || T_DSCTURMA
                     )as 'Turma'
                FROM
                    tb_turmas
                ORDER BY
                    N_IDTURMA
            ";
            cb_turmas.Items.Clear();
            cb_turmas.DataSource = Banco.consulta(vqueryTurmas); //Banco.dql
            cb_turmas.DisplayMember = "Turma";
            cb_turmas.ValueMember = "N_IDTURMA";

            //popular Combobox status (Ativo=A, Bloqueado=B, Cancelado=C)
            Dictionary<string, string> status = new Dictionary<string, string>();
            status.Add("A","Ativo");
            status.Add("B","Bloqueado");
            status.Add("C", "Cancelado");
            cb_status.DataSource = new BindingSource(status,null);
            cb_status.DisplayMember = "Value";
            cb_status.ValueMember = "Key";

            turma = cb_turmas.Text;
            turma = cb_turmas.Text;
            idSelecionado = dgv_alunos.Rows[0].Cells[0].Value.ToString();
        }

        private void btn_salvarEdicoes_Click(object sender, EventArgs e)
        {
            turma = cb_turmas.Text;
            if (turmaAtual != turma)
            {
                string[] t = turma.Split(' ');
                int vagas = int.Parse(t[1]);
                if (vagas < 1)
                {
                    MessageBox.Show("Não há vagas na turma selecionada, selecione outra");
                    cb_turmas.Focus();
                    return;
                }
                linha = dgv_alunos.SelectedRows[0].Index;
                string queryAtualizarAluno = String.Format(@"
                    UPDATE
                        tb_alunos
                    SET
                        T_NOMEALUNO='{0}',
                        T_TELEFONE='{1}',
                        T_STATUS='{2}',
                        N_IDTURMA='{3}',
                    WHERE
                        N_IDALUNO={4}",
                tb_nome.Text, mtb_telefone.Text, cb_status.SelectedValue, cb_turmas.SelectedItem;
                Banco.consulta(queryAtualizarAluno);
                dgv_alunos[1, linha].Value = tb_nome.Text;                                                                     
            }
        }

        private void btn_excluirAluno_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma Exclusão?", "Excluir", MessageBoxButtons.YesNo))///
            {
                string vqueryExcluirAluno = String.Format(@"
                    DELETE FROM
                        tb_alunos
                    WHERE
                        N_IDALUNO={0}
                ",idSelecionado);
                Banco.consulta(vqueryExcluirAluno);
                dgv_alunos.Rows.Remove(dgv_alunos.CurrentRow);
            }
        }

        private void btn_financeiro_Click(object sender, EventArgs e)
        {

        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
