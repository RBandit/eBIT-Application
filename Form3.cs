using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBIT_Application
{
    public partial class ViewCategory : Form
    {
        public ViewCategory()
        {
            InitializeComponent();
        }

        private eBIT_Application.eBITEntities1 dbcontext = new eBIT_Application.eBITEntities1();

        private void ViewCategory_Load(object sender, EventArgs e)
        {
            dbcontext.inventories.Load();
            
            comboBox1.SelectedIndex = 0;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    inventoryBindingSource.DataSource = dbcontext.inventories.Local
                        .Where(inventory => inventory.product_category.category_id == 1)
                        .OrderBy(inventory => inventory.item_id);
                    break;
                case 1:
                    inventoryBindingSource.DataSource = dbcontext.inventories.Local
                        .Where(inventory => inventory.product_category.category_id == 2)
                        .OrderBy(inventory => inventory.item_id);
                    break;
                case 2:
                    inventoryBindingSource.DataSource = dbcontext.inventories.Local
                                .Where(inventory => inventory.product_category.category_id == 3)
                                .OrderBy(inventory => inventory.item_id);
                    break;

                case 3:
                    inventoryBindingSource.DataSource = dbcontext.inventories.Local
                                .Where(inventory => inventory.product_category.category_id == 4)
                                .OrderBy(inventory => inventory.item_id);
                    break;

                case 4:
                    inventoryBindingSource.DataSource = dbcontext.inventories.Local
                        .Where(inventory => inventory.product_category.category_id == 5)
                        .OrderBy(inventory => inventory.item_id);
                    break;
                case 5:
                    inventoryBindingSource.DataSource = dbcontext.inventories.Local
                        .Where(inventory => inventory.product_category.category_id == 6)
                        .OrderBy(inventory => inventory.item_id);
                    break;
                case 6:
                    inventoryBindingSource.DataSource = dbcontext.inventories.Local
                        .Where(inventory => inventory.product_category.category_id == 7)
                        .OrderBy(inventory => inventory.item_id);
                    break;

                case 7:
                    inventoryBindingSource.DataSource = dbcontext.inventories.Local
                        .Where(inventory => inventory.product_category.category_id == 8)
                        .OrderBy(inventory => inventory.item_id);
                    break;

                case 8:
                    inventoryBindingSource.DataSource = dbcontext.inventories.Local
                        .Where(inventory => inventory.product_category.category_id == 9)
                        .OrderBy(inventory => inventory.item_id);
                    break;

                case 9:
                    inventoryBindingSource.DataSource = dbcontext.inventories.Local
                        .Where(inventory => inventory.product_category.category_id == 10)
                        .OrderBy(inventory => inventory.item_id);
                    break;
                case 10:
                    inventoryBindingSource.DataSource = dbcontext.inventories.Local
                        .Where(inventory => inventory.product_category.category_id == 11)
                        .OrderBy(inventory => inventory.item_id);
                    break;
                case 11:
                    inventoryBindingSource.DataSource = dbcontext.inventories.Local
                        .Where(inventory => inventory.product_category.category_id == 12)
                        .OrderBy(inventory => inventory.item_id);
                    break;
                case 12:
                    inventoryBindingSource.DataSource = dbcontext.inventories.Local
                        .Where(inventory => inventory.product_category.category_id == 13)
                        .OrderBy(inventory => inventory.item_id);
                    break;
                case 13:
                    inventoryBindingSource.DataSource = dbcontext.inventories.Local
                        .Where(inventory => inventory.product_category.category_id == 14)
                        .OrderBy(inventory => inventory.item_id);
                    break;


            }

            inventoryBindingSource.MoveFirst();
        }
    }
}
