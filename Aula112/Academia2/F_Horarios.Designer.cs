
namespace Academia2
{
    partial class F_Horarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_horarios = new System.Windows.Forms.DataGridView();
            this.btn_novoHorario = new System.Windows.Forms.Button();
            this.btn_salvarHorario = new System.Windows.Forms.Button();
            this.btn_excluirHorario = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.lbl_horario = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.mtb_dscHorario = new System.Windows.Forms.MaskedTextBox();
            this.tb_idHorario = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_horarios)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_horarios
            // 
            this.dgv_horarios.AllowUserToAddRows = false;
            this.dgv_horarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_horarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_horarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_horarios.EnableHeadersVisualStyles = false;
            this.dgv_horarios.Location = new System.Drawing.Point(8, 48);
            this.dgv_horarios.MultiSelect = false;
            this.dgv_horarios.Name = "dgv_horarios";
            this.dgv_horarios.ReadOnly = true;
            this.dgv_horarios.RowHeadersVisible = false;
            this.dgv_horarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_horarios.Size = new System.Drawing.Size(416, 312);
            this.dgv_horarios.TabIndex = 0;
            this.dgv_horarios.SelectionChanged += new System.EventHandler(this.dgv_horarios_SelectionChanged);
            // 
            // btn_novoHorario
            // 
            this.btn_novoHorario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novoHorario.Location = new System.Drawing.Point(8, 0);
            this.btn_novoHorario.Name = "btn_novoHorario";
            this.btn_novoHorario.Size = new System.Drawing.Size(83, 23);
            this.btn_novoHorario.TabIndex = 1;
            this.btn_novoHorario.Text = "Novo Horário";
            this.btn_novoHorario.UseVisualStyleBackColor = true;
            this.btn_novoHorario.Click += new System.EventHandler(this.btn_novoHorario_Click);
            // 
            // btn_salvarHorario
            // 
            this.btn_salvarHorario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvarHorario.Location = new System.Drawing.Point(120, 0);
            this.btn_salvarHorario.Name = "btn_salvarHorario";
            this.btn_salvarHorario.Size = new System.Drawing.Size(83, 23);
            this.btn_salvarHorario.TabIndex = 2;
            this.btn_salvarHorario.Text = "Salvar Horario";
            this.btn_salvarHorario.UseVisualStyleBackColor = true;
            this.btn_salvarHorario.Click += new System.EventHandler(this.btn_salvarHorario_Click);
            // 
            // btn_excluirHorario
            // 
            this.btn_excluirHorario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excluirHorario.Location = new System.Drawing.Point(232, 0);
            this.btn_excluirHorario.Name = "btn_excluirHorario";
            this.btn_excluirHorario.Size = new System.Drawing.Size(83, 23);
            this.btn_excluirHorario.TabIndex = 3;
            this.btn_excluirHorario.Text = "Excluir Horário";
            this.btn_excluirHorario.UseVisualStyleBackColor = true;
            this.btn_excluirHorario.Click += new System.EventHandler(this.btn_excluirHorario_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fechar.Location = new System.Drawing.Point(344, 0);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(83, 23);
            this.btn_fechar.TabIndex = 4;
            this.btn_fechar.Text = "&Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // lbl_horario
            // 
            this.lbl_horario.AutoSize = true;
            this.lbl_horario.Location = new System.Drawing.Point(120, 8);
            this.lbl_horario.Name = "lbl_horario";
            this.lbl_horario.Size = new System.Drawing.Size(41, 13);
            this.lbl_horario.TabIndex = 5;
            this.lbl_horario.Text = "Horário";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(8, 8);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(27, 13);
            this.lbl_ID.TabIndex = 6;
            this.lbl_ID.Text = "ID. :";
            // 
            // mtb_dscHorario
            // 
            this.mtb_dscHorario.Location = new System.Drawing.Point(120, 24);
            this.mtb_dscHorario.Mask = "99:99\\até99:99";
            this.mtb_dscHorario.Name = "mtb_dscHorario";
            this.mtb_dscHorario.Size = new System.Drawing.Size(88, 20);
            this.mtb_dscHorario.TabIndex = 7;
            // 
            // tb_idHorario
            // 
            this.tb_idHorario.Location = new System.Drawing.Point(9, 24);
            this.tb_idHorario.Name = "tb_idHorario";
            this.tb_idHorario.ReadOnly = true;
            this.tb_idHorario.Size = new System.Drawing.Size(95, 20);
            this.tb_idHorario.TabIndex = 8;
            this.tb_idHorario.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_novoHorario);
            this.panel1.Controls.Add(this.btn_salvarHorario);
            this.panel1.Controls.Add(this.btn_excluirHorario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 364);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 26);
            this.panel1.TabIndex = 9;
            // 
            // F_Horarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 390);
            this.Controls.Add(this.tb_idHorario);
            this.Controls.Add(this.mtb_dscHorario);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.lbl_horario);
            this.Controls.Add(this.dgv_horarios);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Horarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Horarios";
            this.Load += new System.EventHandler(this.F_Horarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_horarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_horarios;
        private System.Windows.Forms.Button btn_novoHorario;
        private System.Windows.Forms.Button btn_salvarHorario;
        private System.Windows.Forms.Button btn_excluirHorario;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Label lbl_horario;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.MaskedTextBox mtb_dscHorario;
        private System.Windows.Forms.TextBox tb_idHorario;
        private System.Windows.Forms.Panel panel1;
    }
}