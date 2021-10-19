
namespace Academia2
{
    partial class F_GestaoProfessores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_novoProfessor = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_professor = new System.Windows.Forms.Label();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.mtb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_professor = new System.Windows.Forms.TextBox();
            this.dgv_professores = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_professores)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_novoProfessor
            // 
            this.btn_novoProfessor.Location = new System.Drawing.Point(6, 2);
            this.btn_novoProfessor.Name = "btn_novoProfessor";
            this.btn_novoProfessor.Size = new System.Drawing.Size(154, 23);
            this.btn_novoProfessor.TabIndex = 0;
            this.btn_novoProfessor.Text = "Novo Professor";
            this.btn_novoProfessor.UseVisualStyleBackColor = true;
            this.btn_novoProfessor.Click += new System.EventHandler(this.btn_novoProfessor_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(160, 2);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(152, 23);
            this.btn_salvar.TabIndex = 1;
            this.btn_salvar.Text = "&Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(312, 2);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(152, 23);
            this.btn_excluir.TabIndex = 2;
            this.btn_excluir.Text = "&Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(464, 2);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(152, 23);
            this.btn_fechar.TabIndex = 3;
            this.btn_fechar.Text = "&Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(8, 8);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(27, 13);
            this.lbl_ID.TabIndex = 4;
            this.lbl_ID.Text = "ID. :";
            // 
            // lbl_professor
            // 
            this.lbl_professor.AutoSize = true;
            this.lbl_professor.Location = new System.Drawing.Point(112, 8);
            this.lbl_professor.Name = "lbl_professor";
            this.lbl_professor.Size = new System.Drawing.Size(57, 13);
            this.lbl_professor.TabIndex = 5;
            this.lbl_professor.Text = "Professor :";
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Location = new System.Drawing.Point(424, 8);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(49, 13);
            this.lbl_telefone.TabIndex = 6;
            this.lbl_telefone.Text = "Telefone";
            // 
            // mtb_telefone
            // 
            this.mtb_telefone.Location = new System.Drawing.Point(424, 24);
            this.mtb_telefone.Mask = "(99) 0000 -0000";
            this.mtb_telefone.Name = "mtb_telefone";
            this.mtb_telefone.Size = new System.Drawing.Size(192, 20);
            this.mtb_telefone.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_novoProfessor);
            this.panel1.Controls.Add(this.btn_salvar);
            this.panel1.Controls.Add(this.btn_excluir);
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 408);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 30);
            this.panel1.TabIndex = 8;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(8, 24);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(96, 20);
            this.tb_id.TabIndex = 0;
            this.tb_id.TabStop = false;
            // 
            // tb_professor
            // 
            this.tb_professor.Location = new System.Drawing.Point(112, 24);
            this.tb_professor.Name = "tb_professor";
            this.tb_professor.Size = new System.Drawing.Size(304, 20);
            this.tb_professor.TabIndex = 1;
            // 
            // dgv_professores
            // 
            this.dgv_professores.AllowUserToAddRows = false;
            this.dgv_professores.AllowUserToDeleteRows = false;
            this.dgv_professores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_professores.Location = new System.Drawing.Point(8, 48);
            this.dgv_professores.MultiSelect = false;
            this.dgv_professores.Name = "dgv_professores";
            this.dgv_professores.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_professores.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_professores.Size = new System.Drawing.Size(608, 352);
            this.dgv_professores.TabIndex = 9;
            this.dgv_professores.SelectionChanged += new System.EventHandler(this.dgv_professores_SelectionChanged);
            // 
            // F_GestaoProfessores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 438);
            this.Controls.Add(this.dgv_professores);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.tb_professor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mtb_telefone);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.lbl_professor);
            this.Controls.Add(this.lbl_ID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_GestaoProfessores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Professores";
            this.Load += new System.EventHandler(this.F_GestaoProfessores_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_professores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_novoProfessor;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_professor;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.MaskedTextBox mtb_telefone;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_professor;
        private System.Windows.Forms.DataGridView dgv_professores;
    }
}