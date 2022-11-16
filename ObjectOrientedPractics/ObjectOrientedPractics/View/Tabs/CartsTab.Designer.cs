namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ItemsLabel = new System.Windows.Forms.Label();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.AddToCartButton = new System.Windows.Forms.Button();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.CustomerComboBox = new System.Windows.Forms.ComboBox();
            this.CartLabel = new System.Windows.Forms.Label();
            this.CartTextBox = new System.Windows.Forms.TextBox();
            this.CreateOrderButton = new System.Windows.Forms.Button();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.ClearCartButton = new System.Windows.Forms.Button();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.NumberAmountLabel = new System.Windows.Forms.Label();
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
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.ItemHeight = 15;
            this.ItemsListBox.Location = new System.Drawing.Point(3, 27);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(240, 319);
            this.ItemsListBox.TabIndex = 1;
            // 
            // AddToCartButton
            // 
            this.AddToCartButton.Location = new System.Drawing.Point(3, 358);
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Size = new System.Drawing.Size(144, 42);
            this.AddToCartButton.TabIndex = 2;
            this.AddToCartButton.Text = "Add To Cart";
            this.AddToCartButton.UseVisualStyleBackColor = true;
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CustomerLabel.Location = new System.Drawing.Point(261, 30);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(64, 15);
            this.CustomerLabel.TabIndex = 3;
            this.CustomerLabel.Text = "Customer:";
            // 
            // CustomerComboBox
            // 
            this.CustomerComboBox.FormattingEnabled = true;
            this.CustomerComboBox.Location = new System.Drawing.Point(331, 27);
            this.CustomerComboBox.Name = "CustomerComboBox";
            this.CustomerComboBox.Size = new System.Drawing.Size(342, 23);
            this.CustomerComboBox.TabIndex = 4;
            // 
            // CartLabel
            // 
            this.CartLabel.AutoSize = true;
            this.CartLabel.Location = new System.Drawing.Point(261, 72);
            this.CartLabel.Name = "CartLabel";
            this.CartLabel.Size = new System.Drawing.Size(32, 15);
            this.CartLabel.TabIndex = 5;
            this.CartLabel.Text = "Cart:";
            // 
            // CartTextBox
            // 
            this.CartTextBox.Location = new System.Drawing.Point(261, 90);
            this.CartTextBox.Multiline = true;
            this.CartTextBox.Name = "CartTextBox";
            this.CartTextBox.Size = new System.Drawing.Size(412, 130);
            this.CartTextBox.TabIndex = 6;
            // 
            // CreateOrderButton
            // 
            this.CreateOrderButton.Location = new System.Drawing.Point(261, 278);
            this.CreateOrderButton.Name = "CreateOrderButton";
            this.CreateOrderButton.Size = new System.Drawing.Size(85, 38);
            this.CreateOrderButton.TabIndex = 7;
            this.CreateOrderButton.Text = "Create Order";
            this.CreateOrderButton.UseVisualStyleBackColor = true;
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Location = new System.Drawing.Point(497, 278);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(85, 38);
            this.RemoveItemButton.TabIndex = 8;
            this.RemoveItemButton.Text = "Remove Item";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            // 
            // ClearCartButton
            // 
            this.ClearCartButton.Location = new System.Drawing.Point(588, 278);
            this.ClearCartButton.Name = "ClearCartButton";
            this.ClearCartButton.Size = new System.Drawing.Size(85, 38);
            this.ClearCartButton.TabIndex = 9;
            this.ClearCartButton.Text = "Clear Cart";
            this.ClearCartButton.UseVisualStyleBackColor = true;
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AmountLabel.Location = new System.Drawing.Point(607, 223);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(66, 19);
            this.AmountLabel.TabIndex = 10;
            this.AmountLabel.Text = "Amount:";
            // 
            // NumberAmountLabel
            // 
            this.NumberAmountLabel.AutoSize = true;
            this.NumberAmountLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumberAmountLabel.Location = new System.Drawing.Point(585, 242);
            this.NumberAmountLabel.Name = "NumberAmountLabel";
            this.NumberAmountLabel.Size = new System.Drawing.Size(88, 25);
            this.NumberAmountLabel.TabIndex = 11;
            this.NumberAmountLabel.Text = "15 999,0";
            // 
            // CartsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NumberAmountLabel);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.ClearCartButton);
            this.Controls.Add(this.RemoveItemButton);
            this.Controls.Add(this.CreateOrderButton);
            this.Controls.Add(this.CartTextBox);
            this.Controls.Add(this.CartLabel);
            this.Controls.Add(this.CustomerComboBox);
            this.Controls.Add(this.CustomerLabel);
            this.Controls.Add(this.AddToCartButton);
            this.Controls.Add(this.ItemsListBox);
            this.Controls.Add(this.ItemsLabel);
            this.Name = "CartsTab";
            this.Size = new System.Drawing.Size(704, 412);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ItemsLabel;
        private ListBox ItemsListBox;
        private Button AddToCartButton;
        private Label CustomerLabel;
        private ComboBox CustomerComboBox;
        private Label CartLabel;
        private TextBox CartTextBox;
        private Button CreateOrderButton;
        private Button RemoveItemButton;
        private Button ClearCartButton;
        private Label AmountLabel;
        private Label NumberAmountLabel;
    }
}
