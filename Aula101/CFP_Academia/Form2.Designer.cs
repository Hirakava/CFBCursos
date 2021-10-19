
namespace CFP_Academia
{
    partial class F_CFBAcademia
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_pedLogado = new System.Windows.Forms.PictureBox();
            this.lbl_aces = new System.Windows.Forms.Label();
            this.lbl_acesso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_usuarioNome = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pedLogado)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.lbl_usuarioNome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_acesso);
            this.panel1.Controls.Add(this.lbl_aces);
            this.panel1.Controls.Add(this.pb_pedLogado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 424);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 26);
            this.panel1.TabIndex = 0;
            // 
            // pb_pedLogado
            // 
            this.pb_pedLogado.Image = global::CFP_Academia.Properties.Resources.CRIMSON;
            this.pb_pedLogado.Location = new System.Drawing.Point(0, 8);
            this.pb_pedLogado.Name = "pb_pedLogado";
            this.pb_pedLogado.Size = new System.Drawing.Size(20, 20);
            this.pb_pedLogado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_pedLogado.TabIndex = 0;
            this.pb_pedLogado.TabStop = false;
            // 
            // lbl_aces
            // 
            this.lbl_aces.AutoSize = true;
            this.lbl_aces.Location = new System.Drawing.Point(24, 8);
            this.lbl_aces.Name = "lbl_aces";
            this.lbl_aces.Size = new System.Drawing.Size(42, 13);
            this.lbl_aces.TabIndex = 1;
            this.lbl_aces.Text = "Acesso";
            // 
            // lbl_acesso
            // 
            this.lbl_acesso.AutoSize = true;
            this.lbl_acesso.Location = new System.Drawing.Point(80, 8);
            this.lbl_acesso.Name = "lbl_acesso";
            this.lbl_acesso.Size = new System.Drawing.Size(13, 13);
            this.lbl_acesso.TabIndex = 2;
            this.lbl_acesso.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuário:";
            // 
            // lbl_usuarioNome
            // 
            this.lbl_usuarioNome.AutoSize = true;
            this.lbl_usuarioNome.Location = new System.Drawing.Point(168, 8);
            this.lbl_usuarioNome.Name = "lbl_usuarioNome";
            this.lbl_usuarioNome.Size = new System.Drawing.Size(16, 13);
            this.lbl_usuarioNome.TabIndex = 4;
            this.lbl_usuarioNome.Text = "---";
            // 
            // F_CFBAcademia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "F_CFBAcademia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CFB Academia - v.1.0";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pedLogado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox pb_pedLogado;
        private System.Windows.Forms.Label lbl_usuarioNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_acesso;
        private System.Windows.Forms.Label lbl_aces;
    }
}