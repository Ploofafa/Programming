namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            this.CustomerListGroupBox = new System.Windows.Forms.GroupBox();
            this.RemoveCustomersButton = new System.Windows.Forms.Button();
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.CustomersLabel = new System.Windows.Forms.Label();
            this.InfoCustomersGroupBox = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddressCustomerLabel = new System.Windows.Forms.Label();
            this.FullNameCustomerLabel = new System.Windows.Forms.Label();
            this.IdCustomerLabel = new System.Windows.Forms.Label();
            this.SelectedCustomerLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CustomerListGroupBox.SuspendLayout();
            this.InfoCustomersGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerListGroupBox
            // 
            this.CustomerListGroupBox.Controls.Add(this.RemoveCustomersButton);
            this.CustomerListGroupBox.Controls.Add(this.AddCustomerButton);
            this.CustomerListGroupBox.Controls.Add(this.CustomersListBox);
            this.CustomerListGroupBox.Controls.Add(this.CustomersLabel);
            this.CustomerListGroupBox.Location = new System.Drawing.Point(3, 0);
            this.CustomerListGroupBox.Name = "CustomerListGroupBox";
            this.CustomerListGroupBox.Size = new System.Drawing.Size(274, 428);
            this.CustomerListGroupBox.TabIndex = 0;
            this.CustomerListGroupBox.TabStop = false;
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
            // AddCustomerButton
            // 
            this.AddCustomerButton.Location = new System.Drawing.Point(6, 383);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(86, 39);
            this.AddCustomerButton.TabIndex = 3;
            this.AddCustomerButton.Text = "Add";
            this.AddCustomerButton.UseVisualStyleBackColor = true;
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.ItemHeight = 15;
            this.CustomersListBox.Location = new System.Drawing.Point(6, 37);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(262, 334);
            this.CustomersListBox.TabIndex = 2;
            this.CustomersListBox.SelectedIndexChanged += new System.EventHandler(this.CustomersListBox_SelectedIndexChanged);
            // 
            // CustomersLabel
            // 
            this.CustomersLabel.AutoSize = true;
            this.CustomersLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CustomersLabel.Location = new System.Drawing.Point(6, 19);
            this.CustomersLabel.Name = "CustomersLabel";
            this.CustomersLabel.Size = new System.Drawing.Size(66, 15);
            this.CustomersLabel.TabIndex = 1;
            this.CustomersLabel.Text = "Customers";
            // 
            // InfoCustomersGroupBox
            // 
            this.InfoCustomersGroupBox.Controls.Add(this.textBox3);
            this.InfoCustomersGroupBox.Controls.Add(this.textBox2);
            this.InfoCustomersGroupBox.Controls.Add(this.textBox1);
            this.InfoCustomersGroupBox.Controls.Add(this.AddressCustomerLabel);
            this.InfoCustomersGroupBox.Controls.Add(this.FullNameCustomerLabel);
            this.InfoCustomersGroupBox.Controls.Add(this.IdCustomerLabel);
            this.InfoCustomersGroupBox.Controls.Add(this.SelectedCustomerLabel);
            this.InfoCustomersGroupBox.Location = new System.Drawing.Point(283, 0);
            this.InfoCustomersGroupBox.Name = "InfoCustomersGroupBox";
            this.InfoCustomersGroupBox.Size = new System.Drawing.Size(389, 194);
            this.InfoCustomersGroupBox.TabIndex = 1;
            this.InfoCustomersGroupBox.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(7, 113);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(376, 75);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(77, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(306, 23);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 4;
            // 
            // AddressCustomerLabel
            // 
            this.AddressCustomerLabel.AutoSize = true;
            this.AddressCustomerLabel.Location = new System.Drawing.Point(7, 95);
            this.AddressCustomerLabel.Name = "AddressCustomerLabel";
            this.AddressCustomerLabel.Size = new System.Drawing.Size(52, 15);
            this.AddressCustomerLabel.TabIndex = 3;
            this.AddressCustomerLabel.Text = "Address:";
            // 
            // FullNameCustomerLabel
            // 
            this.FullNameCustomerLabel.AutoSize = true;
            this.FullNameCustomerLabel.Location = new System.Drawing.Point(7, 70);
            this.FullNameCustomerLabel.Name = "FullNameCustomerLabel";
            this.FullNameCustomerLabel.Size = new System.Drawing.Size(64, 15);
            this.FullNameCustomerLabel.TabIndex = 2;
            this.FullNameCustomerLabel.Text = "Full Name:";
            // 
            // IdCustomerLabel
            // 
            this.IdCustomerLabel.AutoSize = true;
            this.IdCustomerLabel.Location = new System.Drawing.Point(7, 40);
            this.IdCustomerLabel.Name = "IdCustomerLabel";
            this.IdCustomerLabel.Size = new System.Drawing.Size(20, 15);
            this.IdCustomerLabel.TabIndex = 1;
            this.IdCustomerLabel.Text = "Id:";
            // 
            // SelectedCustomerLabel
            // 
            this.SelectedCustomerLabel.AutoSize = true;
            this.SelectedCustomerLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SelectedCustomerLabel.Location = new System.Drawing.Point(6, 19);
            this.SelectedCustomerLabel.Name = "SelectedCustomerLabel";
            this.SelectedCustomerLabel.Size = new System.Drawing.Size(113, 15);
            this.SelectedCustomerLabel.TabIndex = 0;
            this.SelectedCustomerLabel.Text = "Selected Customer";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(283, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 228);
            this.panel1.TabIndex = 2;
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.InfoCustomersGroupBox);
            this.Controls.Add(this.CustomerListGroupBox);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(689, 431);
            this.CustomerListGroupBox.ResumeLayout(false);
            this.CustomerListGroupBox.PerformLayout();
            this.InfoCustomersGroupBox.ResumeLayout(false);
            this.InfoCustomersGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox CustomerListGroupBox;
        private Label CustomersLabel;
        private ListBox CustomersListBox;
        private GroupBox InfoCustomersGroupBox;
        private Label SelectedCustomerLabel;
        private Label IdCustomerLabel;
        private Label FullNameCustomerLabel;
        private Button RemoveCustomersButton;
        private Button AddCustomerButton;
        private Panel panel1;
        private Label AddressCustomerLabel;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}
