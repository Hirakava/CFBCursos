
namespace Academia2
{
    partial class F_GestaoTurmas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_novaTurma = new System.Windows.Forms.Button();
            this.btn_salvaEdicoes = new System.Windows.Forms.Button();
            this.btn_excluirTurma = new System.Windows.Forms.Button();
            this.btn_imprimirTurma = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.dgv_turmas = new System.Windows.Forms.DataGridView();
            this.cb_horarios = new System.Windows.Forms.ComboBox();
            this.lbl_professor = new System.Windows.Forms.Label();
            this.lbl_maximoAlunos = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_horarios = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_professor = new System.Windows.Forms.ComboBox();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.n_maxAlunos = new System.Windows.Forms.NumericUpDown();
            this.lbl_nomeTurma = new System.Windows.Forms.Label();
            this.tb_dscTurma = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_turmas)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n_maxAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_novaTurma
            // 
            this.btn_novaTurma.Location = new System.Drawing.Point(-4, 2);
            this.btn_novaTurma.Name = "btn_novaTurma";
            this.btn_novaTurma.Size = new System.Drawing.Size(140, 23);
            this.btn_novaTurma.TabIndex = 0;
            this.btn_novaTurma.Text = "Nova Turma";
            this.btn_novaTurma.UseVisualStyleBackColor = true;
            // 
            // btn_salvaEdicoes
            // 
            this.btn_salvaEdicoes.Location = new System.Drawing.Point(139, 2);
            this.btn_salvaEdicoes.Name = "btn_salvaEdicoes";
            this.btn_salvaEdicoes.Size = new System.Drawing.Size(140, 23);
            this.btn_salvaEdicoes.TabIndex = 1;
            this.btn_salvaEdicoes.Text = "Salva Edições";
            this.btn_salvaEdicoes.UseVisualStyleBackColor = true;
            // 
            // btn_excluirTurma
            // 
            this.btn_excluirTurma.Location = new System.Drawing.Point(281, 2);
            this.btn_excluirTurma.Name = "btn_excluirTurma";
            this.btn_excluirTurma.Size = new System.Drawing.Size(140, 23);
            this.btn_excluirTurma.TabIndex = 2;
            this.btn_excluirTurma.Text = "Excluir Turma";
            this.btn_excluirTurma.UseVisualStyleBackColor = true;
            // 
            // btn_imprimirTurma
            // 
            this.btn_imprimirTurma.Location = new System.Drawing.Point(424, 2);
            this.btn_imprimirTurma.Name = "btn_imprimirTurma";
            this.btn_imprimirTurma.Size = new System.Drawing.Size(140, 23);
            this.btn_imprimirTurma.TabIndex = 3;
            this.btn_imprimirTurma.Text = "Imprimir Turma";
            this.btn_imprimirTurma.UseVisualStyleBackColor = true;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(565, 2);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(140, 23);
            this.btn_fechar.TabIndex = 4;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            // 
            // dgv_turmas
            // 
            this.dgv_turmas.AllowUserToAddRows = false;
            this.dgv_turmas.AllowUserToDeleteRows = false;
            this.dgv_turmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_turmas.Location = new System.Drawing.Point(0, 0);
            this.dgv_turmas.Name = "dgv_turmas";
            this.dgv_turmas.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_turmas.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_turmas.Size = new System.Drawing.Size(424, 416);
            this.dgv_turmas.TabIndex = 5;
            this.dgv_turmas.SelectionChanged += new System.EventHandler(this.dgv_turmas_SelectionChanged);
            // 
            // cb_horarios
            // 
            this.cb_horarios.FormattingEnabled = true;
            this.cb_horarios.Location = new System.Drawing.Point(432, 232);
            this.cb_horarios.Name = "cb_horarios";
            this.cb_horarios.Size = new System.Drawing.Size(264, 21);
            this.cb_horarios.TabIndex = 6;
            // 
            // lbl_professor
            // 
            this.lbl_professor.AutoSize = true;
            this.lbl_professor.Location = new System.Drawing.Point(440, 72);
            this.lbl_professor.Name = "lbl_professor";
            this.lbl_professor.Size = new System.Drawing.Size(51, 13);
            this.lbl_professor.TabIndex = 7;
            this.lbl_professor.Text = "Professor";
            // 
            // lbl_maximoAlunos
            // 
            this.lbl_maximoAlunos.AutoSize = true;
            this.lbl_maximoAlunos.Location = new System.Drawing.Point(432, 144);
            this.lbl_maximoAlunos.Name = "lbl_maximoAlunos";
            this.lbl_maximoAlunos.Size = new System.Drawing.Size(78, 13);
            this.lbl_maximoAlunos.TabIndex = 8;
            this.lbl_maximoAlunos.Text = "Máximo Alunos";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(512, 144);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(37, 13);
            this.lbl_status.TabIndex = 9;
            this.lbl_status.Text = "Status";
            // 
            // lbl_horarios
            // 
            this.lbl_horarios.AutoSize = true;
            this.lbl_horarios.Location = new System.Drawing.Point(432, 216);
            this.lbl_horarios.Name = "lbl_horarios";
            this.lbl_horarios.Size = new System.Drawing.Size(46, 13);
            this.lbl_horarios.TabIndex = 10;
            this.lbl_horarios.Text = "Horários";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_imprimirTurma);
            this.panel1.Controls.Add(this.btn_excluirTurma);
            this.panel1.Controls.Add(this.btn_salvaEdicoes);
            this.panel1.Controls.Add(this.btn_novaTurma);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 419);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 26);
            this.panel1.TabIndex = 11;
            // 
            // cb_professor
            // 
            this.cb_professor.FormattingEnabled = true;
            this.cb_professor.Location = new System.Drawing.Point(432, 88);
            this.cb_professor.Name = "cb_professor";
            this.cb_professor.Size = new System.Drawing.Size(264, 21);
            this.cb_professor.TabIndex = 12;
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(512, 160);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(184, 21);
            this.cb_status.TabIndex = 13;
            // 
            // n_maxAlunos
            // 
            this.n_maxAlunos.Location = new System.Drawing.Point(432, 160);
            this.n_maxAlunos.Name = "n_maxAlunos";
            this.n_maxAlunos.Size = new System.Drawing.Size(72, 20);
            this.n_maxAlunos.TabIndex = 14;
            // 
            // lbl_nomeTurma
            // 
            this.lbl_nomeTurma.AutoSize = true;
            this.lbl_nomeTurma.Location = new System.Drawing.Point(432, 0);
            this.lbl_nomeTurma.Name = "lbl_nomeTurma";
            this.lbl_nomeTurma.Size = new System.Drawing.Size(68, 13);
            this.lbl_nomeTurma.TabIndex = 15;
            this.lbl_nomeTurma.Text = "Nome Turma";
            // 
            // tb_dscTurma
            // 
            this.tb_dscTurma.Location = new System.Drawing.Point(432, 16);
            this.tb_dscTurma.Name = "tb_dscTurma";
            this.tb_dscTurma.Size = new System.Drawing.Size(264, 20);
            this.tb_dscTurma.TabIndex = 16;
            // 
            // F_GestaoTurmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 445);
            this.Controls.Add(this.tb_dscTurma);
            this.Controls.Add(this.lbl_nomeTurma);
            this.Controls.Add(this.n_maxAlunos);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.cb_professor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_horarios);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_maximoAlunos);
            this.Controls.Add(this.lbl_professor);
            this.Controls.Add(this.cb_horarios);
            this.Controls.Add(this.dgv_turmas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_GestaoTurmas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Turmas";
            this.Load += new System.EventHandler(this.F_GestaoTurmas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_turmas)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.n_maxAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_novaTurma;
        private System.Windows.Forms.Button btn_salvaEdicoes;
        private System.Windows.Forms.Button btn_excluirTurma;
        private System.Windows.Forms.Button btn_imprimirTurma;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.DataGridView dgv_turmas;
        private System.Windows.Forms.ComboBox cb_horarios;
        private System.Windows.Forms.Label lbl_professor;
        private System.Windows.Forms.Label lbl_maximoAlunos;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_horarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cb_professor;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.NumericUpDown n_maxAlunos;
        private System.Windows.Forms.Label lbl_nomeTurma;
        private System.Windows.Forms.TextBox tb_dscTurma;
    }
}