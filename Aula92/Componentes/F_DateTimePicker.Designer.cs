﻿
namespace Componentes
{
    partial class F_DateTimePicker
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
            this.dtp_data = new System.Windows.Forms.DateTimePicker();
            this.btnobterData = new System.Windows.Forms.Button();
            this.tb_data = new System.Windows.Forms.TextBox();
            this.tb_dia = new System.Windows.Forms.TextBox();
            this.tb_mes = new System.Windows.Forms.TextBox();
            this.tb_ano = new System.Windows.Forms.TextBox();
            this.btn_setarData = new System.Windows.Forms.Button();
            this.btn_hoje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp_data
            // 
            this.dtp_data.Location = new System.Drawing.Point(8, 8);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(312, 20);
            this.dtp_data.TabIndex = 0;
            // 
            // btnobterData
            // 
            this.btnobterData.Location = new System.Drawing.Point(320, 8);
            this.btnobterData.Name = "btnobterData";
            this.btnobterData.Size = new System.Drawing.Size(312, 23);
            this.btnobterData.TabIndex = 1;
            this.btnobterData.Text = "Obter Data";
            this.btnobterData.UseVisualStyleBackColor = true;
            this.btnobterData.Click += new System.EventHandler(this.btnobterData_Click);
            // 
            // tb_data
            // 
            this.tb_data.Location = new System.Drawing.Point(8, 40);
            this.tb_data.Name = "tb_data";
            this.tb_data.Size = new System.Drawing.Size(312, 20);
            this.tb_data.TabIndex = 2;
            // 
            // tb_dia
            // 
            this.tb_dia.Location = new System.Drawing.Point(8, 64);
            this.tb_dia.Name = "tb_dia";
            this.tb_dia.Size = new System.Drawing.Size(100, 20);
            this.tb_dia.TabIndex = 3;
            // 
            // tb_mes
            // 
            this.tb_mes.Location = new System.Drawing.Point(112, 64);
            this.tb_mes.Name = "tb_mes";
            this.tb_mes.Size = new System.Drawing.Size(100, 20);
            this.tb_mes.TabIndex = 4;
            // 
            // tb_ano
            // 
            this.tb_ano.Location = new System.Drawing.Point(216, 64);
            this.tb_ano.Name = "tb_ano";
            this.tb_ano.Size = new System.Drawing.Size(100, 20);
            this.tb_ano.TabIndex = 5;
            // 
            // btn_setarData
            // 
            this.btn_setarData.Location = new System.Drawing.Point(320, 64);
            this.btn_setarData.Name = "btn_setarData";
            this.btn_setarData.Size = new System.Drawing.Size(312, 23);
            this.btn_setarData.TabIndex = 6;
            this.btn_setarData.Text = "Setar Data";
            this.btn_setarData.UseVisualStyleBackColor = true;
            this.btn_setarData.Click += new System.EventHandler(this.btn_setarData_Click);
            // 
            // btn_hoje
            // 
            this.btn_hoje.AllowDrop = true;
            this.btn_hoje.Location = new System.Drawing.Point(320, 88);
            this.btn_hoje.Name = "btn_hoje";
            this.btn_hoje.Size = new System.Drawing.Size(312, 23);
            this.btn_hoje.TabIndex = 7;
            this.btn_hoje.Text = "Hoje";
            this.btn_hoje.UseVisualStyleBackColor = true;
            this.btn_hoje.Click += new System.EventHandler(this.btn_hoje_Click);
            // 
            // F_DateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 450);
            this.Controls.Add(this.btn_hoje);
            this.Controls.Add(this.btn_setarData);
            this.Controls.Add(this.tb_ano);
            this.Controls.Add(this.tb_mes);
            this.Controls.Add(this.tb_dia);
            this.Controls.Add(this.tb_data);
            this.Controls.Add(this.btnobterData);
            this.Controls.Add(this.dtp_data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_DateTimePicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_DateTimePicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_data;
        private System.Windows.Forms.Button btnobterData;
        private System.Windows.Forms.TextBox tb_data;
        private System.Windows.Forms.TextBox tb_dia;
        private System.Windows.Forms.TextBox tb_mes;
        private System.Windows.Forms.TextBox tb_ano;
        private System.Windows.Forms.Button btn_setarData;
        private System.Windows.Forms.Button btn_hoje;
    }
}