﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class F_Principal : Form
    {
        public int num;
        public F_Principal()
        {
            InitializeComponent();
            num = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            if (tb_veiculo.Text == "") {
                MessageBox.Show("Digie um Veiculo");
                tb_veiculo.Focus();
                return;
            }
            tb_listaveiculos.Text += tb_veiculo.Text + ", ";
            //tb_listaVeiculos.Text=tb_listaVeiculos.Text + tb_veiculo.Text;

            tb_veiculo.Clear();
            tb_veiculo.Focus();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            tb_listaveiculos.Clear();
            tb_veiculo.Clear();
            tb_veiculo.Focus();

        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            F_Veiculos f_Veiculos = new F_Veiculos(tb_listaveiculos.Text,this);
            f_Veiculos.ShowDialog();
        }

        private void btn_valNum_Click(object sender, EventArgs e)
        {
            MessageBox.Show(num.ToString());
        }

        private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckBox f_CheckBox = new F_CheckBox();
            f_CheckBox.ShowDialog();
        }

        private void checkedListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckedListBox f_CheckedListBox = new F_CheckedListBox();
            f_CheckedListBox.ShowDialog();
        }

        private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_comboBox f_comboBox = new F_comboBox();
            f_comboBox.ShowDialog();
        }

        private void dateTimePickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_DateTimePicker f_DateTimePicker = new F_DateTimePicker();
            f_DateTimePicker.ShowDialog();
        }

        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ListBox f_ListBox = new F_ListBox();
            f_ListBox.ShowDialog();
        }

        private void listViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_listView f_ListView = new F_listView();
            f_ListView.ShowDialog();
        }

        private void maskedTextBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_MaskedTextBox f_MaskedTextBox = new F_MaskedTextBox();
            f_MaskedTextBox.ShowDialog();
        }

        private void monthCalendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_MonthCalendar f_MonthCalendar = new F_MonthCalendar();
            f_MonthCalendar.ShowDialog();
        }

        private void MenuNotificacoes_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name.ToString() == "tsmi_fechar")
            {
                this.Close();
            }
            else if (e.ClickedItem.Name.ToString() == "tsmi_restaurar")
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (e.ClickedItem.Name.ToString() == "tsmi_mensagem") 
            {
                MessageBox.Show("CFB Cursos - Cursos de C#");
            }
        }

        private void numericUpDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_NumericUpDown f_NumericUpDown = new F_NumericUpDown();
            f_NumericUpDown.ShowDialog();
        }

        private void pictureBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_PictureBox f_PictureBox = new F_PictureBox();
            f_PictureBox.ShowDialog();
        }

        private void progressBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ProgressBar f_ProgressBar = new F_ProgressBar();
            f_ProgressBar.ShowDialog();
        }

        private void radioButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_RadioButton f_RadioButton = new F_RadioButton();
            f_RadioButton.ShowDialog();
        }

        private void fTrackBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_TrackBar f_TrackBar = new F_TrackBar();
            f_TrackBar.ShowDialog();
        }

        private void treeViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_TreeView f_TreeView = new F_TreeView();
            f_TreeView.ShowDialog();
        }

        private void webBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_WebBrowser f_WebBrowser = new F_WebBrowser();
            f_WebBrowser.ShowDialog();
        }

        private void tabControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_TabControl f_TabControl = new F_TabControl();
            f_TabControl.ShowDialog();
        }

        private void tableLayoutPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_TableLayoutPanel f_TableLayoutPanel = new F_TableLayoutPanel();
            f_TableLayoutPanel.ShowDialog();
        }

        private void toolStripContainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ToolStripContainer f_ToolStripContainer = new F_ToolStripContainer();
            f_ToolStripContainer.ShowDialog();
        }

        private void backGroundWorkerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_BackGroundWorker f_BackGroundWorker = new F_BackGroundWorker();
            f_BackGroundWorker.ShowDialog();
        }

        private void timerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Timer f_Timer = new F_Timer();
            f_Timer.ShowDialog();
        }
    }
}
