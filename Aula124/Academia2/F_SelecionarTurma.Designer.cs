
namespace Academia2
{
    partial class F_SelecionarTurma
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_selecionarTurma = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_selecionarTurma)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_selecionarTurma
            // 
            this.dgv_selecionarTurma.AllowUserToAddRows = false;
            this.dgv_selecionarTurma.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_selecionarTurma.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_selecionarTurma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_selecionarTurma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_selecionarTurma.EnableHeadersVisualStyles = false;
            this.dgv_selecionarTurma.Location = new System.Drawing.Point(8, 8);
            this.dgv_selecionarTurma.Name = "dgv_selecionarTurma";
            this.dgv_selecionarTurma.ReadOnly = true;
            this.dgv_selecionarTurma.RowHeadersVisible = false;
            this.dgv_selecionarTurma.RowTemplate.ReadOnly = true;
            this.dgv_selecionarTurma.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_selecionarTurma.Size = new System.Drawing.Size(784, 440);
            this.dgv_selecionarTurma.TabIndex = 0;
            // 
            // F_SelecionarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_selecionarTurma);
            this.Name = "F_SelecionarTurma";
            this.Text = "F_SelecionarTurma";
            this.Load += new System.EventHandler(this.F_SelecionarTurma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_selecionarTurma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_selecionarTurma;
    }
}