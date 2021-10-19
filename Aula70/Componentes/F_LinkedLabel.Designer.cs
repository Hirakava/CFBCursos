
namespace Componentes
{
    partial class F_LinkedLabel
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
            this.lbl_digiteNome = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.lk_canal = new System.Windows.Forms.LinkLabel();
            this.lk_calculadora = new System.Windows.Forms.LinkLabel();
            this.lk_multiplosLinks = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbl_digiteNome
            // 
            this.lbl_digiteNome.AutoSize = true;
            this.lbl_digiteNome.Location = new System.Drawing.Point(16, 16);
            this.lbl_digiteNome.Name = "lbl_digiteNome";
            this.lbl_digiteNome.Size = new System.Drawing.Size(85, 13);
            this.lbl_digiteNome.TabIndex = 0;
            this.lbl_digiteNome.Text = "Digite seu Nome";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(16, 32);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(232, 20);
            this.tb_nome.TabIndex = 1;
            // 
            // lk_canal
            // 
            this.lk_canal.AutoSize = true;
            this.lk_canal.Location = new System.Drawing.Point(40, 88);
            this.lk_canal.Name = "lk_canal";
            this.lk_canal.Size = new System.Drawing.Size(34, 13);
            this.lk_canal.TabIndex = 2;
            this.lk_canal.TabStop = true;
            this.lk_canal.Text = "Canal";
            this.lk_canal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lk_canal_LinkClicked);
            // 
            // lk_calculadora
            // 
            this.lk_calculadora.AutoSize = true;
            this.lk_calculadora.Location = new System.Drawing.Point(96, 88);
            this.lk_calculadora.Name = "lk_calculadora";
            this.lk_calculadora.Size = new System.Drawing.Size(63, 13);
            this.lk_calculadora.TabIndex = 3;
            this.lk_calculadora.TabStop = true;
            this.lk_calculadora.Text = "Calculadora";
            this.lk_calculadora.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lk_calculadora_LinkClicked);
            // 
            // lk_multiplosLinks
            // 
            this.lk_multiplosLinks.AutoSize = true;
            this.lk_multiplosLinks.Location = new System.Drawing.Point(40, 120);
            this.lk_multiplosLinks.Name = "lk_multiplosLinks";
            this.lk_multiplosLinks.Size = new System.Drawing.Size(126, 13);
            this.lk_multiplosLinks.TabIndex = 4;
            this.lk_multiplosLinks.TabStop = true;
            this.lk_multiplosLinks.Text = "Google - Canal - Youtube";
            this.lk_multiplosLinks.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lk_multiplosLinks_LinkClicked);
            // 
            // F_LinkedLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lk_multiplosLinks);
            this.Controls.Add(this.lk_calculadora);
            this.Controls.Add(this.lk_canal);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.lbl_digiteNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_LinkedLabel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_LinkedLabel";
            this.Load += new System.EventHandler(this.F_LinkedLabel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_digiteNome;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.LinkLabel lk_canal;
        private System.Windows.Forms.LinkLabel lk_calculadora;
        private System.Windows.Forms.LinkLabel lk_multiplosLinks;
    }
}