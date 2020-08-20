using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //select another button - hide the current form and show the select form
            this.Hide();
            new SelectForm().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //cancel button
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void selectAnotherProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //hide the current form and show the select form
            this.Hide();
            new SelectForm().Show();
        }

        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            //display each value of all properties in appropriate textbox in product info form
            productIDTextBox.Text = Program.Product.productID.ToString();
            conditionTextBox.Text = Program.Product.condition;
            costTextBox.Text = string.Format(Program.Product.cost.ToString("C2", CultureInfo.CurrentCulture));
            platFormTextBox.Text = Program.Product.platform;
            manufacturerTextBox.Text = Program.Product.manufacturer;
            OSTextBox.Text = Program.Product.OS;
            modelTextBox.Text = Program.Product.model;
            memoryTextBox.Text = Program.Product.RAM_size;
            cpuBrandTextBox.Text = Program.Product.CPU_brand;
            cpuTypeTextBox.Text = Program.Product.CPU_type;
            LCDsizeTextBox.Text = Program.Product.screensize;
            cpuNumTextBox.Text = Program.Product.CPU_number;
            cpuSpeedTextBox.Text = Program.Product.CPU_speed;
            hddTextBox.Text = Program.Product.HDD_size;
            gpuTextBox.Text = Program.Product.GPU_Type;
            webcamTextBox.Text = Program.Product.webcam;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //next button - hide the current form and show the order form
            this.Hide();
            new OrderForm().Show();
        }
    }
    }

