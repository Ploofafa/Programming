namespace EmployeeDatabase.Panels
{
    partial class InputEmployeeControl
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
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.JobTitleLabel = new System.Windows.Forms.Label();
            this.EmployeeDateLabel = new System.Windows.Forms.Label();
            this.SalaryLabel = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.JobTitleTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SalaryTextBox = new System.Windows.Forms.TextBox();
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            this.EmployeesListBox = new System.Windows.Forms.ListBox();
            this.DeleteEmployeeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(294, 33);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(64, 15);
            this.FullNameLabel.TabIndex = 0;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // JobTitleLabel
            // 
            this.JobTitleLabel.AutoSize = true;
            this.JobTitleLabel.Location = new System.Drawing.Point(294, 62);
            this.JobTitleLabel.Name = "JobTitleLabel";
            this.JobTitleLabel.Size = new System.Drawing.Size(53, 15);
            this.JobTitleLabel.TabIndex = 1;
            this.JobTitleLabel.Text = "Job Title:";
            // 
            // EmployeeDateLabel
            // 
            this.EmployeeDateLabel.AutoSize = true;
            this.EmployeeDateLabel.Location = new System.Drawing.Point(294, 91);
            this.EmployeeDateLabel.Name = "EmployeeDateLabel";
            this.EmployeeDateLabel.Size = new System.Drawing.Size(89, 15);
            this.EmployeeDateLabel.TabIndex = 2;
            this.EmployeeDateLabel.Text = "Employee Date:";
            // 
            // SalaryLabel
            // 
            this.SalaryLabel.AutoSize = true;
            this.SalaryLabel.Location = new System.Drawing.Point(294, 121);
            this.SalaryLabel.Name = "SalaryLabel";
            this.SalaryLabel.Size = new System.Drawing.Size(41, 15);
            this.SalaryLabel.TabIndex = 3;
            this.SalaryLabel.Text = "Salary:";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(386, 25);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(304, 23);
            this.FullNameTextBox.TabIndex = 4;
            this.FullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBox_TextChanged);
            // 
            // JobTitleTextBox
            // 
            this.JobTitleTextBox.Location = new System.Drawing.Point(386, 54);
            this.JobTitleTextBox.Name = "JobTitleTextBox";
            this.JobTitleTextBox.Size = new System.Drawing.Size(304, 23);
            this.JobTitleTextBox.TabIndex = 5;
            this.JobTitleTextBox.TextChanged += new System.EventHandler(this.JobTitleTextBox_TextChanged);
            // 
            // EmployeeDateTimePicker
            // 
            this.EmployeeDateTimePicker.Location = new System.Drawing.Point(386, 83);
            this.EmployeeDateTimePicker.Name = "EmployeeDateTimePicker";
            this.EmployeeDateTimePicker.Size = new System.Drawing.Size(279, 23);
            this.EmployeeDateTimePicker.TabIndex = 6;
            this.EmployeeDateTimePicker.ValueChanged += new System.EventHandler(this.EmployeeDateTimePicker_ValueChanged);
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.Location = new System.Drawing.Point(386, 113);
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.Size = new System.Drawing.Size(304, 23);
            this.SalaryTextBox.TabIndex = 7;
            this.SalaryTextBox.TextChanged += new System.EventHandler(this.SalaryTextBox_TextChanged);
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.Location = new System.Drawing.Point(16, 355);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(127, 23);
            this.AddEmployeeButton.TabIndex = 8;
            this.AddEmployeeButton.Text = "Add New Employee";
            this.AddEmployeeButton.UseVisualStyleBackColor = true;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // EmployeesListBox
            // 
            this.EmployeesListBox.FormattingEnabled = true;
            this.EmployeesListBox.ItemHeight = 15;
            this.EmployeesListBox.Location = new System.Drawing.Point(15, 30);
            this.EmployeesListBox.Name = "EmployeesListBox";
            this.EmployeesListBox.Size = new System.Drawing.Size(261, 319);
            this.EmployeesListBox.TabIndex = 9;
            this.EmployeesListBox.SelectedIndexChanged += new System.EventHandler(this.EmployeesListBox_SelectedIndexChanged);
            // 
            // DeleteEmployeeButton
            // 
            this.DeleteEmployeeButton.Location = new System.Drawing.Point(149, 355);
            this.DeleteEmployeeButton.Name = "DeleteEmployeeButton";
            this.DeleteEmployeeButton.Size = new System.Drawing.Size(127, 23);
            this.DeleteEmployeeButton.TabIndex = 8;
            this.DeleteEmployeeButton.Text = "Delete Employee";
            this.DeleteEmployeeButton.UseVisualStyleBackColor = true;
            this.DeleteEmployeeButton.Click += new System.EventHandler(this.DeleteEmployeeButton_Click);
            // 
            // InputEmployeeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EmployeesListBox);
            this.Controls.Add(this.DeleteEmployeeButton);
            this.Controls.Add(this.AddEmployeeButton);
            this.Controls.Add(this.SalaryTextBox);
            this.Controls.Add(this.EmployeeDateTimePicker);
            this.Controls.Add(this.JobTitleTextBox);
            this.Controls.Add(this.FullNameTextBox);
            this.Controls.Add(this.SalaryLabel);
            this.Controls.Add(this.EmployeeDateLabel);
            this.Controls.Add(this.JobTitleLabel);
            this.Controls.Add(this.FullNameLabel);
            this.Name = "InputEmployeeControl";
            this.Size = new System.Drawing.Size(719, 463);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label FullNameLabel;
        private Label JobTitleLabel;
        private Label EmployeeDateLabel;
        private Label SalaryLabel;
        private TextBox FullNameTextBox;
        private TextBox JobTitleTextBox;
        private DateTimePicker EmployeeDateTimePicker;
        private TextBox SalaryTextBox;
        private Button AddEmployeeButton;
        public ListBox EmployeesListBox;
        private Button DeleteEmployeeButton;
    }
}
