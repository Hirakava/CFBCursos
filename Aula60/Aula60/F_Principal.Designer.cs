namespace Aula60
{
    partial class F_Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Texto = new System.Windows.Forms.Button();
            this.lblTexto = new System.Windows.Forms.Label();
            this.TxtCursos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Texto
            // 
            this.btn_Texto.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Texto.ForeColor = System.Drawing.Color.Red;
            this.btn_Texto.Location = new System.Drawing.Point(16, 48);
            this.btn_Texto.Name = "btn_Texto";
            this.btn_Texto.Size = new System.Drawing.Size(176, 40);
            this.btn_Texto.TabIndex = 0;
            this.btn_Texto.Text = "OK";
            this.btn_Texto.UseVisualStyleBackColor = false;
            this.btn_Texto.Click += new System.EventHandler(this.btn_Texto_Click);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(16, 96);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(261, 25);
            this.lblTexto.TabIndex = 1;
            this.lblTexto.Text = "www.youtube.com/cfbcursos";
            // 
            // TxtCursos
            // 
            this.TxtCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCursos.Location = new System.Drawing.Point(16, 8);
            this.TxtCursos.Name = "TxtCursos";
            this.TxtCursos.Size = new System.Drawing.Size(168, 30);
            this.TxtCursos.TabIndex = 2;
            // 
            // F_Principal
            // 
            this.ClientSize = new System.Drawing.Size(709, 318);
            this.Controls.Add(this.TxtCursos);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.btn_Texto);
            this.Name = "F_Principal";
            this.Text = "Curso de  C# - CFB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_canal;
        private System.Windows.Forms.Label lblLinkCanal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Texto;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.TextBox TxtCursos;
    }
}

