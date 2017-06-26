using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TickTackToe
{
    public partial class Form1 : Form
    {
        private int broj;
        public Form1()
        {
            InitializeComponent();
            broj = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 ins = new Form2();
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();
            broj++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("John Andrew - 15 " + Environment.NewLine + "Pavel Ivanovski - 14" + Environment.NewLine + "Krste Petkov - 9" + Environment.NewLine + "Sandra Mandiloska - 4" + Environment.NewLine + "Vasilika Grozdanoska - 2", "Tic Tac Toe - Top Scores !");
        }
    }
}
