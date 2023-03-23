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
    public partial class LogIn : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=it488group6.database.windows.net;Initial Catalog=eBIT;User ID=JenniferW;Password=Password2;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("SELECT * FROM dbo.users WHERE user_name = @user_name AND password=@password", con);
                cm.Parameters.AddWithValue("@user_name", txtUser.Text);
                cm.Parameters.AddWithValue("@password", txtPass.Text);
                con.Open();
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    MessageBox.Show("Welcome " + dr["first_name"].ToString() + " ", "Access Granted", MessageBoxButtons.OK);
                    MainForm main = new MainForm();
                    main.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password!", "Access Denied", MessageBoxButtons.OK);
                    con.Close();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtPass.Clear();
            txtUser.Clear();
        }

        private void chkPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPass.Checked == false)
               txtPass.UseSystemPasswordChar= true;
            else
                txtPass.UseSystemPasswordChar= false;   
                
        }
    }
}
