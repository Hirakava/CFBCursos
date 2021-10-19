
namespace Componentes
{
    partial class F_TabControl
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_novaTab = new System.Windows.Forms.Button();
            this.tb_nomeNovaPagina = new System.Windows.Forms.TextBox();
            this.btn_removerTabAtual = new System.Windows.Forms.Button();
            this.btn_posicionarTab = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(8, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(792, 396);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(784, 370);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_novaTab
            // 
            this.btn_novaTab.Location = new System.Drawing.Point(224, 8);
            this.btn_novaTab.Name = "btn_novaTab";
            this.btn_novaTab.Size = new System.Drawing.Size(208, 23);
            this.btn_novaTab.TabIndex = 0;
            this.btn_novaTab.Text = "Nova Tab";
            this.btn_novaTab.UseVisualStyleBackColor = true;
            this.btn_novaTab.Click += new System.EventHandler(this.btn_novaTab_Click);
            // 
            // tb_nomeNovaPagina
            // 
            this.tb_nomeNovaPagina.Location = new System.Drawing.Point(8, 8);
            this.tb_nomeNovaPagina.Name = "tb_nomeNovaPagina";
            this.tb_nomeNovaPagina.Size = new System.Drawing.Size(208, 20);
            this.tb_nomeNovaPagina.TabIndex = 1;
            // 
            // btn_removerTabAtual
            // 
            this.btn_removerTabAtual.Location = new System.Drawing.Point(440, 8);
            this.btn_removerTabAtual.Name = "btn_removerTabAtual";
            this.btn_removerTabAtual.Size = new System.Drawing.Size(208, 23);
            this.btn_removerTabAtual.TabIndex = 2;
            this.btn_removerTabAtual.Text = "Remove Tab Atual";
            this.btn_removerTabAtual.UseVisualStyleBackColor = true;
            this.btn_removerTabAtual.Click += new System.EventHandler(this.btn_removerTabAtual_Click);
            // 
            // btn_posicionarTab
            // 
            this.btn_posicionarTab.Location = new System.Drawing.Point(224, 32);
            this.btn_posicionarTab.Name = "btn_posicionarTab";
            this.btn_posicionarTab.Size = new System.Drawing.Size(208, 23);
            this.btn_posicionarTab.TabIndex = 3;
            this.btn_posicionarTab.Text = "Posicionar Tab";
            this.btn_posicionarTab.UseVisualStyleBackColor = true;
            this.btn_posicionarTab.Click += new System.EventHandler(this.btn_posicionarTab_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(8, 32);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(208, 20);
            this.numericUpDown1.TabIndex = 4;
            // 
            // F_TabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btn_posicionarTab);
            this.Controls.Add(this.btn_removerTabAtual);
            this.Controls.Add(this.tb_nomeNovaPagina);
            this.Controls.Add(this.btn_novaTab);
            this.Controls.Add(this.tabControl1);
            this.Name = "F_TabControl";
            this.Text = "F_TabControl";
            this.Load += new System.EventHandler(this.F_TabControl_Load);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_novaTab;
        private System.Windows.Forms.TextBox tb_nomeNovaPagina;
        private System.Windows.Forms.Button btn_removerTabAtual;
        private System.Windows.Forms.Button btn_posicionarTab;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}