namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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
            this.ItemsLabel = new System.Windows.Forms.Label();
            this.RemoveItemsButton = new System.Windows.Forms.Button();
            this.AddItemsButton = new System.Windows.Forms.Button();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.ItemCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.SelectedItemLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ItemsLabel
            // 
            this.ItemsLabel.AutoSize = true;
            this.ItemsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ItemsLabel.Location = new System.Drawing.Point(14, 1);
            this.ItemsLabel.Name = "ItemsLabel";
            this.ItemsLabel.Size = new System.Drawing.Size(39, 15);
            this.ItemsLabel.TabIndex = 0;
            this.ItemsLabel.Text = "Items";
            // 
            // RemoveItemsButton
            // 
            this.RemoveItemsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveItemsButton.Location = new System.Drawing.Point(146, 362);
            this.RemoveItemsButton.Name = "RemoveItemsButton";
            this.RemoveItemsButton.Size = new System.Drawing.Size(130, 39);
            this.RemoveItemsButton.TabIndex = 3;
            this.RemoveItemsButton.Text = "Remove";
            this.RemoveItemsButton.UseVisualStyleBackColor = true;
            this.RemoveItemsButton.Click += new System.EventHandler(this.RemoveItemsButton_Click);
            // 
            // AddItemsButton
            // 
            this.AddItemsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddItemsButton.Location = new System.Drawing.Point(14, 362);
            this.AddItemsButton.Name = "AddItemsButton";
            this.AddItemsButton.Size = new System.Drawing.Size(130, 39);
            this.AddItemsButton.TabIndex = 2;
            this.AddItemsButton.Text = "Add";
            this.AddItemsButton.UseVisualStyleBackColor = true;
            this.AddItemsButton.Click += new System.EventHandler(this.AddItemsButton_Click);
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.ItemHeight = 15;
            this.ItemsListBox.Location = new System.Drawing.Point(14, 19);
            this.ItemsListBox.MinimumSize = new System.Drawing.Size(15, 15);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(262, 334);
            this.ItemsListBox.TabIndex = 1;
            this.ItemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemsListBox_SelectedIndexChanged);
            // 
            // ItemCategoryComboBox
            // 
            this.ItemCategoryComboBox.FormattingEnabled = true;
            this.ItemCategoryComboBox.Location = new System.Drawing.Point(362, 113);
            this.ItemCategoryComboBox.Name = "ItemCategoryComboBox";
            this.ItemCategoryComboBox.Size = new System.Drawing.Size(153, 23);
            this.ItemCategoryComboBox.TabIndex = 10;
            this.ItemCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.ItemCategoryComboBox_SelectedIndexChanged);
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(287, 121);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(58, 15);
            this.CategoryLabel.TabIndex = 9;
            this.CategoryLabel.Text = "Category:";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTextBox.Location = new System.Drawing.Point(287, 280);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(376, 73);
            this.DescriptionTextBox.TabIndex = 8;
            this.DescriptionTextBox.TextChanged += new System.EventHandler(this.DescriptionTextBox_TextChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(287, 168);
            this.NameTextBox.Multiline = true;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(376, 85);
            this.NameTextBox.TabIndex = 7;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(362, 84);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(153, 23);
            this.CostTextBox.TabIndex = 6;
            this.CostTextBox.TextChanged += new System.EventHandler(this.CostTextBox_TextChanged);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(362, 54);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(153, 23);
            this.IdTextBox.TabIndex = 5;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(287, 262);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(67, 15);
            this.DescriptionLabel.TabIndex = 4;
            this.DescriptionLabel.Text = "Description";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(287, 150);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(42, 15);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Name:";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(287, 92);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(34, 15);
            this.CostLabel.TabIndex = 2;
            this.CostLabel.Text = "Cost:";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(287, 62);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(21, 15);
            this.IdLabel.TabIndex = 1;
            this.IdLabel.Text = "ID:";
            // 
            // SelectedItemLabel
            // 
            this.SelectedItemLabel.AutoSize = true;
            this.SelectedItemLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SelectedItemLabel.Location = new System.Drawing.Point(287, 19);
            this.SelectedItemLabel.Name = "SelectedItemLabel";
            this.SelectedItemLabel.Size = new System.Drawing.Size(86, 15);
            this.SelectedItemLabel.TabIndex = 0;
            this.SelectedItemLabel.Text = "Selected Item";
            // 
            // ItemsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ItemCategoryComboBox);
            this.Controls.Add(this.RemoveItemsButton);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.ItemsListBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.AddItemsButton);
            this.Controls.Add(this.CostTextBox);
            this.Controls.Add(this.ItemsLabel);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.SelectedItemLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.CostLabel);
            this.Name = "ItemsTab";
            this.Size = new System.Drawing.Size(670, 404);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ItemsLabel;
        private Button RemoveItemsButton;
        private Button AddItemsButton;
        private ListBox ItemsListBox;
        private TextBox DescriptionTextBox;
        private TextBox NameTextBox;
        private TextBox CostTextBox;
        private TextBox IdTextBox;
        private Label DescriptionLabel;
        private Label NameLabel;
        private Label CostLabel;
        private Label IdLabel;
        private Label SelectedItemLabel;
        private ComboBox ItemCategoryComboBox;
        private Label CategoryLabel;
    }
}
