
namespace Componentes
{
    partial class F_comboBox
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
            this.cb_transportes = new System.Windows.Forms.ComboBox();
            this.btnmostrarSelecionados = new System.Windows.Forms.Button();
            this.btnlimparElementos = new System.Windows.Forms.Button();
            this.btnresetarElementos = new System.Windows.Forms.Button();
            this.txt_transporte = new System.Windows.Forms.TextBox();
            this.btn_adicionarNovoTransporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_transportes
            // 
            this.cb_transportes.FormattingEnabled = true;
            this.cb_transportes.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Navio",
            "Ônibus",
            "Trem"});
            this.cb_transportes.Location = new System.Drawing.Point(8, 8);
            this.cb_transportes.Name = "cb_transportes";
            this.cb_transportes.Size = new System.Drawing.Size(216, 21);
            this.cb_transportes.TabIndex = 0;
            this.cb_transportes.SelectedIndexChanged += new System.EventHandler(this.cb_transportes_SelectedIndexChanged);
            // 
            // btnmostrarSelecionados
            // 
            this.btnmostrarSelecionados.Location = new System.Drawing.Point(232, 8);
            this.btnmostrarSelecionados.Name = "btnmostrarSelecionados";
            this.btnmostrarSelecionados.Size = new System.Drawing.Size(208, 23);
            this.btnmostrarSelecionados.TabIndex = 1;
            this.btnmostrarSelecionados.Text = "Mostrar Selecionado";
            this.btnmostrarSelecionados.UseVisualStyleBackColor = true;
            this.btnmostrarSelecionados.Click += new System.EventHandler(this.btnmostrarSelecionados_Click);
            // 
            // btnlimparElementos
            // 
            this.btnlimparElementos.Location = new System.Drawing.Point(232, 40);
            this.btnlimparElementos.Name = "btnlimparElementos";
            this.btnlimparElementos.Size = new System.Drawing.Size(208, 23);
            this.btnlimparElementos.TabIndex = 2;
            this.btnlimparElementos.Text = "Limpar Elementos";
            this.btnlimparElementos.UseVisualStyleBackColor = true;
            this.btnlimparElementos.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnresetarElementos
            // 
            this.btnresetarElementos.Location = new System.Drawing.Point(232, 72);
            this.btnresetarElementos.Name = "btnresetarElementos";
            this.btnresetarElementos.Size = new System.Drawing.Size(208, 23);
            this.btnresetarElementos.TabIndex = 3;
            this.btnresetarElementos.Text = "Resetar Elementos";
            this.btnresetarElementos.UseVisualStyleBackColor = true;
            this.btnresetarElementos.Click += new System.EventHandler(this.btnresetarElementos_Click);
            // 
            // txt_transporte
            // 
            this.txt_transporte.Location = new System.Drawing.Point(232, 152);
            this.txt_transporte.Name = "txt_transporte";
            this.txt_transporte.Size = new System.Drawing.Size(208, 20);
            this.txt_transporte.TabIndex = 4;
            // 
            // btn_adicionarNovoTransporte
            // 
            this.btn_adicionarNovoTransporte.Location = new System.Drawing.Point(232, 176);
            this.btn_adicionarNovoTransporte.Name = "btn_adicionarNovoTransporte";
            this.btn_adicionarNovoTransporte.Size = new System.Drawing.Size(208, 23);
            this.btn_adicionarNovoTransporte.TabIndex = 5;
            this.btn_adicionarNovoTransporte.Text = "Adicionar Novo Transporte";
            this.btn_adicionarNovoTransporte.UseVisualStyleBackColor = true;
            this.btn_adicionarNovoTransporte.Click += new System.EventHandler(this.button4_Click);
            // 
            // F_comboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 293);
            this.Controls.Add(this.btn_adicionarNovoTransporte);
            this.Controls.Add(this.txt_transporte);
            this.Controls.Add(this.btnresetarElementos);
            this.Controls.Add(this.btnlimparElementos);
            this.Controls.Add(this.btnmostrarSelecionados);
            this.Controls.Add(this.cb_transportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_comboBox";
            this.Text = "F_Combobox";
            this.Load += new System.EventHandler(this.F_Combobox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_transportes;
        private System.Windows.Forms.Button btnmostrarSelecionados;
        private System.Windows.Forms.Button btnlimparElementos;
        private System.Windows.Forms.Button btnresetarElementos;
        private System.Windows.Forms.TextBox txt_transporte;
        private System.Windows.Forms.Button btn_adicionarNovoTransporte;
    }
}