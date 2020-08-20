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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            new SelectForm().Show();
            this.Hide();
        }

        private void openSaveOrderButton_Click(object sender, EventArgs e)
        {
            new ProductInfoForm().Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }
    }
}
