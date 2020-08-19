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
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputersDataSet1.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet1.products);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // when 1 cell is click the entire row will be highlighted
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            

            if(e.RowIndex > 0)
            {
                nextButton.Enabled = true;
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                Program.Product.productID = Convert.ToInt16(row.Cells[0].Value.ToString());
                Program.Product.cost = (decimal)row.Cells[1].Value;
                Program.Product.manufacturer = row.Cells[2].Value.ToString();
                Program.Product.model = row.Cells[3].Value.ToString();
                Program.Product.RAM_type = row.Cells[4].Value.ToString();
                Program.Product.RAM_size = row.Cells[5].Value.ToString();
                Program.Product.displaytype = row.Cells[6].Value.ToString();
                Program.Product.screensize = row.Cells[7].Value.ToString();
                Program.Product.resolution = row.Cells[8].Value.ToString();
                Program.Product.CPU_Class = row.Cells[9].Value.ToString();
                Program.Product.CPU_brand = row.Cells[10].Value.ToString();
                Program.Product.CPU_type = row.Cells[11].Value.ToString();
                Program.Product.CPU_speed = row.Cells[12].Value.ToString();
                Program.Product.CPU_number = row.Cells[13].Value.ToString();
                Program.Product.condition = row.Cells[14].Value.ToString();
                Program.Product.OS = row.Cells[15].Value.ToString();
                Program.Product.platform = row.Cells[16].Value.ToString();
                Program.Product.HDD_size = row.Cells[17].Value.ToString();
                Program.Product.HDD_speed = row.Cells[18].Value.ToString();
                Program.Product.GPU_Type = row.Cells[19].Value.ToString();
                Program.Product.optical_drive = row.Cells[20].Value.ToString();
                Program.Product.Audio_type = row.Cells[21].Value.ToString();
                Program.Product.LAN = row.Cells[22].Value.ToString();
                Program.Product.WIFI = row.Cells[23].Value.ToString();
                Program.Product.width = row.Cells[24].Value.ToString();
                Program.Product.height = row.Cells[25].Value.ToString();
                Program.Product.depth = row.Cells[26].Value.ToString();
                Program.Product.weight = row.Cells[27].Value.ToString();
                Program.Product.moust_type = row.Cells[28].Value.ToString();
                Program.Product.power = row.Cells[29].Value.ToString();
                Program.Product.webcam = row.Cells[30].Value.ToString();


                SelectionTextBox.Text = $"{Program.Product.manufacturer} {Program.Product.model} " + string.Format(Program.Product.cost.ToString("C2", CultureInfo.CurrentCulture));
            }
            
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ProductInfoForm().Show();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
