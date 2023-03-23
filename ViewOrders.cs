using eBIT_Application.eBITDataSetTableAdapters;
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
    public partial class ViewOrders : Form
    {
        public ViewOrders()
        {
            InitializeComponent();
        }

        private void ViewOrders_Load(object sender, EventArgs e)
        {
            this.ordersTableAdapter1.Fill(eBITDataSet.orders);
        }

        private void picRefresh_Click(object sender, EventArgs e)
        {
            ordersTableAdapter1.Update(eBITDataSet.orders);
            ordersTableAdapter1.Fill(eBITDataSet.orders);
            ordersDataGridView.Invalidate();
            ordersDataGridView.Refresh();
        }

        private void picAdd_Click(object sender, EventArgs e)
        {
            AddSale form = new AddSale();
            form.ShowDialog();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.ordersDataGridView.Update();

        }
    }
}
