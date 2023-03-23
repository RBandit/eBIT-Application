using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBIT_Application
{
    public partial class UserForm : Form
    {

        public UserForm()
        {
            InitializeComponent();
     
        }


        private void UserForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eBITDataSet1.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.eBITDataSet.users);

        }

        private void picAdd(object sender, EventArgs e)
        {
            AddUser form = new AddUser();
            form.ShowDialog();
        }

        private void picRefresh_Click(object sender, EventArgs e)
        {
            usersTableAdapter.Update(eBITDataSet.users);
            usersTableAdapter.Fill(eBITDataSet.users);
            dgvUser.Invalidate();
            dgvUser.Refresh();
        }
    }
}
