
namespace Academia2
{
    partial class F_GestaoUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_nivel = new System.Windows.Forms.Label();
            this.lb_status = new System.Windows.Forms.Label();
            this.n_nivel = new System.Windows.Forms.NumericUpDown();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_userName = new System.Windows.Forms.TextBox();
            this.lb_senha = new System.Windows.Forms.Label();
            this.lb_Username = new System.Windows.Forms.Label();
            this.lb_nome = new System.Windows.Forms.Label();
            this.lb_desligado = new System.Windows.Forms.Label();
            this.lb_bloqueado = new System.Windows.Forms.Label();
            this.lb_aativo = new System.Windows.Forms.Label();
            this.btn_novoUsuario = new System.Windows.Forms.Button();
            this.btn_salvarAlteracoes = new System.Windows.Forms.Button();
            this.btn_excluirUsuarios = new System.Windows.Forms.Button();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_fecharJanela = new System.Windows.Forms.Button();
            this.dgv_usuarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.n_nivel)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_nivel
            // 
            this.lb_nivel.AutoSize = true;
            this.lb_nivel.Location = new System.Drawing.Point(208, 160);
            this.lb_nivel.Name = "lb_nivel";
            this.lb_nivel.Size = new System.Drawing.Size(31, 13);
            this.lb_nivel.TabIndex = 22;
            this.lb_nivel.Text = "Nivel";
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Location = new System.Drawing.Point(8, 160);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(37, 13);
            this.lb_status.TabIndex = 21;
            this.lb_status.Text = "Status";
            // 
            // n_nivel
            // 
            this.n_nivel.Location = new System.Drawing.Point(208, 176);
            this.n_nivel.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.n_nivel.Name = "n_nivel";
            this.n_nivel.Size = new System.Drawing.Size(192, 20);
            this.n_nivel.TabIndex = 20;
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Items.AddRange(new object[] {
            "A",
            "B",
            "D"});
            this.cb_status.Location = new System.Drawing.Point(8, 176);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(200, 21);
            this.cb_status.TabIndex = 19;
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(208, 120);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.PasswordChar = '*';
            this.tb_senha.Size = new System.Drawing.Size(192, 20);
            this.tb_senha.TabIndex = 18;
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(8, 72);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(264, 20);
            this.tb_nome.TabIndex = 17;
            // 
            // tb_userName
            // 
            this.tb_userName.Location = new System.Drawing.Point(8, 120);
            this.tb_userName.Name = "tb_userName";
            this.tb_userName.Size = new System.Drawing.Size(200, 20);
            this.tb_userName.TabIndex = 16;
            // 
            // lb_senha
            // 
            this.lb_senha.AutoSize = true;
            this.lb_senha.Location = new System.Drawing.Point(208, 104);
            this.lb_senha.Name = "lb_senha";
            this.lb_senha.Size = new System.Drawing.Size(38, 13);
            this.lb_senha.TabIndex = 15;
            this.lb_senha.Text = "Senha";
            // 
            // lb_Username
            // 
            this.lb_Username.AutoSize = true;
            this.lb_Username.Location = new System.Drawing.Point(8, 104);
            this.lb_Username.Name = "lb_Username";
            this.lb_Username.Size = new System.Drawing.Size(57, 13);
            this.lb_Username.TabIndex = 14;
            this.lb_Username.Text = "UserName";
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Location = new System.Drawing.Point(8, 56);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(35, 13);
            this.lb_nome.TabIndex = 13;
            this.lb_nome.Text = "Nome";
            // 
            // lb_desligado
            // 
            this.lb_desligado.AutoSize = true;
            this.lb_desligado.Location = new System.Drawing.Point(176, 216);
            this.lb_desligado.Name = "lb_desligado";
            this.lb_desligado.Size = new System.Drawing.Size(89, 13);
            this.lb_desligado.TabIndex = 25;
            this.lb_desligado.Text = "D = DESLIGADO";
            // 
            // lb_bloqueado
            // 
            this.lb_bloqueado.AutoSize = true;
            this.lb_bloqueado.Location = new System.Drawing.Point(72, 216);
            this.lb_bloqueado.Name = "lb_bloqueado";
            this.lb_bloqueado.Size = new System.Drawing.Size(93, 13);
            this.lb_bloqueado.TabIndex = 24;
            this.lb_bloqueado.Text = "B = BLOQUEADO";
            // 
            // lb_aativo
            // 
            this.lb_aativo.AutoSize = true;
            this.lb_aativo.Location = new System.Drawing.Point(8, 216);
            this.lb_aativo.Name = "lb_aativo";
            this.lb_aativo.Size = new System.Drawing.Size(58, 13);
            this.lb_aativo.TabIndex = 23;
            this.lb_aativo.Text = "A = ATIVO";
            // 
            // btn_novoUsuario
            // 
            this.btn_novoUsuario.Location = new System.Drawing.Point(2, 3);
            this.btn_novoUsuario.Name = "btn_novoUsuario";
            this.btn_novoUsuario.Size = new System.Drawing.Size(150, 23);
            this.btn_novoUsuario.TabIndex = 26;
            this.btn_novoUsuario.Text = "Novo Usuário";
            this.btn_novoUsuario.UseVisualStyleBackColor = true;
            // 
            // btn_salvarAlteracoes
            // 
            this.btn_salvarAlteracoes.Location = new System.Drawing.Point(200, 1);
            this.btn_salvarAlteracoes.Name = "btn_salvarAlteracoes";
            this.btn_salvarAlteracoes.Size = new System.Drawing.Size(150, 23);
            this.btn_salvarAlteracoes.TabIndex = 27;
            this.btn_salvarAlteracoes.Text = "Salvar Alterações";
            this.btn_salvarAlteracoes.UseVisualStyleBackColor = true;
            // 
            // btn_excluirUsuarios
            // 
            this.btn_excluirUsuarios.Location = new System.Drawing.Point(400, 0);
            this.btn_excluirUsuarios.Name = "btn_excluirUsuarios";
            this.btn_excluirUsuarios.Size = new System.Drawing.Size(150, 23);
            this.btn_excluirUsuarios.TabIndex = 28;
            this.btn_excluirUsuarios.Text = "Excluir Alterações";
            this.btn_excluirUsuarios.UseVisualStyleBackColor = true;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(8, 8);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(18, 13);
            this.lbl_ID.TabIndex = 29;
            this.lbl_ID.Text = "ID";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(8, 24);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(100, 20);
            this.tb_id.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_fecharJanela);
            this.panel1.Controls.Add(this.btn_salvarAlteracoes);
            this.panel1.Controls.Add(this.btn_novoUsuario);
            this.panel1.Controls.Add(this.btn_excluirUsuarios);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 259);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 27);
            this.panel1.TabIndex = 31;
            // 
            // btn_fecharJanela
            // 
            this.btn_fecharJanela.Location = new System.Drawing.Point(600, 0);
            this.btn_fecharJanela.Name = "btn_fecharJanela";
            this.btn_fecharJanela.Size = new System.Drawing.Size(152, 23);
            this.btn_fecharJanela.TabIndex = 29;
            this.btn_fecharJanela.Text = "Fechar Janela";
            this.btn_fecharJanela.UseVisualStyleBackColor = true;
            this.btn_fecharJanela.Click += new System.EventHandler(this.btn_fecharJanela_Click);
            // 
            // dgv_usuarios
            // 
            this.dgv_usuarios.AllowUserToAddRows = false;
            this.dgv_usuarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_usuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuarios.EnableHeadersVisualStyles = false;
            this.dgv_usuarios.Location = new System.Drawing.Point(408, 0);
            this.dgv_usuarios.MultiSelect = false;
            this.dgv_usuarios.Name = "dgv_usuarios";
            this.dgv_usuarios.ReadOnly = true;
            this.dgv_usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_usuarios.Size = new System.Drawing.Size(344, 248);
            this.dgv_usuarios.TabIndex = 32;
            this.dgv_usuarios.SelectionChanged += new System.EventHandler(this.dgv_usuarios_SelectionChanged);
            // 
            // F_GestaoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 286);
            this.Controls.Add(this.dgv_usuarios);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.lbl_ID);
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
            this.Name = "F_GestaoUsuarios";
            this.Text = "F_GestaoUsuarios";
            this.Load += new System.EventHandler(this.F_GestaoUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.n_nivel)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_nivel;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.NumericUpDown n_nivel;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox tb_userName;
        private System.Windows.Forms.Label lb_senha;
        private System.Windows.Forms.Label lb_Username;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.Label lb_desligado;
        private System.Windows.Forms.Label lb_bloqueado;
        private System.Windows.Forms.Label lb_aativo;
        private System.Windows.Forms.Button btn_novoUsuario;
        private System.Windows.Forms.Button btn_salvarAlteracoes;
        private System.Windows.Forms.Button btn_excluirUsuarios;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_fecharJanela;
        private System.Windows.Forms.DataGridView dgv_usuarios;
    }
}