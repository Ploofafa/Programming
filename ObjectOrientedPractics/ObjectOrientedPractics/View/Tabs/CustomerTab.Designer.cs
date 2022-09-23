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
            this.CustomersGroupBox = new System.Windows.Forms.GroupBox();
            this.CustomersLabel = new System.Windows.Forms.Label();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.AddCustomersButton = new System.Windows.Forms.Button();
            this.RemoveCustomersButton = new System.Windows.Forms.Button();
            this.CustomersInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.SelectedCustomerLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.IdCustomerTextBox = new System.Windows.Forms.TextBox();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CustomersGroupBox.SuspendLayout();
            this.CustomersInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomersGroupBox
            // 
            this.CustomersGroupBox.Controls.Add(this.RemoveCustomersButton);
            this.CustomersGroupBox.Controls.Add(this.AddCustomersButton);
            this.CustomersGroupBox.Controls.Add(this.CustomersListBox);
            this.CustomersGroupBox.Controls.Add(this.CustomersLabel);
            this.CustomersGroupBox.Location = new System.Drawing.Point(3, 0);
            this.CustomersGroupBox.Name = "CustomersGroupBox";
            this.CustomersGroupBox.Size = new System.Drawing.Size(274, 428);
            this.CustomersGroupBox.TabIndex = 0;
            this.CustomersGroupBox.TabStop = false;
            // 
            // CustomersLabel
            // 
            this.CustomersLabel.AutoSize = true;
            this.CustomersLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CustomersLabel.Location = new System.Drawing.Point(6, 19);
            this.CustomersLabel.Name = "CustomersLabel";
            this.CustomersLabel.Size = new System.Drawing.Size(66, 15);
            this.CustomersLabel.TabIndex = 0;
            this.CustomersLabel.Text = "Customers";
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.ItemHeight = 15;
            this.CustomersListBox.Location = new System.Drawing.Point(6, 37);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(262, 334);
            this.CustomersListBox.TabIndex = 1;
            // 
            // AddCustomersButton
            // 
            this.AddCustomersButton.Location = new System.Drawing.Point(6, 383);
            this.AddCustomersButton.Name = "AddCustomersButton";
            this.AddCustomersButton.Size = new System.Drawing.Size(86, 39);
            this.AddCustomersButton.TabIndex = 3;
            this.AddCustomersButton.Text = "Add";
            this.AddCustomersButton.UseVisualStyleBackColor = true;
            // 
            // RemoveCustomersButton
            // 
            this.RemoveCustomersButton.Location = new System.Drawing.Point(98, 383);
            this.RemoveCustomersButton.Name = "RemoveCustomersButton";
            this.RemoveCustomersButton.Size = new System.Drawing.Size(86, 39);
            this.RemoveCustomersButton.TabIndex = 4;
            this.RemoveCustomersButton.Text = "Remove";
            this.RemoveCustomersButton.UseVisualStyleBackColor = true;
            // 
            // CustomersInfoGroupBox
            // 
            this.CustomersInfoGroupBox.Controls.Add(this.AddressTextBox);
            this.CustomersInfoGroupBox.Controls.Add(this.FullNameTextBox);
            this.CustomersInfoGroupBox.Controls.Add(this.IdCustomerTextBox);
            this.CustomersInfoGroupBox.Controls.Add(this.AddressLabel);
            this.CustomersInfoGroupBox.Controls.Add(this.FullNameLabel);
            this.CustomersInfoGroupBox.Controls.Add(this.IdLabel);
            this.CustomersInfoGroupBox.Controls.Add(this.SelectedCustomerLabel);
            this.CustomersInfoGroupBox.Location = new System.Drawing.Point(283, 0);
            this.CustomersInfoGroupBox.Name = "CustomersInfoGroupBox";
            this.CustomersInfoGroupBox.Size = new System.Drawing.Size(389, 210);
            this.CustomersInfoGroupBox.TabIndex = 1;
            this.CustomersInfoGroupBox.TabStop = false;
            // 
            // SelectedCustomerLabel
            // 
            this.SelectedCustomerLabel.AutoSize = true;
            this.SelectedCustomerLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SelectedCustomerLabel.Location = new System.Drawing.Point(6, 19);
            this.SelectedCustomerLabel.Name = "SelectedCustomerLabel";
            this.SelectedCustomerLabel.Size = new System.Drawing.Size(113, 15);
            this.SelectedCustomerLabel.TabIndex = 1;
            this.SelectedCustomerLabel.Text = "Selected Customer";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(6, 37);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(21, 15);
            this.IdLabel.TabIndex = 2;
            this.IdLabel.Text = "ID:";
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(6, 67);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(64, 15);
            this.FullNameLabel.TabIndex = 3;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(6, 96);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(52, 15);
            this.AddressLabel.TabIndex = 4;
            this.AddressLabel.Text = "Address:";
            // 
            // IdCustomerTextBox
            // 
            this.IdCustomerTextBox.Location = new System.Drawing.Point(81, 34);
            this.IdCustomerTextBox.Name = "IdCustomerTextBox";
            this.IdCustomerTextBox.Size = new System.Drawing.Size(100, 23);
            this.IdCustomerTextBox.TabIndex = 5;
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(81, 64);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(302, 23);
            this.FullNameTextBox.TabIndex = 6;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(81, 93);
            this.AddressTextBox.Multiline = true;
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(302, 110);
            this.AddressTextBox.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(283, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 212);
            this.panel1.TabIndex = 2;
            // 
            // CustomerTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CustomersInfoGroupBox);
            this.Controls.Add(this.CustomersGroupBox);
            this.Name = "CustomerTab";
            this.Size = new System.Drawing.Size(689, 431);
            this.CustomersGroupBox.ResumeLayout(false);
            this.CustomersGroupBox.PerformLayout();
            this.CustomersInfoGroupBox.ResumeLayout(false);
            this.CustomersInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox CustomersGroupBox;
        private Label CustomersLabel;
        private ListBox CustomersListBox;
        private Button AddCustomersButton;
        private Button RemoveCustomersButton;
        private GroupBox CustomersInfoGroupBox;
        private Label SelectedCustomerLabel;
        private TextBox AddressTextBox;
        private TextBox FullNameTextBox;
        private TextBox IdCustomerTextBox;
        private Label AddressLabel;
        private Label FullNameLabel;
        private Label IdLabel;
        private Panel panel1;
    }
}
