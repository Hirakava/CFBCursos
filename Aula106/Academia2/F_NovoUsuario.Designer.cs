
namespace Academia2
{
    partial class F_NovoUsuario
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
            this.lb_nome = new System.Windows.Forms.Label();
            this.lb_Username = new System.Windows.Forms.Label();
            this.lb_senha = new System.Windows.Forms.Label();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.tb_userName = new System.Windows.Forms.TextBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.n_nivel = new System.Windows.Forms.NumericUpDown();
            this.lb_status = new System.Windows.Forms.Label();
            this.lb_nivel = new System.Windows.Forms.Label();
            this.lb_aativo = new System.Windows.Forms.Label();
            this.lb_bloqueado = new System.Windows.Forms.Label();
            this.lb_desligado = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.n_nivel)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Location = new System.Drawing.Point(0, 8);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(35, 13);
            this.lb_nome.TabIndex = 0;
            this.lb_nome.Text = "Nome";
            // 
            // lb_Username
            // 
            this.lb_Username.AutoSize = true;
            this.lb_Username.Location = new System.Drawing.Point(264, 8);
            this.lb_Username.Name = "lb_Username";
            this.lb_Username.Size = new System.Drawing.Size(57, 13);
            this.lb_Username.TabIndex = 1;
            this.lb_Username.Text = "UserName";
            // 
            // lb_senha
            // 
            this.lb_senha.AutoSize = true;
            this.lb_senha.Location = new System.Drawing.Point(464, 8);
            this.lb_senha.Name = "lb_senha";
            this.lb_senha.Size = new System.Drawing.Size(38, 13);
            this.lb_senha.TabIndex = 2;
            this.lb_senha.Text = "Senha";
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(0, 0);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(72, 24);
            this.btn_novo.TabIndex = 3;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(72, 0);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(72, 24);
            this.btn_salvar.TabIndex = 4;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(144, 0);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(72, 24);
            this.btn_cancelar.TabIndex = 5;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // tb_userName
            // 
            this.tb_userName.Location = new System.Drawing.Point(264, 24);
            this.tb_userName.Name = "tb_userName";
            this.tb_userName.Size = new System.Drawing.Size(200, 20);
            this.tb_userName.TabIndex = 6;
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(0, 24);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(264, 20);
            this.tb_nome.TabIndex = 7;
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(464, 24);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.PasswordChar = '*';
            this.tb_senha.Size = new System.Drawing.Size(200, 20);
            this.tb_senha.TabIndex = 8;
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Items.AddRange(new object[] {
            "A",
            "B",
            "D"});
            this.cb_status.Location = new System.Drawing.Point(0, 80);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(200, 21);
            this.cb_status.TabIndex = 9;
            // 
            // n_nivel
            // 
            this.n_nivel.Location = new System.Drawing.Point(200, 80);
            this.n_nivel.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.n_nivel.Name = "n_nivel";
            this.n_nivel.Size = new System.Drawing.Size(200, 20);
            this.n_nivel.TabIndex = 10;
            this.n_nivel.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Location = new System.Drawing.Point(0, 64);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(37, 13);
            this.lb_status.TabIndex = 11;
            this.lb_status.Text = "Status";
            // 
            // lb_nivel
            // 
            this.lb_nivel.AutoSize = true;
            this.lb_nivel.Location = new System.Drawing.Point(200, 64);
            this.lb_nivel.Name = "lb_nivel";
            this.lb_nivel.Size = new System.Drawing.Size(31, 13);
            this.lb_nivel.TabIndex = 12;
            this.lb_nivel.Text = "Nivel";
            // 
            // lb_aativo
            // 
            this.lb_aativo.AutoSize = true;
            this.lb_aativo.Location = new System.Drawing.Point(8, 112);
            this.lb_aativo.Name = "lb_aativo";
            this.lb_aativo.Size = new System.Drawing.Size(58, 13);
            this.lb_aativo.TabIndex = 13;
            this.lb_aativo.Text = "A = ATIVO";
            // 
            // lb_bloqueado
            // 
            this.lb_bloqueado.AutoSize = true;
            this.lb_bloqueado.Location = new System.Drawing.Point(72, 112);
            this.lb_bloqueado.Name = "lb_bloqueado";
            this.lb_bloqueado.Size = new System.Drawing.Size(93, 13);
            this.lb_bloqueado.TabIndex = 14;
            this.lb_bloqueado.Text = "B = BLOQUEADO";
            // 
            // lb_desligado
            // 
            this.lb_desligado.AutoSize = true;
            this.lb_desligado.Location = new System.Drawing.Point(176, 112);
            this.lb_desligado.Name = "lb_desligado";
            this.lb_desligado.Size = new System.Drawing.Size(89, 13);
            this.lb_desligado.TabIndex = 15;
            this.lb_desligado.Text = "D = DESLIGADO";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_novo);
            this.panel1.Controls.Add(this.btn_salvar);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 28);
            this.panel1.TabIndex = 16;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(600, 0);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(72, 23);
            this.btn_fechar.TabIndex = 0;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // F_NovoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 164);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_desligado);
            this.Controls.Add(this.lb_bloqueado);
            this.Controls.Add(this.lb_aativo);
            this.Controls.Add(this.lb_nivel);
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.n_nivel);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.tb_userName);
            this.Controls.Add(this.lb_senha);
            this.Controls.Add(this.lb_Username);
            this.Controls.Add(this.lb_nome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_NovoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Usuário";
            ((System.ComponentModel.ISupportInitialize)(this.n_nivel)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.Label lb_Username;
        private System.Windows.Forms.Label lb_senha;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TextBox tb_userName;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.NumericUpDown n_nivel;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.Label lb_nivel;
        private System.Windows.Forms.Label lb_aativo;
        private System.Windows.Forms.Label lb_bloqueado;
        private System.Windows.Forms.Label lb_desligado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_fechar;
    }
}