namespace Programming.Model.Panels
{
    partial class EnumerationsControl
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
            this.ChooseEnum = new System.Windows.Forms.Label();
            this.EnumListBox = new System.Windows.Forms.ListBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.IntValue = new System.Windows.Forms.Label();
            this.ChooseValue = new System.Windows.Forms.Label();
            this.IndexBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ChooseEnum
            // 
            this.ChooseEnum.AutoSize = true;
            this.ChooseEnum.Location = new System.Drawing.Point(20, 15);
            this.ChooseEnum.Name = "ChooseEnum";
            this.ChooseEnum.Size = new System.Drawing.Size(107, 13);
            this.ChooseEnum.TabIndex = 9;
            this.ChooseEnum.Text = "Choose enumeration:";
            // 
            // EnumListBox
            // 
            this.EnumListBox.FormattingEnabled = true;
            this.EnumListBox.Items.AddRange(new object[] {
            "Colors",
            "Genre",
            "Manufacturers",
            "Season",
            "StudyForm",
            "Weekday"});
            this.EnumListBox.Location = new System.Drawing.Point(20, 31);
            this.EnumListBox.Name = "EnumListBox";
            this.EnumListBox.ScrollAlwaysVisible = true;
            this.EnumListBox.Size = new System.Drawing.Size(117, 147);
            this.EnumListBox.TabIndex = 6;
            this.EnumListBox.Click += new System.EventHandler(this.EnumListBox_SelectedIndexChanged);
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.Location = new System.Drawing.Point(159, 31);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.ScrollAlwaysVisible = true;
            this.ValuesListBox.Size = new System.Drawing.Size(111, 147);
            this.ValuesListBox.TabIndex = 7;
            this.ValuesListBox.Click += new System.EventHandler(this.ValuesListBox_SystemColorsChanged);
            this.ValuesListBox.SystemColorsChanged += new System.EventHandler(this.ValuesListBox_SystemColorsChanged);
            // 
            // IntValue
            // 
            this.IntValue.AutoSize = true;
            this.IntValue.Location = new System.Drawing.Point(288, 15);
            this.IntValue.Name = "IntValue";
            this.IntValue.Size = new System.Drawing.Size(51, 13);
            this.IntValue.TabIndex = 11;
            this.IntValue.Text = "Int value:";
            // 
            // ChooseValue
            // 
            this.ChooseValue.AutoSize = true;
            this.ChooseValue.Location = new System.Drawing.Point(156, 15);
            this.ChooseValue.Name = "ChooseValue";
            this.ChooseValue.Size = new System.Drawing.Size(75, 13);
            this.ChooseValue.TabIndex = 10;
            this.ChooseValue.Text = "Choose value:";
            // 
            // IndexBox
            // 
            this.IndexBox.Location = new System.Drawing.Point(290, 31);
            this.IndexBox.Name = "IndexBox";
            this.IndexBox.Size = new System.Drawing.Size(100, 20);
            this.IndexBox.TabIndex = 8;
            // 
            // Enumerations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ChooseEnum);
            this.Controls.Add(this.EnumListBox);
            this.Controls.Add(this.ValuesListBox);
            this.Controls.Add(this.IntValue);
            this.Controls.Add(this.ChooseValue);
            this.Controls.Add(this.IndexBox);
            this.Name = "Enumerations";
            this.Size = new System.Drawing.Size(429, 198);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ChooseEnum;
        private System.Windows.Forms.ListBox EnumListBox;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.Label IntValue;
        private System.Windows.Forms.Label ChooseValue;
        private System.Windows.Forms.TextBox IndexBox;
    }
}
