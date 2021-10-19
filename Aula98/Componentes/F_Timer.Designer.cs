
namespace Componentes
{
    partial class F_Timer
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button btn_iniciarCarro;
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.btn_parar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_reiniciar = new System.Windows.Forms.Button();
            this.img_carro = new System.Windows.Forms.PictureBox();
            this.btn_pararCarro = new System.Windows.Forms.Button();
            this.timer_carro = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            btn_iniciarCarro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_carro)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.Location = new System.Drawing.Point(0, 8);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(152, 23);
            this.btn_iniciar.TabIndex = 0;
            this.btn_iniciar.Text = "Iniciar";
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // btn_parar
            // 
            this.btn_parar.Location = new System.Drawing.Point(160, 8);
            this.btn_parar.Name = "btn_parar";
            this.btn_parar.Size = new System.Drawing.Size(152, 23);
            this.btn_parar.TabIndex = 1;
            this.btn_parar.Text = "Parar";
            this.btn_parar.UseVisualStyleBackColor = true;
            this.btn_parar.Click += new System.EventHandler(this.btn_parar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // btn_reiniciar
            // 
            this.btn_reiniciar.Location = new System.Drawing.Point(320, 8);
            this.btn_reiniciar.Name = "btn_reiniciar";
            this.btn_reiniciar.Size = new System.Drawing.Size(152, 23);
            this.btn_reiniciar.TabIndex = 3;
            this.btn_reiniciar.Text = "Reiniciar";
            this.btn_reiniciar.UseVisualStyleBackColor = true;
            this.btn_reiniciar.Click += new System.EventHandler(this.btn_reiniciar_Click);
            // 
            // img_carro
            // 
            this.img_carro.Image = global::Componentes.Properties.Resources.artificial_intelligence_benefits_risk;
            this.img_carro.Location = new System.Drawing.Point(0, 144);
            this.img_carro.Name = "img_carro";
            this.img_carro.Size = new System.Drawing.Size(184, 152);
            this.img_carro.TabIndex = 4;
            this.img_carro.TabStop = false;
            // 
            // btn_iniciarCarro
            // 
            btn_iniciarCarro.Location = new System.Drawing.Point(0, 96);
            btn_iniciarCarro.Name = "btn_iniciarCarro";
            btn_iniciarCarro.Size = new System.Drawing.Size(152, 23);
            btn_iniciarCarro.TabIndex = 5;
            btn_iniciarCarro.Text = "Iniciar Carro";
            btn_iniciarCarro.UseVisualStyleBackColor = true;
            btn_iniciarCarro.Click += new System.EventHandler(this.btn_iniciarCarro_Click);
            // 
            // btn_pararCarro
            // 
            this.btn_pararCarro.Location = new System.Drawing.Point(168, 96);
            this.btn_pararCarro.Name = "btn_pararCarro";
            this.btn_pararCarro.Size = new System.Drawing.Size(152, 23);
            this.btn_pararCarro.TabIndex = 6;
            this.btn_pararCarro.Text = "Parar Carro";
            this.btn_pararCarro.UseVisualStyleBackColor = true;
            this.btn_pararCarro.Click += new System.EventHandler(this.btn_pararCarro_Click);
            // 
            // timer_carro
            // 
            this.timer_carro.Tick += new System.EventHandler(this.timer_carro_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ini: 12 - Fim: 620";
            // 
            // F_Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_pararCarro);
            this.Controls.Add(btn_iniciarCarro);
            this.Controls.Add(this.img_carro);
            this.Controls.Add(this.btn_reiniciar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_parar);
            this.Controls.Add(this.btn_iniciar);
            this.Name = "F_Timer";
            this.Text = "F_Timer";
            this.Load += new System.EventHandler(this.F_Timer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_carro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.Button btn_parar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_reiniciar;
        private System.Windows.Forms.PictureBox img_carro;
        private System.Windows.Forms.Button btn_pararCarro;
        private System.Windows.Forms.Timer timer_carro;
        private System.Windows.Forms.Label label2;
    }
}