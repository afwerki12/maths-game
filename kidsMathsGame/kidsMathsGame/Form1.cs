using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace kidsMathsGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you have 4 levels of the game to play\n in the first one you must pass 5 questions to" +
                " move to the next level\n on the second step you will have 5 more and the score will be 10\n on the thired stage you " +
                "will have another 5 score\non the fourth level you have to answer five more in order to " +
                "get you certifcate\nfinally you will have the conclustion of your test and the you will be awarded ");
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
C:\Users\afexg\OneDrive\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Login where UserName = '"
                + txtusername.Text + "' and Password = '" + txtpassword.Text + "'", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {

                //to pass the data from one page to another
 additionlevel1 frm2 = new additionlevel1(this.txtusername.Text);
                frm2.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("CHECK your user name or password");
            }
        }

        private void level1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("before you move \n to the next level you have to" +
                " answer at least 5 quetions correctly ");
        }

        private void level2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("before you move \n to the next level you have to" +
               " answer at least 5 quetions correctly ");
        }

        private void level3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("before you move \n to the next level you have to" +
               " answer at least 5 quetions correctly ");
        }

        private void level4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("before you move \n to the next level you have to" +
               " answer at least 5 quetions correctly ");
        }

        private void level1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("before you move \n to the next level you have to" +
               " answer at least 5 quetions correctly ");
        }

        private void level2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("before you move \n to the next level you \n have to" +
               " answer at least 5 quetions correctly ");
        }

        private void level4ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("before you move \n to the next level \n you have to" +
               " answer at least 5 quetions correctly ");
        }

        private void level3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("before you move \n to the next level\n  you have to" +
               " answer at least 5 quetions correctly ");
        }

        private void level1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("before you move \n to the next level\n  you have to" +
             " answer at least 5 quetions correctly ");
        }

        private void level2ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("before you move \n to the next level\n  you have to" +
             " answer at least 5 quetions correctly ");
        }

        private void level3ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("before you move \n to the next level\n  you have to" +
             " answer at least 5 quetions correctly ");
        }

        private void level4ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("before you move \n to the next level\n  you have to" +
             " answer at least 5 quetions correctly ");
        }

        private void devisionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void level1ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("before you move \n to the next level\n  you have to" +
             " answer at least 5 quetions correctly ");
        }

        private void level2ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("before you move \n to the next level\n  you have to" +
             " answer at least 5 quetions correctly ");
        }

        private void level3ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("before you move \n to the next level\n  you have to" +
             " answer at least 5 quetions correctly ");
        }

        private void level4ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("before you move \n to the next level\n  you have to" +
             " answer at least 5 quetions correctly ");
        }
    }
}
