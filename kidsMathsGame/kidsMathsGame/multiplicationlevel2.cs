using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kidsMathsGame
{
    public partial class multiplicationlevel2 : Form
    {
        public int firstNumber, secondNumber, timerLeft, score;

        private void btnstrat_Click(object sender, EventArgs e)
        {
            txtaswerbox.Focus();
            txtaswerbox.SelectionStart = txtaswerbox.Text.Length;
            timerLeft = 10;
            timer1.Start();
            Random rand = new Random();
            firstNumber = rand.Next(5);
            secondNumber = rand.Next(5);
            lblfirstnumber.Text = firstNumber.ToString();
            lblsecondnumber.Text = secondNumber.ToString();
            txtaswerbox.Text = "";
            lbltimer.Text = "";

            btndon.Enabled = true;
            btnstrat.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timerLeft > 0)
            {
                timerLeft--;
                lbltimer.Text = timerLeft.ToString();
            }
            if (timerLeft == 0)
            {
                timer1.Stop();
                btndon.Enabled = false;
                btnstrat.Enabled = true;
                lbltimer.Text = "";
                txtaswerbox.Text = "time out";
                score = score - 1;
                lblactivescore.Text = score.ToString();
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            subtractionlevel2 frm2 = new subtractionlevel2(this.txtusername.Text);
            frm2.ShowDialog();
            this.Hide();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            devisionlevel2 frm2 = new devisionlevel2(this.txtusername.Text);
            frm2.ShowDialog();
            this.Hide();
        }

        public multiplicationlevel2()
        {
            InitializeComponent();
        }
        public multiplicationlevel2(string str)
        {
            InitializeComponent();
            this.txtusername.Text = str;
        }

        private void btndon_Click(object sender, EventArgs e)
        {
            if (score == 5)
            {
                string message = "congrats you passed the first  level. do you want to continue the the next page?";
                string title = "level one game over";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                    btnnext.PerformClick();
                }
                else
                {
                    // Do something  
                }
                // btndon.Visible = false;
                // btnstrat.Visible = false;
                // MessageBox.Show("congrates you finishe level one");
            }
            btndon.Enabled = false;
            btnstrat.Enabled = true;
            timer1.Stop();
            //cheking if number is correct
            int total = firstNumber * secondNumber;
            if (txtaswerbox.Text == total.ToString())
            {
                txtaswerbox.Text = "";
                txtaswerbox.Text = "correct";
                //player.controls.play();
                score = score + 1;
                if (score > 5)
                    btnnext.Visible = false;
                lblactivescore.Text = score.ToString();


            }
            else
            {
                txtaswerbox.Text = "";
                txtaswerbox.Text = "Wrong";
                score = score - 1;
                lblactivescore.Text = score.ToString();
            }
        }
    }
}
