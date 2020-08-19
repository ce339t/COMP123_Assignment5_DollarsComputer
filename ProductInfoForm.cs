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

namespace COMP123_Assignment5
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SelectForm().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void selectAnotherProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SelectForm().Show();
        }

        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
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

    }
    }

