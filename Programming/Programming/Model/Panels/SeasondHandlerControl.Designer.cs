namespace Programming.Model.Panels
{
    partial class SeasondHandlerControl
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
            this.SeasonButton = new System.Windows.Forms.Button();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.SeasonLabel = new System.Windows.Forms.Label();
            this.AutumnLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SeasonButton
            // 
            this.SeasonButton.Location = new System.Drawing.Point(165, 34);
            this.SeasonButton.Name = "SeasonButton";
            this.SeasonButton.Size = new System.Drawing.Size(75, 21);
            this.SeasonButton.TabIndex = 14;
            this.SeasonButton.Text = "Go!";
            this.SeasonButton.UseVisualStyleBackColor = true;
            this.SeasonButton.Click += new System.EventHandler(this.SeasonButton_Click);
            // 
            // SeasonComboBox
            // 
            this.SeasonComboBox.FormattingEnabled = true;
            this.SeasonComboBox.Items.AddRange(new object[] {
            "Summer",
            "Autumn",
            "Winter",
            "Spring"});
            this.SeasonComboBox.Location = new System.Drawing.Point(14, 34);
            this.SeasonComboBox.Name = "SeasonComboBox";
            this.SeasonComboBox.Size = new System.Drawing.Size(146, 21);
            this.SeasonComboBox.TabIndex = 13;
            // 
            // SeasonLabel
            // 
            this.SeasonLabel.AutoSize = true;
            this.SeasonLabel.Location = new System.Drawing.Point(14, 16);
            this.SeasonLabel.Name = "SeasonLabel";
            this.SeasonLabel.Size = new System.Drawing.Size(83, 13);
            this.SeasonLabel.TabIndex = 12;
            this.SeasonLabel.Text = "Choose season:";
            // 
            // AutumnLabel
            // 
            this.AutumnLabel.AutoSize = true;
            this.AutumnLabel.Location = new System.Drawing.Point(14, 58);
            this.AutumnLabel.Name = "AutumnLabel";
            this.AutumnLabel.Size = new System.Drawing.Size(123, 13);
            this.AutumnLabel.TabIndex = 15;
            this.AutumnLabel.Text = "Orange hit of the season";
            this.AutumnLabel.Visible = false;
            // 
            // SeasondHandlerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AutumnLabel);
            this.Controls.Add(this.SeasonButton);
            this.Controls.Add(this.SeasonComboBox);
            this.Controls.Add(this.SeasonLabel);
            this.Name = "SeasondHandlerControl";
            this.Size = new System.Drawing.Size(280, 112);
            this.Load += new System.EventHandler(this.SeasondHandler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SeasonButton;
        private System.Windows.Forms.ComboBox SeasonComboBox;
        private System.Windows.Forms.Label SeasonLabel;
        private System.Windows.Forms.Label AutumnLabel;
    }
}
