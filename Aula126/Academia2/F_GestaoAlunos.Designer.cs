
namespace Academia2
{
    partial class F_GestaoAlunos
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
            this.dgv_alunos = new System.Windows.Forms.DataGridView();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.cb_turmas = new System.Windows.Forms.ComboBox();
            this.btn_imprimirCarteirinha = new System.Windows.Forms.Button();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.lbl_turmas = new System.Windows.Forms.Label();
            this.lbl_duploClique = new System.Windows.Forms.Label();
            this.mtb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_salvarEdicoes = new System.Windows.Forms.Button();
            this.btn_excluirAluno = new System.Windows.Forms.Button();
            this.btn_financeiro = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.pb_carteirinha = new System.Windows.Forms.PictureBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alunos)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_carteirinha)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_alunos
            // 
            this.dgv_alunos.AllowUserToAddRows = false;
            this.dgv_alunos.AllowUserToDeleteRows = false;
            this.dgv_alunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_alunos.Location = new System.Drawing.Point(8, 8);
            this.dgv_alunos.Name = "dgv_alunos";
            this.dgv_alunos.ReadOnly = true;
            this.dgv_alunos.Size = new System.Drawing.Size(360, 544);
            this.dgv_alunos.TabIndex = 0;
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(560, 87);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(160, 21);
            this.cb_status.TabIndex = 5;
            // 
            // cb_turmas
            // 
            this.cb_turmas.FormattingEnabled = true;
            this.cb_turmas.Location = new System.Drawing.Point(376, 152);
            this.cb_turmas.Name = "cb_turmas";
            this.cb_turmas.Size = new System.Drawing.Size(344, 21);
            this.cb_turmas.TabIndex = 6;
            // 
            // btn_imprimirCarteirinha
            // 
            this.btn_imprimirCarteirinha.Location = new System.Drawing.Point(376, 192);
            this.btn_imprimirCarteirinha.Name = "btn_imprimirCarteirinha";
            this.btn_imprimirCarteirinha.Size = new System.Drawing.Size(344, 40);
            this.btn_imprimirCarteirinha.TabIndex = 7;
            this.btn_imprimirCarteirinha.Text = "Imprimir Carteirinha";
            this.btn_imprimirCarteirinha.UseVisualStyleBackColor = true;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(376, 8);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 8;
            this.lbl_nome.Text = "Nome";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(560, 64);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(37, 13);
            this.lbl_status.TabIndex = 9;
            this.lbl_status.Text = "Status";
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Location = new System.Drawing.Point(376, 64);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(49, 13);
            this.lbl_telefone.TabIndex = 10;
            this.lbl_telefone.Text = "Telefone";
            // 
            // lbl_turmas
            // 
            this.lbl_turmas.AutoSize = true;
            this.lbl_turmas.Location = new System.Drawing.Point(376, 128);
            this.lbl_turmas.Name = "lbl_turmas";
            this.lbl_turmas.Size = new System.Drawing.Size(42, 13);
            this.lbl_turmas.TabIndex = 11;
            this.lbl_turmas.Text = "Turmas";
            // 
            // lbl_duploClique
            // 
            this.lbl_duploClique.AutoSize = true;
            this.lbl_duploClique.Location = new System.Drawing.Point(376, 456);
            this.lbl_duploClique.Name = "lbl_duploClique";
            this.lbl_duploClique.Size = new System.Drawing.Size(154, 13);
            this.lbl_duploClique.TabIndex = 12;
            this.lbl_duploClique.Text = "Clique duplo para alterar a Foto";
            // 
            // mtb_telefone
            // 
            this.mtb_telefone.Location = new System.Drawing.Point(376, 88);
            this.mtb_telefone.Mask = "(99) 00000-0000";
            this.mtb_telefone.Name = "mtb_telefone";
            this.mtb_telefone.Size = new System.Drawing.Size(176, 20);
            this.mtb_telefone.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_fechar);
            this.panel2.Controls.Add(this.btn_financeiro);
            this.panel2.Controls.Add(this.btn_excluirAluno);
            this.panel2.Controls.Add(this.btn_salvarEdicoes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 576);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(741, 49);
            this.panel2.TabIndex = 18;
            // 
            // btn_salvarEdicoes
            // 
            this.btn_salvarEdicoes.Location = new System.Drawing.Point(0, 0);
            this.btn_salvarEdicoes.Name = "btn_salvarEdicoes";
            this.btn_salvarEdicoes.Size = new System.Drawing.Size(184, 39);
            this.btn_salvarEdicoes.TabIndex = 0;
            this.btn_salvarEdicoes.Text = "Salvar Edições";
            this.btn_salvarEdicoes.UseVisualStyleBackColor = true;
            this.btn_salvarEdicoes.Click += new System.EventHandler(this.btn_salvarEdicoes_Click);
            // 
            // btn_excluirAluno
            // 
            this.btn_excluirAluno.Location = new System.Drawing.Point(186, 0);
            this.btn_excluirAluno.Name = "btn_excluirAluno";
            this.btn_excluirAluno.Size = new System.Drawing.Size(184, 39);
            this.btn_excluirAluno.TabIndex = 1;
            this.btn_excluirAluno.Text = "Excluir Aluno";
            this.btn_excluirAluno.UseVisualStyleBackColor = true;
            this.btn_excluirAluno.Click += new System.EventHandler(this.btn_excluirAluno_Click);
            // 
            // btn_financeiro
            // 
            this.btn_financeiro.Location = new System.Drawing.Point(373, 0);
            this.btn_financeiro.Name = "btn_financeiro";
            this.btn_financeiro.Size = new System.Drawing.Size(184, 39);
            this.btn_financeiro.TabIndex = 2;
            this.btn_financeiro.Text = "Financeiro";
            this.btn_financeiro.UseVisualStyleBackColor = true;
            this.btn_financeiro.Click += new System.EventHandler(this.btn_financeiro_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(560, 0);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(184, 39);
            this.btn_fechar.TabIndex = 3;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // pb_carteirinha
            // 
            this.pb_carteirinha.Location = new System.Drawing.Point(376, 248);
            this.pb_carteirinha.Name = "pb_carteirinha";
            this.pb_carteirinha.Size = new System.Drawing.Size(168, 200);
            this.pb_carteirinha.TabIndex = 4;
            this.pb_carteirinha.TabStop = false;
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(376, 24);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(344, 20);
            this.tb_nome.TabIndex = 19;
            // 
            // F_GestaoAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 625);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.pb_carteirinha);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.mtb_telefone);
            this.Controls.Add(this.lbl_duploClique);
            this.Controls.Add(this.lbl_turmas);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.btn_imprimirCarteirinha);
            this.Controls.Add(this.cb_turmas);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.dgv_alunos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_GestaoAlunos";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Alunos";
            this.Load += new System.EventHandler(this.F_GestaoAlunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alunos)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_carteirinha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_alunos;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.ComboBox cb_turmas;
        private System.Windows.Forms.Button btn_imprimirCarteirinha;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.Label lbl_turmas;
        private System.Windows.Forms.Label lbl_duploClique;
        private System.Windows.Forms.MaskedTextBox mtb_telefone;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_financeiro;
        private System.Windows.Forms.Button btn_excluirAluno;
        private System.Windows.Forms.Button btn_salvarEdicoes;
        private System.Windows.Forms.PictureBox pb_carteirinha;
        private System.Windows.Forms.TextBox tb_nome;
    }
}