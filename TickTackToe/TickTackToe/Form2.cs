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

    public partial class Form2 : Form
    {
        int counter = 1;
        bool turn = true;
        int turn_count = 0;
        public bool IsWinner = false;


        public Form2()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false; 
            turn_count++;
            ThereIsAWinner();

        }

        private void ThereIsAWinner()
        {
            bool IsWinner = false;

            //Check Horizontal
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                IsWinner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                IsWinner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                IsWinner = true;

            //Check Vertical
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                IsWinner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                IsWinner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                IsWinner = true;

            //Check Diagonal
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                IsWinner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled))
                IsWinner = true;

            if (IsWinner)
            {
                string winner = "";
                if (turn)
                {
                    winner = "O";
                    lblOWins.Text = (Int32.Parse(lblOWins.Text) + 1).ToString();

                }
                else
                {
                    winner = "X";
                    lblXwins.Text = (Int32.Parse(lblXwins.Text) + 1).ToString();

                }
                MessageBox.Show("The Winner is : " + winner, "Congratulations !");
                StartNewRound();
                turn_count = 0;
            }
            else
            {
                if (turn_count == 9)
                {
                    MessageBox.Show("Draw ! ");
                    lblDraw.Text = (Int32.Parse(lblDraw.Text) + 1).ToString();
                }
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to Start a new Round without Saving ?", "New Round",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                StartNewRound();

            }

        }

        private void StartNewRound()
        {
            turn = true;

            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch { }
                counter++;
            }

        }
        private void ClearResults()
        {
            lblXwins.Text = "0";
            lblOWins.Text = "0";
            lblDraw.Text = "0";
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure want to Close a Game without Saving ?", "Exit Game",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void topToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("John Andrew - 15 " + Environment.NewLine + "Pavel Ivanovski - 14" + Environment.NewLine + "Krste Petkov - 9" + Environment.NewLine + "Sandra Mandiloska - 4" + Environment.NewLine + "Vasilika Grozdanoska - 2", "Tic Tac Toe - Top Scores !");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Powered by : Marjan Kolev");
        }

        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This games allow you to play only agains your friend !" + Environment.NewLine +
                "Tic Tac Toe is a game for two players : X and O," + Environment.NewLine + " Who take turns marking the spaces in a 3×3 grid. " + Environment.NewLine + "The player who succeeds in placing three respective marks" + Environment.NewLine + " In a horizontal, vertical, or diagonal row wins the game. ");
        }

        private void resetResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearResults();
            StartNewRound();
        }

        private void newGameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 ins = new Form1();
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();
        }

        private void saveGameAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


    }
}
