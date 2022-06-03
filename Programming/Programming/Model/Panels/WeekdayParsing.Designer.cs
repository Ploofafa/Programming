namespace Programming.Model.Panels
{
    partial class WeekdayParsing
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
            this.WeekdayTextBox = new System.Windows.Forms.TextBox();
            this.ParseButton = new System.Windows.Forms.Button();
            this.ParseTextValue = new System.Windows.Forms.Label();
            this.ParseTextOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WeekdayTextBox
            // 
            this.WeekdayTextBox.Location = new System.Drawing.Point(14, 34);
            this.WeekdayTextBox.Name = "WeekdayTextBox";
            this.WeekdayTextBox.Size = new System.Drawing.Size(145, 20);
            this.WeekdayTextBox.TabIndex = 11;
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(165, 34);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(75, 20);
            this.ParseButton.TabIndex = 10;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // ParseTextValue
            // 
            this.ParseTextValue.AutoSize = true;
            this.ParseTextValue.Location = new System.Drawing.Point(14, 16);
            this.ParseTextValue.Name = "ParseTextValue";
            this.ParseTextValue.Size = new System.Drawing.Size(115, 13);
            this.ParseTextValue.TabIndex = 9;
            this.ParseTextValue.Text = "Type value for parsing:";
            // 
            // ParseTextOutput
            // 
            this.ParseTextOutput.AutoSize = true;
            this.ParseTextOutput.Location = new System.Drawing.Point(11, 66);
            this.ParseTextOutput.Name = "ParseTextOutput";
            this.ParseTextOutput.Size = new System.Drawing.Size(0, 13);
            this.ParseTextOutput.TabIndex = 12;
            // 
            // WeekdayParsing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ParseTextOutput);
            this.Controls.Add(this.WeekdayTextBox);
            this.Controls.Add(this.ParseButton);
            this.Controls.Add(this.ParseTextValue);
            this.Name = "WeekdayParsing";
            this.Size = new System.Drawing.Size(280, 112);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WeekdayTextBox;
        private System.Windows.Forms.Button ParseButton;
        private System.Windows.Forms.Label ParseTextValue;
        private System.Windows.Forms.Label ParseTextOutput;
    }
}
