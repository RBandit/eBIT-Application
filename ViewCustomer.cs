using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using eBIT_Application;
using System.Runtime.Remoting;

namespace eBIT_Customers
{
    public partial class ViewCustomer : Form
    {
       eBITDataSet _context = new eBITDataSet();

        public ViewCustomer()
        {
            InitializeComponent();
        }
       

        private void ViewCustomer_Load(object sender, EventArgs e)
        {

            this.customersTableAdapter1.Fill(eBITDataSet.customers);
            
        }

        private void picAdd_Click(object sender, EventArgs e)
        {
            AddCustomerForm form = new AddCustomerForm();
            form.ShowDialog();
        }

        private void picRefresh_Click(object sender, EventArgs e)
        {
            customersTableAdapter1.Update(eBITDataSet.customers);
            customersTableAdapter1.Fill(eBITDataSet.customers);
            customersDataGridView.Invalidate();
            customersDataGridView.Refresh();
        }
    }
}
