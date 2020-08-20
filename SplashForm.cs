using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*COMP123 - Assignment5 -  Dollar Computer
 Created By: Christina May Pakingan
 Student#: 301121940
 Date Created: August 17, 2020
 Date Modified: August 19, 2020*/

namespace COMP123_Assignment5
{
    public partial class SplashForm : Form
    {
       
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            //start interval
                timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //after the interval, timer will be disabled. hide splashform and show the startform
                timer1.Enabled = false;
                new StartForm().Show();
                this.Hide();
            
        }
    }
}
