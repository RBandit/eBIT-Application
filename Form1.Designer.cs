namespace eBIT_Application
{
    partial class AddInventory
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
            System.Windows.Forms.Label category_idLabel;
            System.Windows.Forms.Label item_costLabel;
            System.Windows.Forms.Label item_quantityLabel;
            System.Windows.Forms.Label list_priceLabel;
            System.Windows.Forms.Label sale_endLabel;
            System.Windows.Forms.Label sale_startLabel;
            this.sale_startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.item_descLabel = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.list_priceTextBox = new System.Windows.Forms.TextBox();
            this.item_costTextBox = new System.Windows.Forms.TextBox();
            this.item_descTextBox = new System.Windows.Forms.TextBox();
            this.item_quantityTextBox = new System.Windows.Forms.TextBox();
            this.productcategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eBITDataSet = new eBIT_Application.eBITDataSet();
            this.product_categoryTableAdapter = new eBIT_Application.eBITDataSetTableAdapters.product_categoryTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.productcategoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKinventorycateg68487DD7BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryTableAdapter = new eBIT_Application.eBITDataSetTableAdapters.inventoryTableAdapter();
            this.sale_endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            category_idLabel = new System.Windows.Forms.Label();
            item_costLabel = new System.Windows.Forms.Label();
            item_quantityLabel = new System.Windows.Forms.Label();
            list_priceLabel = new System.Windows.Forms.Label();
            sale_endLabel = new System.Windows.Forms.Label();
            sale_startLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productcategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBITDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productcategoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKinventorycateg68487DD7BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // category_idLabel
            // 
            category_idLabel.AutoSize = true;
            category_idLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            category_idLabel.Location = new System.Drawing.Point(12, 135);
            category_idLabel.Name = "category_idLabel";
            category_idLabel.Size = new System.Drawing.Size(108, 23);
            category_idLabel.TabIndex = 1;
            category_idLabel.Text = "Category:";
            // 
            // item_costLabel
            // 
            item_costLabel.AutoSize = true;
            item_costLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            item_costLabel.Location = new System.Drawing.Point(12, 191);
            item_costLabel.Name = "item_costLabel";
            item_costLabel.Size = new System.Drawing.Size(59, 23);
            item_costLabel.TabIndex = 3;
            item_costLabel.Text = "Cost:";
            // 
            // item_quantityLabel
            // 
            item_quantityLabel.AutoSize = true;
            item_quantityLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            item_quantityLabel.Location = new System.Drawing.Point(331, 135);
            item_quantityLabel.Name = "item_quantityLabel";
            item_quantityLabel.Size = new System.Drawing.Size(98, 23);
            item_quantityLabel.TabIndex = 11;
            item_quantityLabel.Text = "Quantity:";
            // 
            // list_priceLabel
            // 
            list_priceLabel.AutoSize = true;
            list_priceLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            list_priceLabel.Location = new System.Drawing.Point(238, 191);
            list_priceLabel.Name = "list_priceLabel";
            list_priceLabel.Size = new System.Drawing.Size(101, 23);
            list_priceLabel.TabIndex = 13;
            list_priceLabel.Text = "Sell Price:";
            // 
            // sale_endLabel
            // 
            sale_endLabel.AutoSize = true;
            sale_endLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sale_endLabel.Location = new System.Drawing.Point(12, 300);
            sale_endLabel.Name = "sale_endLabel";
            sale_endLabel.Size = new System.Drawing.Size(100, 23);
            sale_endLabel.TabIndex = 15;
            sale_endLabel.Text = "Sale End:";
            // 
            // sale_startLabel
            // 
            sale_startLabel.AutoSize = true;
            sale_startLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sale_startLabel.Location = new System.Drawing.Point(12, 252);
            sale_startLabel.Name = "sale_startLabel";
            sale_startLabel.Size = new System.Drawing.Size(107, 23);
            sale_startLabel.TabIndex = 17;
            sale_startLabel.Text = "Sale Start:";
            // 
            // sale_startDateTimePicker
            // 
            this.sale_startDateTimePicker.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sale_startDateTimePicker.Checked = false;
            this.sale_startDateTimePicker.CustomFormat = "  ";
            this.sale_startDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.inventoryBindingSource, "sale_start", true));
            this.sale_startDateTimePicker.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sale_startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.sale_startDateTimePicker.Location = new System.Drawing.Point(141, 248);
            this.sale_startDateTimePicker.Name = "sale_startDateTimePicker";
            this.sale_startDateTimePicker.Size = new System.Drawing.Size(351, 32);
            this.sale_startDateTimePicker.TabIndex = 6;
            this.sale_startDateTimePicker.ValueChanged += new System.EventHandler(this.sale_startDateTimePicker_ValueChanged);
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataSource = typeof(eBIT_Application.inventory);
            // 
            // item_descLabel
            // 
            this.item_descLabel.AutoSize = true;
            this.item_descLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_descLabel.Location = new System.Drawing.Point(12, 84);
            this.item_descLabel.Name = "item_descLabel";
            this.item_descLabel.Size = new System.Drawing.Size(122, 23);
            this.item_descLabel.TabIndex = 5;
            this.item_descLabel.Text = "Description:";
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(21, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(444, 39);
            this.labelTitle.TabIndex = 19;
            this.labelTitle.Text = "Enter Inventory Data Below";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonAdd.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(181, 359);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(161, 63);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "SUBMIT";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // list_priceTextBox
            // 
            this.list_priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "list_price", true));
            this.list_priceTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_priceTextBox.Location = new System.Drawing.Point(345, 188);
            this.list_priceTextBox.Name = "list_priceTextBox";
            this.list_priceTextBox.Size = new System.Drawing.Size(147, 32);
            this.list_priceTextBox.TabIndex = 5;
            // 
            // item_costTextBox
            // 
            this.item_costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "item_cost", true));
            this.item_costTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_costTextBox.Location = new System.Drawing.Point(77, 188);
            this.item_costTextBox.Name = "item_costTextBox";
            this.item_costTextBox.Size = new System.Drawing.Size(122, 32);
            this.item_costTextBox.TabIndex = 4;
            // 
            // item_descTextBox
            // 
            this.item_descTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "item_name", true));
            this.item_descTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_descTextBox.Location = new System.Drawing.Point(151, 81);
            this.item_descTextBox.Name = "item_descTextBox";
            this.item_descTextBox.Size = new System.Drawing.Size(341, 32);
            this.item_descTextBox.TabIndex = 1;
            // 
            // item_quantityTextBox
            // 
            this.item_quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "item_quantity", true));
            this.item_quantityTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_quantityTextBox.Location = new System.Drawing.Point(442, 132);
            this.item_quantityTextBox.Name = "item_quantityTextBox";
            this.item_quantityTextBox.Size = new System.Drawing.Size(50, 32);
            this.item_quantityTextBox.TabIndex = 3;
            // 
            // productcategoryBindingSource
            // 
            this.productcategoryBindingSource.DataMember = "product_category";
            this.productcategoryBindingSource.DataSource = this.eBITDataSet;
            // 
            // eBITDataSet
            // 
            this.eBITDataSet.DataSetName = "eBITDataSet";
            this.eBITDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // product_categoryTableAdapter
            // 
            this.product_categoryTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.inventoryBindingSource, "category_id", true));
            this.comboBox1.DataSource = this.productcategoryBindingSource1;
            this.comboBox1.DisplayMember = "category_name";
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(126, 134);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 29);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "category_id";
            // 
            // productcategoryBindingSource1
            // 
            this.productcategoryBindingSource1.DataMember = "product_category";
            this.productcategoryBindingSource1.DataSource = this.eBITDataSet;
            // 
            // fKinventorycateg68487DD7BindingSource
            // 
            this.fKinventorycateg68487DD7BindingSource.DataMember = "FK__inventory__categ__68487DD7";
            this.fKinventorycateg68487DD7BindingSource.DataSource = this.productcategoryBindingSource;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // sale_endDateTimePicker
            // 
            this.sale_endDateTimePicker.Checked = false;
            this.sale_endDateTimePicker.CustomFormat = "    ";
            this.sale_endDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.inventoryBindingSource, "sale_end", true));
            this.sale_endDateTimePicker.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sale_endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.sale_endDateTimePicker.Location = new System.Drawing.Point(141, 296);
            this.sale_endDateTimePicker.Name = "sale_endDateTimePicker";
            this.sale_endDateTimePicker.Size = new System.Drawing.Size(351, 32);
            this.sale_endDateTimePicker.TabIndex = 7;
            this.sale_endDateTimePicker.ValueChanged += new System.EventHandler(this.sale_endDateTimePicker_ValueChanged);
            // 
            // AddInventory
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 457);
            this.Controls.Add(this.sale_endDateTimePicker);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(category_idLabel);
            this.Controls.Add(item_costLabel);
            this.Controls.Add(this.item_costTextBox);
            this.Controls.Add(this.item_descLabel);
            this.Controls.Add(this.item_descTextBox);
            this.Controls.Add(item_quantityLabel);
            this.Controls.Add(this.item_quantityTextBox);
            this.Controls.Add(list_priceLabel);
            this.Controls.Add(this.list_priceTextBox);
            this.Controls.Add(sale_endLabel);
            this.Controls.Add(sale_startLabel);
            this.Controls.Add(this.sale_startDateTimePicker);
            this.Name = "AddInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Inventory";
            this.Load += new System.EventHandler(this.AddInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productcategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBITDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productcategoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKinventorycateg68487DD7BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label item_descLabel;
        private System.Windows.Forms.TextBox list_priceTextBox;
        private System.Windows.Forms.TextBox item_costTextBox;
        private System.Windows.Forms.TextBox item_descTextBox;
        private System.Windows.Forms.TextBox item_quantityTextBox;
        private eBITDataSet eBITDataSet;
        private System.Windows.Forms.BindingSource productcategoryBindingSource;
        private eBITDataSetTableAdapters.product_categoryTableAdapter product_categoryTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource fKinventorycateg68487DD7BindingSource;
        private eBITDataSetTableAdapters.inventoryTableAdapter inventoryTableAdapter;
        private System.Windows.Forms.BindingSource productcategoryBindingSource1;
        private System.Windows.Forms.DateTimePicker sale_startDateTimePicker;
        private System.Windows.Forms.DateTimePicker sale_endDateTimePicker;
    }
}

