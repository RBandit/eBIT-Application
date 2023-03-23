namespace eBIT_Application
{
    partial class AddSale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label customer_idLabel;
            System.Windows.Forms.Label sale_priceLabel;
            System.Windows.Forms.Label order_quantityLabel;
            System.Windows.Forms.Label taxLabel;
            System.Windows.Forms.Label ship_costLabel;
            System.Windows.Forms.Label order_totalLabel;
            System.Windows.Forms.Label trackingLabel;
            this.button_addsale = new System.Windows.Forms.Button();
            this.eBITDataSet = new eBIT_Application.eBITDataSet();
            this.tableAdapterManager = new eBIT_Application.eBITDataSetTableAdapters.TableAdapterManager();
            this.ordersTableAdapter = new eBIT_Application.eBITDataSetTableAdapters.ordersTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sale_priceTextBox = new System.Windows.Forms.TextBox();
            this.order_quantityTextBox = new System.Windows.Forms.TextBox();
            this.taxTextBox = new System.Windows.Forms.TextBox();
            this.ship_costTextBox = new System.Windows.Forms.TextBox();
            this.order_totalTextBox = new System.Windows.Forms.TextBox();
            this.trackingTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eBITDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new eBIT_Application.eBITDataSetTableAdapters.customersTableAdapter();
            customer_idLabel = new System.Windows.Forms.Label();
            sale_priceLabel = new System.Windows.Forms.Label();
            order_quantityLabel = new System.Windows.Forms.Label();
            taxLabel = new System.Windows.Forms.Label();
            ship_costLabel = new System.Windows.Forms.Label();
            order_totalLabel = new System.Windows.Forms.Label();
            trackingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eBITDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBITDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // customer_idLabel
            // 
            customer_idLabel.AutoSize = true;
            customer_idLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customer_idLabel.Location = new System.Drawing.Point(31, 28);
            customer_idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customer_idLabel.Name = "customer_idLabel";
            customer_idLabel.Size = new System.Drawing.Size(136, 23);
            customer_idLabel.TabIndex = 72;
            customer_idLabel.Text = "Customer ID:";
            // 
            // sale_priceLabel
            // 
            sale_priceLabel.AutoSize = true;
            sale_priceLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sale_priceLabel.Location = new System.Drawing.Point(349, 28);
            sale_priceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sale_priceLabel.Name = "sale_priceLabel";
            sale_priceLabel.Size = new System.Drawing.Size(111, 23);
            sale_priceLabel.TabIndex = 74;
            sale_priceLabel.Text = "Sale Price:";
            // 
            // order_quantityLabel
            // 
            order_quantityLabel.AutoSize = true;
            order_quantityLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            order_quantityLabel.Location = new System.Drawing.Point(31, 70);
            order_quantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            order_quantityLabel.Name = "order_quantityLabel";
            order_quantityLabel.Size = new System.Drawing.Size(160, 23);
            order_quantityLabel.TabIndex = 76;
            order_quantityLabel.Text = "Order Quantity:";
            // 
            // taxLabel
            // 
            taxLabel.AutoSize = true;
            taxLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            taxLabel.Location = new System.Drawing.Point(349, 114);
            taxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            taxLabel.Name = "taxLabel";
            taxLabel.Size = new System.Drawing.Size(48, 23);
            taxLabel.TabIndex = 78;
            taxLabel.Text = "Tax:";
            // 
            // ship_costLabel
            // 
            ship_costLabel.AutoSize = true;
            ship_costLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ship_costLabel.Location = new System.Drawing.Point(349, 74);
            ship_costLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ship_costLabel.Name = "ship_costLabel";
            ship_costLabel.Size = new System.Drawing.Size(106, 23);
            ship_costLabel.TabIndex = 80;
            ship_costLabel.Text = "Ship Cost:";
            // 
            // order_totalLabel
            // 
            order_totalLabel.AutoSize = true;
            order_totalLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            order_totalLabel.Location = new System.Drawing.Point(349, 154);
            order_totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            order_totalLabel.Name = "order_totalLabel";
            order_totalLabel.Size = new System.Drawing.Size(122, 23);
            order_totalLabel.TabIndex = 82;
            order_totalLabel.Text = "Order Total:";
            // 
            // trackingLabel
            // 
            trackingLabel.AutoSize = true;
            trackingLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            trackingLabel.Location = new System.Drawing.Point(31, 116);
            trackingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            trackingLabel.Name = "trackingLabel";
            trackingLabel.Size = new System.Drawing.Size(98, 23);
            trackingLabel.TabIndex = 84;
            trackingLabel.Text = "Tracking:";
            // 
            // button_addsale
            // 
            this.button_addsale.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_addsale.BackColor = System.Drawing.Color.SteelBlue;
            this.button_addsale.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addsale.Location = new System.Drawing.Point(256, 14);
            this.button_addsale.Margin = new System.Windows.Forms.Padding(4);
            this.button_addsale.Name = "button_addsale";
            this.button_addsale.Size = new System.Drawing.Size(143, 46);
            this.button_addsale.TabIndex = 8;
            this.button_addsale.Text = "SUBMIT";
            this.button_addsale.UseVisualStyleBackColor = false;
            this.button_addsale.Click += new System.EventHandler(this.button_addsale_Click);
            // 
            // eBITDataSet
            // 
            this.eBITDataSet.DataSetName = "eBITDataSet";
            this.eBITDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.customersTableAdapter = null;
            this.tableAdapterManager.inventoryTableAdapter = null;
            this.tableAdapterManager.ordersTableAdapter = this.ordersTableAdapter;
            this.tableAdapterManager.product_categoryTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = eBIT_Application.eBITDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 62);
            this.panel1.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(599, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Order Information Below";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_addsale);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 265);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 73);
            this.panel2.TabIndex = 34;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "orders";
            this.ordersBindingSource.DataSource = this.eBITDataSet;
            // 
            // sale_priceTextBox
            // 
            this.sale_priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "sale_price", true));
            this.sale_priceTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sale_priceTextBox.Location = new System.Drawing.Point(478, 25);
            this.sale_priceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.sale_priceTextBox.Name = "sale_priceTextBox";
            this.sale_priceTextBox.Size = new System.Drawing.Size(125, 32);
            this.sale_priceTextBox.TabIndex = 2;
            // 
            // order_quantityTextBox
            // 
            this.order_quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "order_quantity", true));
            this.order_quantityTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_quantityTextBox.Location = new System.Drawing.Point(199, 67);
            this.order_quantityTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.order_quantityTextBox.Name = "order_quantityTextBox";
            this.order_quantityTextBox.Size = new System.Drawing.Size(103, 32);
            this.order_quantityTextBox.TabIndex = 3;
            // 
            // taxTextBox
            // 
            this.taxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "tax", true));
            this.taxTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxTextBox.Location = new System.Drawing.Point(478, 111);
            this.taxTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.taxTextBox.Name = "taxTextBox";
            this.taxTextBox.Size = new System.Drawing.Size(125, 32);
            this.taxTextBox.TabIndex = 6;
            // 
            // ship_costTextBox
            // 
            this.ship_costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ship_cost", true));
            this.ship_costTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ship_costTextBox.Location = new System.Drawing.Point(478, 71);
            this.ship_costTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ship_costTextBox.Name = "ship_costTextBox";
            this.ship_costTextBox.Size = new System.Drawing.Size(125, 32);
            this.ship_costTextBox.TabIndex = 4;
            // 
            // order_totalTextBox
            // 
            this.order_totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "order_total", true));
            this.order_totalTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_totalTextBox.Location = new System.Drawing.Point(478, 154);
            this.order_totalTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.order_totalTextBox.Name = "order_totalTextBox";
            this.order_totalTextBox.Size = new System.Drawing.Size(125, 32);
            this.order_totalTextBox.TabIndex = 7;
            // 
            // trackingTextBox
            // 
            this.trackingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "tracking", true));
            this.trackingTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackingTextBox.Location = new System.Drawing.Point(137, 113);
            this.trackingTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.trackingTextBox.Name = "trackingTextBox";
            this.trackingTextBox.Size = new System.Drawing.Size(165, 32);
            this.trackingTextBox.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(customer_idLabel);
            this.panel3.Controls.Add(this.trackingTextBox);
            this.panel3.Controls.Add(trackingLabel);
            this.panel3.Controls.Add(sale_priceLabel);
            this.panel3.Controls.Add(this.order_totalTextBox);
            this.panel3.Controls.Add(this.sale_priceTextBox);
            this.panel3.Controls.Add(order_totalLabel);
            this.panel3.Controls.Add(order_quantityLabel);
            this.panel3.Controls.Add(this.ship_costTextBox);
            this.panel3.Controls.Add(this.order_quantityTextBox);
            this.panel3.Controls.Add(ship_costLabel);
            this.panel3.Controls.Add(taxLabel);
            this.panel3.Controls.Add(this.taxTextBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(650, 203);
            this.panel3.TabIndex = 86;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ordersBindingSource, "customer_id", true));
            this.comboBox1.DataSource = this.customersBindingSource;
            this.comboBox1.DisplayMember = "customer_id";
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(174, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(126, 31);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "customer_id";
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "customers";
            this.customersBindingSource.DataSource = this.eBITDataSetBindingSource;
            // 
            // eBITDataSetBindingSource
            // 
            this.eBITDataSetBindingSource.DataSource = this.eBITDataSet;
            this.eBITDataSetBindingSource.Position = 0;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // AddSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 338);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Sale";
            this.Load += new System.EventHandler(this.AddSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eBITDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBITDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_addsale;
        private eBITDataSet eBITDataSet;
        private eBITDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private eBITDataSetTableAdapters.ordersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private System.Windows.Forms.TextBox sale_priceTextBox;
        private System.Windows.Forms.TextBox order_quantityTextBox;
        private System.Windows.Forms.TextBox taxTextBox;
        private System.Windows.Forms.TextBox ship_costTextBox;
        private System.Windows.Forms.TextBox order_totalTextBox;
        private System.Windows.Forms.TextBox trackingTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource eBITDataSetBindingSource;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private eBITDataSetTableAdapters.customersTableAdapter customersTableAdapter;
    }
}