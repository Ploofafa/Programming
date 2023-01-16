namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomerTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ObjectOrientedPractics.Model.Classes.Address address1 = new ObjectOrientedPractics.Model.Classes.Address();
            this.RemoveCustomersButton = new System.Windows.Forms.Button();
            this.AddCustomersButton = new System.Windows.Forms.Button();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.CustomersLabel = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.SelectedCustomerLabel = new System.Windows.Forms.Label();
            this.addressControl1 = new ObjectOrientedPractics.View.Tabs.AddressControl();
            this.IsPriorityCheckBox = new System.Windows.Forms.CheckBox();
            this.DiscountsLabel = new System.Windows.Forms.Label();
            this.DiscountsListBox = new System.Windows.Forms.ListBox();
            this.AddDiscountButton = new System.Windows.Forms.Button();
            this.RemoveDiscountButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RemoveCustomersButton
            // 
            this.RemoveCustomersButton.Location = new System.Drawing.Point(135, 422);
            this.RemoveCustomersButton.Name = "RemoveCustomersButton";
            this.RemoveCustomersButton.Size = new System.Drawing.Size(130, 39);
            this.RemoveCustomersButton.TabIndex = 4;
            this.RemoveCustomersButton.Text = "Remove";
            this.RemoveCustomersButton.UseVisualStyleBackColor = true;
            this.RemoveCustomersButton.Click += new System.EventHandler(this.RemoveCustomersButton_Click);
            // 
            // AddCustomersButton
            // 
            this.AddCustomersButton.Location = new System.Drawing.Point(3, 422);
            this.AddCustomersButton.Name = "AddCustomersButton";
            this.AddCustomersButton.Size = new System.Drawing.Size(130, 39);
            this.AddCustomersButton.TabIndex = 3;
            this.AddCustomersButton.Text = "Add";
            this.AddCustomersButton.UseVisualStyleBackColor = true;
            this.AddCustomersButton.Click += new System.EventHandler(this.AddCustomersButton_Click);
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.ItemHeight = 15;
            this.CustomersListBox.Location = new System.Drawing.Point(3, 22);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(262, 394);
            this.CustomersListBox.TabIndex = 1;
            this.CustomersListBox.SelectedIndexChanged += new System.EventHandler(this.CustomersListBox_SelectedIndexChanged);
            // 
            // CustomersLabel
            // 
            this.CustomersLabel.AutoSize = true;
            this.CustomersLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CustomersLabel.Location = new System.Drawing.Point(3, 4);
            this.CustomersLabel.Name = "CustomersLabel";
            this.CustomersLabel.Size = new System.Drawing.Size(66, 15);
            this.CustomersLabel.TabIndex = 0;
            this.CustomersLabel.Text = "Customers";
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(271, 59);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(64, 15);
            this.FullNameLabel.TabIndex = 3;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(271, 30);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 15);
            this.idLabel.TabIndex = 2;
            this.idLabel.Text = "ID:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(340, 51);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(252, 23);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(340, 22);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(100, 23);
            this.IdTextBox.TabIndex = 0;
            // 
            // SelectedCustomerLabel
            // 
            this.SelectedCustomerLabel.AutoSize = true;
            this.SelectedCustomerLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SelectedCustomerLabel.Location = new System.Drawing.Point(271, 4);
            this.SelectedCustomerLabel.Name = "SelectedCustomerLabel";
            this.SelectedCustomerLabel.Size = new System.Drawing.Size(116, 15);
            this.SelectedCustomerLabel.TabIndex = 6;
            this.SelectedCustomerLabel.Text = "Selected Customer:";
            // 
            // addressControl1
            // 
            address1.Apartment = "";
            address1.Building = "";
            address1.City = "";
            address1.Country = "";
            address1.Index = "000000";
            address1.Street = "";
            this.addressControl1.Address = address1;
            this.addressControl1.Location = new System.Drawing.Point(271, 131);
            this.addressControl1.Name = "addressControl1";
            this.addressControl1.Size = new System.Drawing.Size(421, 160);
            this.addressControl1.TabIndex = 7;
            // 
            // IsPriorityCheckBox
            // 
            this.IsPriorityCheckBox.AutoSize = true;
            this.IsPriorityCheckBox.Location = new System.Drawing.Point(340, 80);
            this.IsPriorityCheckBox.Name = "IsPriorityCheckBox";
            this.IsPriorityCheckBox.Size = new System.Drawing.Size(75, 19);
            this.IsPriorityCheckBox.TabIndex = 8;
            this.IsPriorityCheckBox.Text = "Is Priority";
            this.IsPriorityCheckBox.UseVisualStyleBackColor = true;
            this.IsPriorityCheckBox.CheckedChanged += new System.EventHandler(this.IsPriorityCheckBox_CheckedChanged);
            // 
            // DiscountsLabel
            // 
            this.DiscountsLabel.AutoSize = true;
            this.DiscountsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DiscountsLabel.Location = new System.Drawing.Point(271, 304);
            this.DiscountsLabel.Name = "DiscountsLabel";
            this.DiscountsLabel.Size = new System.Drawing.Size(61, 15);
            this.DiscountsLabel.TabIndex = 9;
            this.DiscountsLabel.Text = "Discounts";
            // 
            // DiscountsListBox
            // 
            this.DiscountsListBox.FormattingEnabled = true;
            this.DiscountsListBox.ItemHeight = 15;
            this.DiscountsListBox.Location = new System.Drawing.Point(271, 322);
            this.DiscountsListBox.Name = "DiscountsListBox";
            this.DiscountsListBox.Size = new System.Drawing.Size(241, 94);
            this.DiscountsListBox.TabIndex = 10;
            // 
            // AddDiscountButton
            // 
            this.AddDiscountButton.Location = new System.Drawing.Point(518, 322);
            this.AddDiscountButton.Name = "AddDiscountButton";
            this.AddDiscountButton.Size = new System.Drawing.Size(98, 44);
            this.AddDiscountButton.TabIndex = 11;
            this.AddDiscountButton.Text = "Add";
            this.AddDiscountButton.UseVisualStyleBackColor = true;
            this.AddDiscountButton.Click += new System.EventHandler(this.AddDiscountButton_Click);
            // 
            // RemoveDiscountButton
            // 
            this.RemoveDiscountButton.Location = new System.Drawing.Point(518, 372);
            this.RemoveDiscountButton.Name = "RemoveDiscountButton";
            this.RemoveDiscountButton.Size = new System.Drawing.Size(98, 44);
            this.RemoveDiscountButton.TabIndex = 11;
            this.RemoveDiscountButton.Text = "Remove";
            this.RemoveDiscountButton.UseVisualStyleBackColor = true;
            this.RemoveDiscountButton.Click += new System.EventHandler(this.RemoveDiscountButton_Click);
            // 
            // CustomerTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RemoveDiscountButton);
            this.Controls.Add(this.AddDiscountButton);
            this.Controls.Add(this.DiscountsListBox);
            this.Controls.Add(this.DiscountsLabel);
            this.Controls.Add(this.IsPriorityCheckBox);
            this.Controls.Add(this.addressControl1);
            this.Controls.Add(this.SelectedCustomerLabel);
            this.Controls.Add(this.RemoveCustomersButton);
            this.Controls.Add(this.FullNameLabel);
            this.Controls.Add(this.AddCustomersButton);
            this.Controls.Add(this.CustomersListBox);
            this.Controls.Add(this.CustomersLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Name = "CustomerTab";
            this.Size = new System.Drawing.Size(675, 467);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label CustomersLabel;
        private ListBox CustomersListBox;
        private Button AddCustomersButton;
        private Button RemoveCustomersButton;
        private TextBox NameTextBox;
        private TextBox IdTextBox;
        private Label FullNameLabel;
        private Label idLabel;
        private Label SelectedCustomerLabel;
        private AddressControl addressControl1;
        private CheckBox IsPriorityCheckBox;
        private Label DiscountsLabel;
        private ListBox DiscountsListBox;
        private Button AddDiscountButton;
        private Button RemoveDiscountButton;
    }
}
