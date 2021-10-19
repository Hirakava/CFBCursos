
namespace Componentes
{
    partial class F_MaskedTextBox
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
            this.mtbsenha = new System.Windows.Forms.MaskedTextBox();
            this.lblsenha = new System.Windows.Forms.Label();
            this.mtbcpf = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chbsomenteTexto = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // mtbsenha
            // 
            this.mtbsenha.Location = new System.Drawing.Point(0, 40);
            this.mtbsenha.Name = "mtbsenha";
            this.mtbsenha.PasswordChar = '*';
            this.mtbsenha.Size = new System.Drawing.Size(232, 20);
            this.mtbsenha.TabIndex = 0;
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Location = new System.Drawing.Point(0, 24);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(38, 13);
            this.lblsenha.TabIndex = 1;
            this.lblsenha.Text = "Senha";
            // 
            // mtbcpf
            // 
            this.mtbcpf.Location = new System.Drawing.Point(0, 88);
            this.mtbcpf.Mask = "000.000.000-00";
            this.mtbcpf.Name = "mtbcpf";
            this.mtbcpf.Size = new System.Drawing.Size(232, 20);
            this.mtbcpf.TabIndex = 2;
            this.mtbcpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chbsomenteTexto
            // 
            this.chbsomenteTexto.AutoSize = true;
            this.chbsomenteTexto.Location = new System.Drawing.Point(240, 88);
            this.chbsomenteTexto.Name = "chbsomenteTexto";
            this.chbsomenteTexto.Size = new System.Drawing.Size(98, 17);
            this.chbsomenteTexto.TabIndex = 4;
            this.chbsomenteTexto.Text = "Somente Texto";
            this.chbsomenteTexto.UseVisualStyleBackColor = true;
            // 
            // F_MaskedTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chbsomenteTexto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mtbcpf);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.mtbsenha);
            this.Name = "F_MaskedTextBox";
            this.Text = "F_MaskedTextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbsenha;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.MaskedTextBox mtbcpf;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chbsomenteTexto;
    }
}