
namespace Componentes
{
    partial class F_TreeView
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("HRV");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("FIT");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Honda", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Golf");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Polo");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Volksvagem", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_removeSelecionado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(16, 16);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "hrv";
            treeNode1.Tag = "http://www.youtube.com/cfbcursos";
            treeNode1.Text = "HRV";
            treeNode2.Name = "fit";
            treeNode2.Text = "FIT";
            treeNode3.Name = "honda";
            treeNode3.Text = "Honda";
            treeNode4.Name = "golf";
            treeNode4.Text = "Golf";
            treeNode5.Name = "polo";
            treeNode5.Text = "Polo";
            treeNode6.Name = "volksvagem";
            treeNode6.Text = "Volksvagem";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(320, 424);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(344, 16);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(184, 23);
            this.btn_adicionar.TabIndex = 1;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(344, 40);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(184, 23);
            this.btn_remover.TabIndex = 2;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(344, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(344, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(184, 20);
            this.textBox2.TabIndex = 4;
            // 
            // btn_removeSelecionado
            // 
            this.btn_removeSelecionado.Location = new System.Drawing.Point(528, 32);
            this.btn_removeSelecionado.Name = "btn_removeSelecionado";
            this.btn_removeSelecionado.Size = new System.Drawing.Size(184, 23);
            this.btn_removeSelecionado.TabIndex = 5;
            this.btn_removeSelecionado.Text = "Remover Selecionado";
            this.btn_removeSelecionado.UseVisualStyleBackColor = true;
            this.btn_removeSelecionado.Click += new System.EventHandler(this.btn_removeSelecionado_Click);
            // 
            // F_TreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_removeSelecionado);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.treeView1);
            this.Name = "F_TreeView";
            this.Text = "F_TreeView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_removeSelecionado;
    }
}