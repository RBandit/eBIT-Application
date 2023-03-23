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
    public partial class AddSale : Form
    {
        public AddSale()
        {
            InitializeComponent();
        }



        private async void AddSale_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eBITDataSet.customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.eBITDataSet.customers);
            ordersBindingSource.DataSource = new order();
        }

        private async void button_addsale_Click(object sender, EventArgs e)
        {
            eBITEntities1 db = new eBITEntities1();
            db.orders.Add(ordersBindingSource.Current as order);
            int result = await db.SaveChangesAsync();
            if (result>0)
                MessageBox.Show("Data has been entered successfully");
            Clear();


        }
        public void Clear()
        {
            //customer_idTextBox.Clear();
            sale_priceTextBox.Clear();
            order_quantityTextBox.Clear();
            order_totalTextBox.Clear();
            taxTextBox.Clear();
            ship_costTextBox.Clear();
            trackingTextBox.Clear();
        }
    }
}
