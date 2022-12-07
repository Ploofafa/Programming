namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
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
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.CustomerComboBox = new System.Windows.Forms.ComboBox();
            this.CartLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.AddToCartButton = new System.Windows.Forms.Button();
            this.CreateOrderButton = new System.Windows.Forms.Button();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.ClearCartButton = new System.Windows.Forms.Button();
            this.CartListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ItemsLabel
            // 
            this.ItemsLabel.AutoSize = true;
            this.ItemsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ItemsLabel.Location = new System.Drawing.Point(3, 9);
            this.ItemsLabel.Name = "ItemsLabel";
            this.ItemsLabel.Size = new System.Drawing.Size(39, 15);
            this.ItemsLabel.TabIndex = 0;
            this.ItemsLabel.Text = "Items";
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.ItemHeight = 15;
            this.ItemsListBox.Location = new System.Drawing.Point(3, 27);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(223, 364);
            this.ItemsListBox.TabIndex = 1;
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CustomerLabel.Location = new System.Drawing.Point(232, 27);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(64, 15);
            this.CustomerLabel.TabIndex = 2;
            this.CustomerLabel.Text = "Customer:";
            // 
            // CustomerComboBox
            // 
            this.CustomerComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerComboBox.FormattingEnabled = true;
            this.CustomerComboBox.Location = new System.Drawing.Point(302, 27);
            this.CustomerComboBox.Name = "CustomerComboBox";
            this.CustomerComboBox.Size = new System.Drawing.Size(297, 23);
            this.CustomerComboBox.TabIndex = 3;
            this.CustomerComboBox.SelectedIndexChanged += new System.EventHandler(this.CustomerComboBox_SelectedIndexChanged);
            // 
            // CartLabel
            // 
            this.CartLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CartLabel.AutoSize = true;
            this.CartLabel.Location = new System.Drawing.Point(232, 86);
            this.CartLabel.Name = "CartLabel";
            this.CartLabel.Size = new System.Drawing.Size(32, 15);
            this.CartLabel.TabIndex = 4;
            this.CartLabel.Text = "Cart:";
            // 
            // AmountLabel
            // 
            this.AmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AmountLabel.Location = new System.Drawing.Point(544, 251);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(55, 15);
            this.AmountLabel.TabIndex = 6;
            this.AmountLabel.Text = "Amount:";
            // 
            // NumberLabel
            // 
            this.NumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumberLabel.Location = new System.Drawing.Point(527, 266);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(72, 25);
            this.NumberLabel.TabIndex = 7;
            this.NumberLabel.Text = "15 499";
            // 
            // AddToCartButton
            // 
            this.AddToCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddToCartButton.Location = new System.Drawing.Point(3, 397);
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Size = new System.Drawing.Size(92, 33);
            this.AddToCartButton.TabIndex = 8;
            this.AddToCartButton.Text = "Add To Cart";
            this.AddToCartButton.UseVisualStyleBackColor = true;
            this.AddToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // CreateOrderButton
            // 
            this.CreateOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateOrderButton.Location = new System.Drawing.Point(232, 297);
            this.CreateOrderButton.Name = "CreateOrderButton";
            this.CreateOrderButton.Size = new System.Drawing.Size(92, 33);
            this.CreateOrderButton.TabIndex = 9;
            this.CreateOrderButton.Text = "Create Order";
            this.CreateOrderButton.UseVisualStyleBackColor = true;
            this.CreateOrderButton.Click += new System.EventHandler(this.CreateOrderButton_Click);
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveItemButton.Location = new System.Drawing.Point(413, 294);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(90, 33);
            this.RemoveItemButton.TabIndex = 10;
            this.RemoveItemButton.Text = "Remove Item";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            this.RemoveItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // ClearCartButton
            // 
            this.ClearCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearCartButton.Location = new System.Drawing.Point(509, 294);
            this.ClearCartButton.Name = "ClearCartButton";
            this.ClearCartButton.Size = new System.Drawing.Size(90, 33);
            this.ClearCartButton.TabIndex = 11;
            this.ClearCartButton.Text = "Clear Cart";
            this.ClearCartButton.UseVisualStyleBackColor = true;
            this.ClearCartButton.Click += new System.EventHandler(this.ClearCartButton_Click);
            // 
            // CartListBox
            // 
            this.CartListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CartListBox.FormattingEnabled = true;
            this.CartListBox.ItemHeight = 15;
            this.CartListBox.Location = new System.Drawing.Point(232, 104);
            this.CartListBox.Name = "CartListBox";
            this.CartListBox.Size = new System.Drawing.Size(367, 139);
            this.CartListBox.TabIndex = 12;
            // 
            // CartsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CartListBox);
            this.Controls.Add(this.ClearCartButton);
            this.Controls.Add(this.RemoveItemButton);
            this.Controls.Add(this.CreateOrderButton);
            this.Controls.Add(this.AddToCartButton);
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.CartLabel);
            this.Controls.Add(this.CustomerComboBox);
            this.Controls.Add(this.CustomerLabel);
            this.Controls.Add(this.ItemsListBox);
            this.Controls.Add(this.ItemsLabel);
            this.Name = "CartsTab";
            this.Size = new System.Drawing.Size(621, 436);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ItemsLabel;
        private ListBox ItemsListBox;
        private Label CustomerLabel;
        private ComboBox CustomerComboBox;
        private Label CartLabel;
        private Label AmountLabel;
        private Label NumberLabel;
        private Button AddToCartButton;
        private Button CreateOrderButton;
        private Button RemoveItemButton;
        private Button ClearCartButton;
        private ListBox CartListBox;
    }
}
