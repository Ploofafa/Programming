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
            FullNameLabel = new Label();
            JobTitleLabel = new Label();
            EmployeeDateLabel = new Label();
            SalaryLabel = new Label();
            FullNameTextBox = new TextBox();
            JobTitleTextBox = new TextBox();
            EmployeeDateTimePicker = new DateTimePicker();
            SalaryTextBox = new TextBox();
            AddEmployeeButton = new Button();
            EmployeesListBox = new ListBox();
            DeleteEmployeeButton = new Button();
            SuspendLayout();
            // 
            // FullNameLabel
            // 
            FullNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FullNameLabel.AutoSize = true;
            FullNameLabel.Location = new Point(294, 33);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(64, 15);
            FullNameLabel.TabIndex = 0;
            FullNameLabel.Text = "Full Name:";
            // 
            // JobTitleLabel
            // 
            JobTitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            JobTitleLabel.AutoSize = true;
            JobTitleLabel.Location = new Point(294, 62);
            JobTitleLabel.Name = "JobTitleLabel";
            JobTitleLabel.Size = new Size(53, 15);
            JobTitleLabel.TabIndex = 1;
            JobTitleLabel.Text = "Job Title:";
            // 
            // EmployeeDateLabel
            // 
            EmployeeDateLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EmployeeDateLabel.AutoSize = true;
            EmployeeDateLabel.Location = new Point(294, 91);
            EmployeeDateLabel.Name = "EmployeeDateLabel";
            EmployeeDateLabel.Size = new Size(89, 15);
            EmployeeDateLabel.TabIndex = 2;
            EmployeeDateLabel.Text = "Employee Date:";
            // 
            // SalaryLabel
            // 
            SalaryLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SalaryLabel.AutoSize = true;
            SalaryLabel.Location = new Point(294, 121);
            SalaryLabel.Name = "SalaryLabel";
            SalaryLabel.Size = new Size(41, 15);
            SalaryLabel.TabIndex = 3;
            SalaryLabel.Text = "Salary:";
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FullNameTextBox.Location = new Point(386, 25);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(304, 23);
            FullNameTextBox.TabIndex = 4;
            FullNameTextBox.TextChanged += FullNameTextBox_TextChanged;
            // 
            // JobTitleTextBox
            // 
            JobTitleTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            JobTitleTextBox.Location = new Point(386, 54);
            JobTitleTextBox.Name = "JobTitleTextBox";
            JobTitleTextBox.Size = new Size(304, 23);
            JobTitleTextBox.TabIndex = 5;
            JobTitleTextBox.TextChanged += JobTitleTextBox_TextChanged;
            // 
            // EmployeeDateTimePicker
            // 
            EmployeeDateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EmployeeDateTimePicker.Location = new Point(386, 83);
            EmployeeDateTimePicker.MaxDate = new DateTime(2023, 3, 31, 0, 0, 0, 0);
            EmployeeDateTimePicker.MinDate = new DateTime(1999, 1, 1, 0, 0, 0, 0);
            EmployeeDateTimePicker.Name = "EmployeeDateTimePicker";
            EmployeeDateTimePicker.Size = new Size(304, 23);
            EmployeeDateTimePicker.TabIndex = 6;
            EmployeeDateTimePicker.Value = new DateTime(2022, 10, 27, 0, 0, 0, 0);
            EmployeeDateTimePicker.ValueChanged += EmployeeDateTimePicker_ValueChanged;
            // 
            // SalaryTextBox
            // 
            SalaryTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SalaryTextBox.Location = new Point(386, 113);
            SalaryTextBox.Name = "SalaryTextBox";
            SalaryTextBox.Size = new Size(304, 23);
            SalaryTextBox.TabIndex = 7;
            SalaryTextBox.TextChanged += SalaryTextBox_TextChanged;
            // 
            // AddEmployeeButton
            // 
            AddEmployeeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddEmployeeButton.Location = new Point(16, 355);
            AddEmployeeButton.Name = "AddEmployeeButton";
            AddEmployeeButton.Size = new Size(127, 23);
            AddEmployeeButton.TabIndex = 8;
            AddEmployeeButton.Text = "Add New Employee";
            AddEmployeeButton.UseVisualStyleBackColor = true;
            AddEmployeeButton.Click += AddEmployeeButton_Click;
            // 
            // EmployeesListBox
            // 
            EmployeesListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EmployeesListBox.FormattingEnabled = true;
            EmployeesListBox.ItemHeight = 15;
            EmployeesListBox.Location = new Point(15, 30);
            EmployeesListBox.Name = "EmployeesListBox";
            EmployeesListBox.Size = new Size(261, 319);
            EmployeesListBox.TabIndex = 9;
            EmployeesListBox.SelectedIndexChanged += EmployeesListBox_SelectedIndexChanged;
            // 
            // DeleteEmployeeButton
            // 
            DeleteEmployeeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DeleteEmployeeButton.Location = new Point(149, 355);
            DeleteEmployeeButton.Name = "DeleteEmployeeButton";
            DeleteEmployeeButton.Size = new Size(127, 23);
            DeleteEmployeeButton.TabIndex = 8;
            DeleteEmployeeButton.Text = "Delete Employee";
            DeleteEmployeeButton.UseVisualStyleBackColor = true;
            DeleteEmployeeButton.Click += DeleteEmployeeButton_Click;
            // 
            // InputEmployeeControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(EmployeesListBox);
            Controls.Add(DeleteEmployeeButton);
            Controls.Add(AddEmployeeButton);
            Controls.Add(SalaryTextBox);
            Controls.Add(EmployeeDateTimePicker);
            Controls.Add(JobTitleTextBox);
            Controls.Add(FullNameTextBox);
            Controls.Add(SalaryLabel);
            Controls.Add(EmployeeDateLabel);
            Controls.Add(JobTitleLabel);
            Controls.Add(FullNameLabel);
            MinimumSize = new Size(717, 397);
            Name = "InputEmployeeControl";
            Size = new Size(717, 397);
            ResumeLayout(false);
            PerformLayout();
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
