using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBIT_Application
{
    public partial class AddInventory : Form
    {
        public AddInventory()
        {
            InitializeComponent();
        }

        private void AddInventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eBITDataSet.inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.eBITDataSet.inventory);
            // TODO: This line of code loads data into the 'eBITDataSet.product_category' table. You can move, or remove it, as needed.
            this.product_categoryTableAdapter.Fill(this.eBITDataSet.product_category);
            inventoryBindingSource.DataSource = new inventory();
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            if ((inventoryBindingSource.Current as inventory).sale_end.ToString().Contains("1/1/0001") ||
                (inventoryBindingSource.Current as inventory).sale_start.ToString().Contains("1/1/0001") 
                 ){
                MessageBox.Show("Error: one or both date inputs are invalid");
                return;
            }

            eBITEntities1 db = new eBITEntities1();
            db.inventories.Add(inventoryBindingSource.Current as inventory);     
            
            int result = db.SaveChanges();
            if (result > 0)
                MessageBox.Show("Data has been entered successfully");
            Clear();
                       
        }

        public void Clear()
        {
            item_descTextBox.Clear();
            item_quantityTextBox.Clear();
            item_costTextBox.Clear();
            list_priceTextBox.Clear();
            comboBox1.Refresh();
            sale_endDateTimePicker.Refresh();
            sale_startDateTimePicker.Refresh();
        }
        public void SetMyCustomFormat()
        {
            sale_endDateTimePicker.Format = DateTimePickerFormat.Custom;
            sale_endDateTimePicker.CustomFormat = " ";
        }
        public void SetMyCustomFormat2()
        {
            sale_startDateTimePicker.Format = DateTimePickerFormat.Custom;
            sale_startDateTimePicker.CustomFormat = " ";
        }

        private void sale_startDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            sale_startDateTimePicker.Format = DateTimePickerFormat.Custom;
            sale_startDateTimePicker.CustomFormat = "MM/dd/yyyy";

        }

        private void sale_endDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            sale_endDateTimePicker.Format = DateTimePickerFormat.Custom;
            sale_endDateTimePicker.CustomFormat = "MM/dd/yyyy";
        }




        //private void button1_Click(object sender, EventArgs e)
        //{
        //    AddSale addSale = new AddSale();
        //    addSale.Show();
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    AddCategory addCategory = new AddCategory();
        //    addCategory.Show();
        //}

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    ViewCategory viewCategory = new ViewCategory();
        //    viewCategory.Show();
        //}
    }
}
