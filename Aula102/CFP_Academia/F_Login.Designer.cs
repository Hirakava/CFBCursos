
namespace CFP_Academia
{
    partial class F_Login
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
            this.lbl_userName = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.btn_logar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.tb_userName = new System.Windows.Forms.TextBox();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_userName
            // 
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.Location = new System.Drawing.Point(8, 8);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(55, 13);
            this.lbl_userName.TabIndex = 0;
            this.lbl_userName.Text = "Username";
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Location = new System.Drawing.Point(8, 48);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(38, 13);
            this.lbl_senha.TabIndex = 1;
            this.lbl_senha.Text = "Senha";
            // 
            // btn_logar
            // 
            this.btn_logar.Location = new System.Drawing.Point(8, 96);
            this.btn_logar.Name = "btn_logar";
            this.btn_logar.Size = new System.Drawing.Size(280, 23);
            this.btn_logar.TabIndex = 2;
            this.btn_logar.Text = "Logar";
            this.btn_logar.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(8, 128);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(280, 23);
            this.btn_cancelar.TabIndex = 3;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // tb_userName
            // 
            this.tb_userName.Location = new System.Drawing.Point(8, 24);
            this.tb_userName.Name = "tb_userName";
            this.tb_userName.Size = new System.Drawing.Size(280, 20);
            this.tb_userName.TabIndex = 4;
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(8, 64);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.PasswordChar = '*';
            this.tb_senha.Size = new System.Drawing.Size(280, 20);
            this.tb_senha.TabIndex = 5;
            // 
            // F_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 161);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.tb_userName);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_logar);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.lbl_userName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_userName;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.Button btn_logar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TextBox tb_userName;
        private System.Windows.Forms.TextBox tb_senha;
    }
}