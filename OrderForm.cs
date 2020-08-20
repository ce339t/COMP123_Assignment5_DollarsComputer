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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //hide the current form and show the product info form
            this.Hide();
            new ProductInfoForm().Show();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //hide the current form and call the product info form
            this.Hide();
            new ProductInfoForm().Show();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            //tax computation and display the result to tax textbox under order form
            decimal tax = Program.Product.cost *  (decimal) .13;
            taxtxtbox.Text = string.Format(tax.ToString("C2", CultureInfo.CurrentCulture));

            // total amount calculation and display the result to total text box
            decimal total = Program.Product.cost + tax;
            totaltxtbox.Text = string.Format(total.ToString("C2", CultureInfo.CurrentCulture));

            // assign and display each property value in the appropriate textbox
            pricetxtbox.Text = string.Format(Program.Product.cost.ToString("C2", CultureInfo.CurrentCulture));
            conditiontxtbox.Text = Program.Product.condition;
            platformtxtbox.Text = Program.Product.platform;
            manutxtbox.Text = Program.Product.manufacturer;
            modeltxtbox.Text = Program.Product.model;
            listsTxtBox.Text = Program.Product.screensize + "\r\n\r\n";
            listsTxtBox.Text += Program.Product.RAM_size + "\r\n\r\n";
            listsTxtBox.Text += Program.Product.CPU_brand + "\r\n\r\n";
            listsTxtBox.Text += Program.Product.CPU_type + "\r\n\r\n";
            listsTxtBox.Text += Program.Product.CPU_number + "\r\n\r\n";
            listsTxtBox.Text += Program.Product.CPU_speed + "\r\n\r\n";
            listsTxtBox.Text += Program.Product.HDD_size + "\r\n\r\n";
            listsTxtBox.Text += Program.Product.GPU_Type + "\r\n\r\n";
            listsTxtBox.Text += Program.Product.webcam + "\r\n\r\n";
            listsTxtBox.Text += Program.Product.OS;

        }

     

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //show the about form
            new AboutForm().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Finish Button: Shows a message box with the given message
            DialogResult d;
            d = MessageBox.Show(
                "Thank You for placing your order!\n\n " +
                "Your order will be processed within 7-10 businessdays.","Order Submitted");

            //if user press OK - the application will close
            if (d == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
