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
    public partial class AddUser : Form
    {

        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eBITDataSet.users' table. You can move, or remove it, as needed.
            //this.usersTableAdapter.Fill(this.eBITDataSet.users);
            usersBindingSource.DataSource = new user();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            eBITEntities1 db = new eBITEntities1();
            db.users.Add(usersBindingSource.Current as user);
            int result = await db.SaveChangesAsync();
            if (result > 0)
                MessageBox.Show("Data has been entered successfully");

  
        }
    }
}
