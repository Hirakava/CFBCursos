
namespace Componentes
{
    partial class F_TrackBar
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_valor = new System.Windows.Forms.TextBox();
            this.btn_definir = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // tb_valor
            // 
            this.tb_valor.Location = new System.Drawing.Point(8, 64);
            this.tb_valor.Name = "tb_valor";
            this.tb_valor.Size = new System.Drawing.Size(184, 20);
            this.tb_valor.TabIndex = 1;
            // 
            // btn_definir
            // 
            this.btn_definir.Location = new System.Drawing.Point(192, 64);
            this.btn_definir.Name = "btn_definir";
            this.btn_definir.Size = new System.Drawing.Size(168, 23);
            this.btn_definir.TabIndex = 2;
            this.btn_definir.Text = "Definir";
            this.btn_definir.UseVisualStyleBackColor = true;
            this.btn_definir.Click += new System.EventHandler(this.btn_definir_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(8, 16);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(352, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Value = 50;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // F_TrackBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btn_definir);
            this.Controls.Add(this.tb_valor);
            this.Controls.Add(this.label1);
            this.Name = "F_TrackBar";
            this.Text = "F_TrackBar";
            this.Load += new System.EventHandler(this.F_TrackBar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_valor;
        private System.Windows.Forms.Button btn_definir;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}