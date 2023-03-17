namespace ObjectOrientedPractics.View.Tabs
{
    partial class DiscountsTab
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
            this.InfoLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ProductsAmountLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.DiscountAmountLabel = new System.Windows.Forms.Label();
            this.DiscountNumberLabel = new System.Windows.Forms.Label();
            this.InfoPercentDiscountLabel = new System.Windows.Forms.Label();
            this.CalculatePercentButton = new System.Windows.Forms.Button();
            this.ApplyPercentButton = new System.Windows.Forms.Button();
            this.UpdatePercentButton = new System.Windows.Forms.Button();
            this.ProductsAmountPercentLabel = new System.Windows.Forms.Label();
            this.ProductsNumberPercentLabel = new System.Windows.Forms.Label();
            this.DiscountAmountPercentLabel = new System.Windows.Forms.Label();
            this.NumberDiscountPercentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InfoLabel.Location = new System.Drawing.Point(3, 9);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(223, 15);
            this.InfoLabel.TabIndex = 0;
            this.InfoLabel.Text = "Info: Накопительная - {Points} баллов";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(3, 42);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 1;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(84, 42);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyButton.TabIndex = 2;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(165, 42);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 3;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // ProductsAmountLabel
            // 
            this.ProductsAmountLabel.AutoSize = true;
            this.ProductsAmountLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProductsAmountLabel.Location = new System.Drawing.Point(352, 9);
            this.ProductsAmountLabel.Name = "ProductsAmountLabel";
            this.ProductsAmountLabel.Size = new System.Drawing.Size(107, 15);
            this.ProductsAmountLabel.TabIndex = 4;
            this.ProductsAmountLabel.Text = "Products Amount:";
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AmountLabel.Location = new System.Drawing.Point(356, 24);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(103, 30);
            this.AmountLabel.TabIndex = 5;
            this.AmountLabel.Text = "4 999, 90";
            // 
            // DiscountAmountLabel
            // 
            this.DiscountAmountLabel.AutoSize = true;
            this.DiscountAmountLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DiscountAmountLabel.Location = new System.Drawing.Point(352, 54);
            this.DiscountAmountLabel.Name = "DiscountAmountLabel";
            this.DiscountAmountLabel.Size = new System.Drawing.Size(107, 15);
            this.DiscountAmountLabel.TabIndex = 6;
            this.DiscountAmountLabel.Text = "Discount Amount:";
            // 
            // DiscountNumberLabel
            // 
            this.DiscountNumberLabel.AutoSize = true;
            this.DiscountNumberLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DiscountNumberLabel.Location = new System.Drawing.Point(410, 69);
            this.DiscountNumberLabel.Name = "DiscountNumberLabel";
            this.DiscountNumberLabel.Size = new System.Drawing.Size(49, 30);
            this.DiscountNumberLabel.TabIndex = 7;
            this.DiscountNumberLabel.Text = "499";
            // 
            // InfoPercentDiscountLabel
            // 
            this.InfoPercentDiscountLabel.AutoSize = true;
            this.InfoPercentDiscountLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InfoPercentDiscountLabel.Location = new System.Drawing.Point(3, 114);
            this.InfoPercentDiscountLabel.Name = "InfoPercentDiscountLabel";
            this.InfoPercentDiscountLabel.Size = new System.Drawing.Size(255, 15);
            this.InfoPercentDiscountLabel.TabIndex = 0;
            this.InfoPercentDiscountLabel.Text = "info: Процентная «{_category}» - {_discount}";
            // 
            // CalculatePercentButton
            // 
            this.CalculatePercentButton.Location = new System.Drawing.Point(3, 147);
            this.CalculatePercentButton.Name = "CalculatePercentButton";
            this.CalculatePercentButton.Size = new System.Drawing.Size(75, 23);
            this.CalculatePercentButton.TabIndex = 1;
            this.CalculatePercentButton.Text = "Calculate";
            this.CalculatePercentButton.UseVisualStyleBackColor = true;
            this.CalculatePercentButton.Click += new System.EventHandler(this.CalculatePercentButton_Click);
            // 
            // ApplyPercentButton
            // 
            this.ApplyPercentButton.Location = new System.Drawing.Point(84, 147);
            this.ApplyPercentButton.Name = "ApplyPercentButton";
            this.ApplyPercentButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyPercentButton.TabIndex = 2;
            this.ApplyPercentButton.Text = "Apply";
            this.ApplyPercentButton.UseVisualStyleBackColor = true;
            this.ApplyPercentButton.Click += new System.EventHandler(this.ApplyPercentButton_Click);
            // 
            // UpdatePercentButton
            // 
            this.UpdatePercentButton.Location = new System.Drawing.Point(165, 147);
            this.UpdatePercentButton.Name = "UpdatePercentButton";
            this.UpdatePercentButton.Size = new System.Drawing.Size(75, 23);
            this.UpdatePercentButton.TabIndex = 3;
            this.UpdatePercentButton.Text = "Update";
            this.UpdatePercentButton.UseVisualStyleBackColor = true;
            this.UpdatePercentButton.Click += new System.EventHandler(this.UpdatePercentButton_Click);
            // 
            // ProductsAmountPercentLabel
            // 
            this.ProductsAmountPercentLabel.AutoSize = true;
            this.ProductsAmountPercentLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProductsAmountPercentLabel.Location = new System.Drawing.Point(352, 114);
            this.ProductsAmountPercentLabel.Name = "ProductsAmountPercentLabel";
            this.ProductsAmountPercentLabel.Size = new System.Drawing.Size(107, 15);
            this.ProductsAmountPercentLabel.TabIndex = 4;
            this.ProductsAmountPercentLabel.Text = "Products Amount:";
            // 
            // ProductsNumberPercentLabel
            // 
            this.ProductsNumberPercentLabel.AutoSize = true;
            this.ProductsNumberPercentLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProductsNumberPercentLabel.Location = new System.Drawing.Point(356, 129);
            this.ProductsNumberPercentLabel.Name = "ProductsNumberPercentLabel";
            this.ProductsNumberPercentLabel.Size = new System.Drawing.Size(103, 30);
            this.ProductsNumberPercentLabel.TabIndex = 5;
            this.ProductsNumberPercentLabel.Text = "4 999, 90";
            // 
            // DiscountAmountPercentLabel
            // 
            this.DiscountAmountPercentLabel.AutoSize = true;
            this.DiscountAmountPercentLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DiscountAmountPercentLabel.Location = new System.Drawing.Point(352, 159);
            this.DiscountAmountPercentLabel.Name = "DiscountAmountPercentLabel";
            this.DiscountAmountPercentLabel.Size = new System.Drawing.Size(107, 15);
            this.DiscountAmountPercentLabel.TabIndex = 6;
            this.DiscountAmountPercentLabel.Text = "Discount Amount:";
            // 
            // NumberDiscountPercentLabel
            // 
            this.NumberDiscountPercentLabel.AutoSize = true;
            this.NumberDiscountPercentLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumberDiscountPercentLabel.Location = new System.Drawing.Point(410, 174);
            this.NumberDiscountPercentLabel.Name = "NumberDiscountPercentLabel";
            this.NumberDiscountPercentLabel.Size = new System.Drawing.Size(49, 30);
            this.NumberDiscountPercentLabel.TabIndex = 7;
            this.NumberDiscountPercentLabel.Text = "499";
            // 
            // DiscountsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NumberDiscountPercentLabel);
            this.Controls.Add(this.DiscountNumberLabel);
            this.Controls.Add(this.DiscountAmountPercentLabel);
            this.Controls.Add(this.DiscountAmountLabel);
            this.Controls.Add(this.ProductsNumberPercentLabel);
            this.Controls.Add(this.ProductsAmountPercentLabel);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.UpdatePercentButton);
            this.Controls.Add(this.ProductsAmountLabel);
            this.Controls.Add(this.ApplyPercentButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.CalculatePercentButton);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.InfoPercentDiscountLabel);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.InfoLabel);
            this.Name = "DiscountsTab";
            this.Size = new System.Drawing.Size(521, 317);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label InfoLabel;
        private Button CalculateButton;
        private Button ApplyButton;
        private Button UpdateButton;
        private Label ProductsAmountLabel;
        private Label AmountLabel;
        private Label DiscountAmountLabel;
        private Label DiscountNumberLabel;
        private Label InfoPercentDiscountLabel;
        private Button CalculatePercentButton;
        private Button ApplyPercentButton;
        private Button UpdatePercentButton;
        private Label ProductsAmountPercentLabel;
        private Label ProductsNumberPercentLabel;
        private Label DiscountAmountPercentLabel;
        private Label NumberDiscountPercentLabel;
    }
}
