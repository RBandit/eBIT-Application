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
    public partial class AddCategory : Form
    {
        public AddCategory()
        {
            InitializeComponent();
        }

        private async void AddCategory_Load(object sender, EventArgs e)
        {
            product_categoryBindingSource.DataSource = new product_category();
        }

        private async void button_addcategory_Click(object sender, EventArgs e)
        {
            eBITEntities db = new eBITEntities();
            db.product_category.Add(product_categoryBindingSource.Current as product_category);
            int result = await db.SaveChangesAsync();
            if (result > 0)
                MessageBox.Show("Data has been entered successfully");
        }
    }
}
