using eBIT_Application;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBIT_Customers
{
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();
        }
        private async void AddCustomerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eBITDataSet3.States' table. You can move, or remove it, as needed.
            this.statesTableAdapter.Fill(this.eBITDataSet3.States);
            customersBindingSource1.DataSource = new customer();

        }

        private async void btnAddCust_Click(object sender, EventArgs e)
        {

            eBITEntities1 db = new eBITEntities1();
            db.customers.Add(customersBindingSource1.Current as customer);
            int result = await db.SaveChangesAsync();
            if (result > 0)
                MessageBox.Show("Data has been entered successfully");
            Clear();
        }



        public void Clear()
        {
            first_nameTextBox.Clear();
            last_nameTextBox.Clear();
            ebay_usernameTextBox.Clear();
            address_line_1TextBox.Clear();
            address_line_2TextBox.Clear();
            cityTextBox.Clear();
            stateTextBox.ResetText();
            zipTextBox.Clear();
            emailTextBox.Clear();
            phoneTextBox.Clear();
        }
    }
}
