using eBIT_Customers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBIT_Application
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
                ProductForm newMDIChild = new ProductForm();
                // Set the Parent Form of the Child window.
                newMDIChild.MdiParent = this;
                newMDIChild.ClientSize = new System.Drawing.Size(2000, 800);
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                newMDIChild.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                newMDIChild.Dock = DockStyle.Fill;
                
                // Display the new form.
                newMDIChild.Show();
            }
            else
            {
                ProductForm newMDIChild = new ProductForm();
                // Set the Parent Form of the Child window.
                newMDIChild.MdiParent = this;

                newMDIChild.ClientSize = new System.Drawing.Size(2000, 800);
                this.WindowState= System.Windows.Forms.FormWindowState.Maximized;
                newMDIChild.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                newMDIChild.Dock = DockStyle.Fill;

                // Display the new form.
                newMDIChild.Show();
            }
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
                UserForm newMDIChild = new UserForm();
                newMDIChild.MdiParent = this;

                newMDIChild.ClientSize = new System.Drawing.Size(2000, 800);
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                newMDIChild.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                newMDIChild.Dock = DockStyle.Fill;

                newMDIChild.Show();
            }
            else
            {
                UserForm newMDIChild = new UserForm();
                newMDIChild.MdiParent = this;

                newMDIChild.ClientSize = new System.Drawing.Size(2000, 800);
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                newMDIChild.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                newMDIChild.Dock = DockStyle.Fill;

                newMDIChild.Show();
            }
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
                ViewCategory newMDIChild = new ViewCategory();
                newMDIChild.MdiParent = this;

                newMDIChild.ClientSize = new System.Drawing.Size(2000, 800);
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                newMDIChild.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                newMDIChild.Dock = DockStyle.Fill;

                newMDIChild.Show();
            }
            else
            {
                ViewCategory newMDIChild = new ViewCategory();
                newMDIChild.MdiParent = this;

                newMDIChild.ClientSize = new System.Drawing.Size(2000, 800);
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                newMDIChild.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                newMDIChild.Dock = DockStyle.Fill;

                newMDIChild.Show();
            }

        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
                ViewOrders newMDIChild = new ViewOrders();
                newMDIChild.MdiParent = this;

                newMDIChild.ClientSize = new System.Drawing.Size(2000, 800);
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                newMDIChild.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                newMDIChild.Dock = DockStyle.Fill;

                newMDIChild.Show();
            }
            else
            {
                ViewOrders newMDIChild = new ViewOrders();
                newMDIChild.MdiParent = this;

                newMDIChild.ClientSize = new System.Drawing.Size(2000, 800);
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                newMDIChild.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                newMDIChild.Dock = DockStyle.Fill;

                newMDIChild.Show();
            }
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
                ViewCustomer newMDIChild = new ViewCustomer();
                newMDIChild.MdiParent = this;

                newMDIChild.ClientSize = new System.Drawing.Size(2000, 800);
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                newMDIChild.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                newMDIChild.Dock = DockStyle.Fill;

                newMDIChild.Show();
            }
            else
            {
                ViewOrders newMDIChild = new ViewOrders();
                newMDIChild.MdiParent = this;

                newMDIChild.ClientSize = new System.Drawing.Size(2000, 800);
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                newMDIChild.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                newMDIChild.Dock = DockStyle.Fill;

                newMDIChild.Show();
            }
        }
    }
}
