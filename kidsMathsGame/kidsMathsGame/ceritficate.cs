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
    public partial class ceritficate : Form
    {
        public ceritficate()
        {
            InitializeComponent();
        }
        public ceritficate(string str)
        {
            InitializeComponent();
            this.txtusername.Text = str;
        }
    }
}
