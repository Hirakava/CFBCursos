
namespace Academia2
{
    partial class F_NovoAluno
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
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_turma = new System.Windows.Forms.Label();
            this.lbl_plano = new System.Windows.Forms.Label();
            this.mtb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.btn_plano = new System.Windows.Forms.Button();
            this.btn_turma = new System.Windows.Forms.Button();
            this.tb_plano = new System.Windows.Forms.TextBox();
            this.tb_turma = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(5, 0);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(128, 23);
            this.btn_novo.TabIndex = 0;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_gravar
            // 
            this.btn_gravar.Enabled = false;
            this.btn_gravar.Location = new System.Drawing.Point(133, 0);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(128, 23);
            this.btn_gravar.TabIndex = 1;
            this.btn_gravar.Text = "Gravar";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Enabled = false;
            this.btn_cancelar.Location = new System.Drawing.Point(261, 0);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(128, 23);
            this.btn_cancelar.TabIndex = 2;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(389, 0);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(128, 23);
            this.btn_fechar.TabIndex = 3;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // cb_status
            // 
            this.cb_status.Enabled = false;
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(8, 72);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(256, 21);
            this.cb_status.TabIndex = 4;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(8, 8);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 5;
            this.lbl_nome.Text = "Nome";
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Location = new System.Drawing.Point(360, 8);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(49, 13);
            this.lbl_telefone.TabIndex = 6;
            this.lbl_telefone.Text = "Telefone";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(8, 56);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(37, 13);
            this.lbl_status.TabIndex = 7;
            this.lbl_status.Text = "Status";
            // 
            // lbl_turma
            // 
            this.lbl_turma.AutoSize = true;
            this.lbl_turma.Location = new System.Drawing.Point(288, 56);
            this.lbl_turma.Name = "lbl_turma";
            this.lbl_turma.Size = new System.Drawing.Size(37, 13);
            this.lbl_turma.TabIndex = 8;
            this.lbl_turma.Text = "Turma";
            // 
            // lbl_plano
            // 
            this.lbl_plano.AutoSize = true;
            this.lbl_plano.Location = new System.Drawing.Point(8, 104);
            this.lbl_plano.Name = "lbl_plano";
            this.lbl_plano.Size = new System.Drawing.Size(34, 13);
            this.lbl_plano.TabIndex = 9;
            this.lbl_plano.Text = "Plano";
            // 
            // mtb_telefone
            // 
            this.mtb_telefone.Enabled = false;
            this.mtb_telefone.Location = new System.Drawing.Point(360, 24);
            this.mtb_telefone.Mask = "(99) 00000-0000";
            this.mtb_telefone.Name = "mtb_telefone";
            this.mtb_telefone.Size = new System.Drawing.Size(144, 20);
            this.mtb_telefone.TabIndex = 11;
            // 
            // btn_plano
            // 
            this.btn_plano.Location = new System.Drawing.Point(263, 118);
            this.btn_plano.Name = "btn_plano";
            this.btn_plano.Size = new System.Drawing.Size(32, 23);
            this.btn_plano.TabIndex = 12;
            this.btn_plano.Text = ". . .";
            this.btn_plano.UseVisualStyleBackColor = true;
            // 
            // btn_turma
            // 
            this.btn_turma.Location = new System.Drawing.Point(471, 70);
            this.btn_turma.Name = "btn_turma";
            this.btn_turma.Size = new System.Drawing.Size(32, 23);
            this.btn_turma.TabIndex = 13;
            this.btn_turma.Text = ". . .";
            this.btn_turma.UseVisualStyleBackColor = true;
            this.btn_turma.Click += new System.EventHandler(this.btn_turma_Click);
            // 
            // tb_plano
            // 
            this.tb_plano.Location = new System.Drawing.Point(8, 120);
            this.tb_plano.Name = "tb_plano";
            this.tb_plano.ReadOnly = true;
            this.tb_plano.Size = new System.Drawing.Size(256, 20);
            this.tb_plano.TabIndex = 14;
            // 
            // tb_turma
            // 
            this.tb_turma.Location = new System.Drawing.Point(288, 72);
            this.tb_turma.Name = "tb_turma";
            this.tb_turma.ReadOnly = true;
            this.tb_turma.Size = new System.Drawing.Size(184, 20);
            this.tb_turma.TabIndex = 15;
            this.tb_turma.Tag = "0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.btn_gravar);
            this.panel1.Controls.Add(this.btn_novo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 25);
            this.panel1.TabIndex = 16;
            // 
            // tb_nome
            // 
            this.tb_nome.Enabled = false;
            this.tb_nome.Location = new System.Drawing.Point(8, 24);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(336, 20);
            this.tb_nome.TabIndex = 17;
            // 
            // F_NovoAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 198);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_turma);
            this.Controls.Add(this.tb_plano);
            this.Controls.Add(this.btn_turma);
            this.Controls.Add(this.btn_plano);
            this.Controls.Add(this.mtb_telefone);
            this.Controls.Add(this.lbl_plano);
            this.Controls.Add(this.lbl_turma);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.cb_status);
            this.Name = "F_NovoAluno";
            this.Text = "Novo Aluno";
            this.Load += new System.EventHandler(this.F_NovoAluno_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_turma;
        private System.Windows.Forms.Label lbl_plano;
        private System.Windows.Forms.MaskedTextBox mtb_telefone;
        private System.Windows.Forms.Button btn_plano;
        private System.Windows.Forms.Button btn_turma;
        private System.Windows.Forms.TextBox tb_plano;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_nome;
        public System.Windows.Forms.TextBox tb_turma;
    }
}