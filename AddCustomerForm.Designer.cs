namespace eBIT_Customers
{
    partial class AddCustomerForm
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
            System.Windows.Forms.Label first_nameLabel;
            System.Windows.Forms.Label last_nameLabel;
            System.Windows.Forms.Label ebay_usernameLabel;
            System.Windows.Forms.Label address_line_1Label;
            System.Windows.Forms.Label address_line_2Label;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label zipLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.eBITDataSet = new eBIT_Application.eBITDataSet();
            this.customersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new eBIT_Application.eBITDataSetTableAdapters.customersTableAdapter();
            this.tableAdapterManager = new eBIT_Application.eBITDataSetTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddCust = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.stateTextBox = new System.Windows.Forms.ComboBox();
            this.statesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eBITDataSet3 = new eBIT_Application.eBITDataSet3();
            this.first_nameTextBox = new System.Windows.Forms.TextBox();
            this.last_nameTextBox = new System.Windows.Forms.TextBox();
            this.ebay_usernameTextBox = new System.Windows.Forms.TextBox();
            this.address_line_1TextBox = new System.Windows.Forms.TextBox();
            this.address_line_2TextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.statesTableAdapter = new eBIT_Application.eBITDataSet3TableAdapters.StatesTableAdapter();
            first_nameLabel = new System.Windows.Forms.Label();
            last_nameLabel = new System.Windows.Forms.Label();
            ebay_usernameLabel = new System.Windows.Forms.Label();
            address_line_1Label = new System.Windows.Forms.Label();
            address_line_2Label = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            zipLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eBITDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBITDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // first_nameLabel
            // 
            first_nameLabel.AutoSize = true;
            first_nameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            first_nameLabel.Location = new System.Drawing.Point(13, 54);
            first_nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            first_nameLabel.Name = "first_nameLabel";
            first_nameLabel.Size = new System.Drawing.Size(116, 23);
            first_nameLabel.TabIndex = 33;
            first_nameLabel.Text = "First Name:";
            // 
            // last_nameLabel
            // 
            last_nameLabel.AutoSize = true;
            last_nameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            last_nameLabel.Location = new System.Drawing.Point(446, 54);
            last_nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            last_nameLabel.Name = "last_nameLabel";
            last_nameLabel.Size = new System.Drawing.Size(120, 23);
            last_nameLabel.TabIndex = 35;
            last_nameLabel.Text = "Last Name:";
            // 
            // ebay_usernameLabel
            // 
            ebay_usernameLabel.AutoSize = true;
            ebay_usernameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ebay_usernameLabel.Location = new System.Drawing.Point(13, 102);
            ebay_usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ebay_usernameLabel.Name = "ebay_usernameLabel";
            ebay_usernameLabel.Size = new System.Drawing.Size(171, 23);
            ebay_usernameLabel.TabIndex = 37;
            ebay_usernameLabel.Text = "ebay Username:";
            // 
            // address_line_1Label
            // 
            address_line_1Label.AutoSize = true;
            address_line_1Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            address_line_1Label.Location = new System.Drawing.Point(13, 143);
            address_line_1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            address_line_1Label.Name = "address_line_1Label";
            address_line_1Label.Size = new System.Drawing.Size(153, 23);
            address_line_1Label.TabIndex = 39;
            address_line_1Label.Text = "Address Line 1:";
            // 
            // address_line_2Label
            // 
            address_line_2Label.AutoSize = true;
            address_line_2Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            address_line_2Label.Location = new System.Drawing.Point(13, 187);
            address_line_2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            address_line_2Label.Name = "address_line_2Label";
            address_line_2Label.Size = new System.Drawing.Size(153, 23);
            address_line_2Label.TabIndex = 41;
            address_line_2Label.Text = "Address Line 2:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cityLabel.Location = new System.Drawing.Point(-97, 167);
            cityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(49, 23);
            cityLabel.TabIndex = 43;
            cityLabel.Text = "city:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stateLabel.Location = new System.Drawing.Point(282, 231);
            stateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(66, 23);
            stateLabel.TabIndex = 45;
            stateLabel.Text = "State:";
            // 
            // zipLabel
            // 
            zipLabel.AutoSize = true;
            zipLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            zipLabel.Location = new System.Drawing.Point(-93, 211);
            zipLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            zipLabel.Name = "zipLabel";
            zipLabel.Size = new System.Drawing.Size(41, 23);
            zipLabel.TabIndex = 47;
            zipLabel.Text = "zip:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phoneLabel.Location = new System.Drawing.Point(690, 231);
            phoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(77, 23);
            phoneLabel.TabIndex = 49;
            phoneLabel.Text = "Phone:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(487, 102);
            emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(67, 23);
            emailLabel.TabIndex = 51;
            emailLabel.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(512, 231);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(42, 23);
            label1.TabIndex = 53;
            label1.Text = "Zip:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(13, 231);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(52, 23);
            label2.TabIndex = 54;
            label2.Text = "City:";
            // 
            // eBITDataSet
            // 
            this.eBITDataSet.DataSetName = "eBITDataSet";
            this.eBITDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource1
            // 
            this.customersBindingSource1.DataMember = "customers";
            this.customersBindingSource1.DataSource = this.eBITDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.customersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.inventoryTableAdapter = null;
            this.tableAdapterManager.ordersTableAdapter = null;
            this.tableAdapterManager.product_categoryTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = eBIT_Application.eBITDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddCust);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 360);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 76);
            this.panel1.TabIndex = 32;
            // 
            // btnAddCust
            // 
            this.btnAddCust.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddCust.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddCust.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCust.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAddCust.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnAddCust.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCust.Location = new System.Drawing.Point(411, 5);
            this.btnAddCust.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(129, 61);
            this.btnAddCust.TabIndex = 11;
            this.btnAddCust.Text = "SUBMIT";
            this.btnAddCust.UseVisualStyleBackColor = false;
            this.btnAddCust.Click += new System.EventHandler(this.btnAddCust_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(967, 78);
            this.panel2.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(675, 47);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter Customer Information Below";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.stateTextBox);
            this.panel3.Controls.Add(label2);
            this.panel3.Controls.Add(label1);
            this.panel3.Controls.Add(first_nameLabel);
            this.panel3.Controls.Add(this.first_nameTextBox);
            this.panel3.Controls.Add(last_nameLabel);
            this.panel3.Controls.Add(this.last_nameTextBox);
            this.panel3.Controls.Add(ebay_usernameLabel);
            this.panel3.Controls.Add(this.ebay_usernameTextBox);
            this.panel3.Controls.Add(address_line_1Label);
            this.panel3.Controls.Add(this.address_line_1TextBox);
            this.panel3.Controls.Add(address_line_2Label);
            this.panel3.Controls.Add(this.address_line_2TextBox);
            this.panel3.Controls.Add(cityLabel);
            this.panel3.Controls.Add(this.cityTextBox);
            this.panel3.Controls.Add(stateLabel);
            this.panel3.Controls.Add(zipLabel);
            this.panel3.Controls.Add(this.zipTextBox);
            this.panel3.Controls.Add(phoneLabel);
            this.panel3.Controls.Add(this.phoneTextBox);
            this.panel3.Controls.Add(emailLabel);
            this.panel3.Controls.Add(this.emailTextBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(967, 282);
            this.panel3.TabIndex = 34;
            // 
            // stateTextBox
            // 
            this.stateTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.stateTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.customersBindingSource1, "state", true));
            this.stateTextBox.DataSource = this.statesBindingSource;
            this.stateTextBox.DisplayMember = "State";
            this.stateTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateTextBox.FormattingEnabled = true;
            this.stateTextBox.Location = new System.Drawing.Point(353, 228);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(152, 31);
            this.stateTextBox.TabIndex = 8;
            this.stateTextBox.ValueMember = "Abbreviation";
            // 
            // statesBindingSource
            // 
            this.statesBindingSource.DataMember = "States";
            this.statesBindingSource.DataSource = this.eBITDataSet3;
            // 
            // eBITDataSet3
            // 
            this.eBITDataSet3.DataSetName = "eBITDataSet3";
            this.eBITDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // first_nameTextBox
            // 
            this.first_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "first_name", true));
            this.first_nameTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_nameTextBox.Location = new System.Drawing.Point(137, 51);
            this.first_nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.first_nameTextBox.Name = "first_nameTextBox";
            this.first_nameTextBox.Size = new System.Drawing.Size(276, 32);
            this.first_nameTextBox.TabIndex = 1;
            // 
            // last_nameTextBox
            // 
            this.last_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "last_name", true));
            this.last_nameTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_nameTextBox.Location = new System.Drawing.Point(574, 51);
            this.last_nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.last_nameTextBox.Name = "last_nameTextBox";
            this.last_nameTextBox.Size = new System.Drawing.Size(366, 32);
            this.last_nameTextBox.TabIndex = 2;
            // 
            // ebay_usernameTextBox
            // 
            this.ebay_usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "ebay_username", true));
            this.ebay_usernameTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ebay_usernameTextBox.Location = new System.Drawing.Point(192, 99);
            this.ebay_usernameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ebay_usernameTextBox.Name = "ebay_usernameTextBox";
            this.ebay_usernameTextBox.Size = new System.Drawing.Size(261, 32);
            this.ebay_usernameTextBox.TabIndex = 3;
            // 
            // address_line_1TextBox
            // 
            this.address_line_1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "address_line_1", true));
            this.address_line_1TextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_line_1TextBox.Location = new System.Drawing.Point(174, 140);
            this.address_line_1TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.address_line_1TextBox.Name = "address_line_1TextBox";
            this.address_line_1TextBox.Size = new System.Drawing.Size(766, 32);
            this.address_line_1TextBox.TabIndex = 5;
            // 
            // address_line_2TextBox
            // 
            this.address_line_2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "address_line_2", true));
            this.address_line_2TextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_line_2TextBox.Location = new System.Drawing.Point(174, 184);
            this.address_line_2TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.address_line_2TextBox.Name = "address_line_2TextBox";
            this.address_line_2TextBox.Size = new System.Drawing.Size(766, 32);
            this.address_line_2TextBox.TabIndex = 6;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "city", true));
            this.cityTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityTextBox.Location = new System.Drawing.Point(73, 227);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(201, 32);
            this.cityTextBox.TabIndex = 7;
            // 
            // zipTextBox
            // 
            this.zipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "zip", true));
            this.zipTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipTextBox.Location = new System.Drawing.Point(563, 228);
            this.zipTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(119, 32);
            this.zipTextBox.TabIndex = 9;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "phone", true));
            this.phoneTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.Location = new System.Drawing.Point(775, 228);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(165, 32);
            this.phoneTextBox.TabIndex = 10;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(573, 99);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(367, 32);
            this.emailTextBox.TabIndex = 4;
            // 
            // statesTableAdapter
            // 
            this.statesTableAdapter.ClearBeforeFill = true;
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 436);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddCustomerForm";
            this.Text = "Add Customer";
            this.Load += new System.EventHandler(this.AddCustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eBITDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBITDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private eBIT_Application.eBITDataSet eBITDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource1;
        private eBIT_Application.eBITDataSetTableAdapters.customersTableAdapter customersTableAdapter;
        private eBIT_Application.eBITDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox first_nameTextBox;
        private System.Windows.Forms.TextBox last_nameTextBox;
        private System.Windows.Forms.TextBox ebay_usernameTextBox;
        private System.Windows.Forms.TextBox address_line_1TextBox;
        private System.Windows.Forms.TextBox address_line_2TextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button btnAddCust;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox stateTextBox;
        private eBIT_Application.eBITDataSet3 eBITDataSet3;
        private System.Windows.Forms.BindingSource statesBindingSource;
        private eBIT_Application.eBITDataSet3TableAdapters.StatesTableAdapter statesTableAdapter;
    }
}