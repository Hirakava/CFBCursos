
namespace Componentes
{
    partial class F_ListBox
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
            this.lb_carros = new System.Windows.Forms.ListBox();
            this.tb_carro = new System.Windows.Forms.TextBox();
            this.lblcarro = new System.Windows.Forms.Label();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.btnremover = new System.Windows.Forms.Button();
            this.btnobter = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_carros
            // 
            this.lb_carros.FormattingEnabled = true;
            this.lb_carros.Location = new System.Drawing.Point(8, 16);
            this.lb_carros.Name = "lb_carros";
            this.lb_carros.Size = new System.Drawing.Size(200, 238);
            this.lb_carros.TabIndex = 0;
            // 
            // tb_carro
            // 
            this.tb_carro.Location = new System.Drawing.Point(216, 32);
            this.tb_carro.Name = "tb_carro";
            this.tb_carro.Size = new System.Drawing.Size(168, 20);
            this.tb_carro.TabIndex = 1;
            // 
            // lblcarro
            // 
            this.lblcarro.AutoSize = true;
            this.lblcarro.Location = new System.Drawing.Point(216, 16);
            this.lblcarro.Name = "lblcarro";
            this.lblcarro.Size = new System.Drawing.Size(32, 13);
            this.lblcarro.TabIndex = 2;
            this.lblcarro.Text = "Carro";
            // 
            // btnadicionar
            // 
            this.btnadicionar.Location = new System.Drawing.Point(216, 64);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(168, 23);
            this.btnadicionar.TabIndex = 3;
            this.btnadicionar.Text = "Adicionar";
            this.btnadicionar.UseVisualStyleBackColor = true;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // btnremover
            // 
            this.btnremover.Location = new System.Drawing.Point(216, 96);
            this.btnremover.Name = "btnremover";
            this.btnremover.Size = new System.Drawing.Size(168, 23);
            this.btnremover.TabIndex = 4;
            this.btnremover.Text = "Remover";
            this.btnremover.UseVisualStyleBackColor = true;
            this.btnremover.Click += new System.EventHandler(this.btnremover_Click);
            // 
            // btnobter
            // 
            this.btnobter.Location = new System.Drawing.Point(216, 128);
            this.btnobter.Name = "btnobter";
            this.btnobter.Size = new System.Drawing.Size(168, 23);
            this.btnobter.TabIndex = 5;
            this.btnobter.Text = "Obter";
            this.btnobter.UseVisualStyleBackColor = true;
            this.btnobter.Click += new System.EventHandler(this.btnobter_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(216, 232);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(168, 23);
            this.btnlimpar.TabIndex = 6;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // F_ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 263);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnobter);
            this.Controls.Add(this.btnremover);
            this.Controls.Add(this.btnadicionar);
            this.Controls.Add(this.lblcarro);
            this.Controls.Add(this.tb_carro);
            this.Controls.Add(this.lb_carros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_ListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_ListBox";
            this.Load += new System.EventHandler(this.F_ListBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_carros;
        private System.Windows.Forms.TextBox tb_carro;
        private System.Windows.Forms.Label lblcarro;
        private System.Windows.Forms.Button btnadicionar;
        private System.Windows.Forms.Button btnremover;
        private System.Windows.Forms.Button btnobter;
        private System.Windows.Forms.Button btnlimpar;
    }
}