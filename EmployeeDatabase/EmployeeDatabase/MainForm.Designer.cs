namespace EmployeeDatabase
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.inputEmployeeControl = new EmployeeDatabase.Panels.InputEmployeeControl();
            this.SuspendLayout();
            // 
            // inputEmployeeControl
            // 
            this.inputEmployeeControl.Location = new System.Drawing.Point(1, -6);
            this.inputEmployeeControl.Name = "inputEmployeeControl";
            this.inputEmployeeControl.Size = new System.Drawing.Size(765, 381);
            this.inputEmployeeControl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 397);
            this.Controls.Add(this.inputEmployeeControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Employee database";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private Panels.InputEmployeeControl inputEmployeeControl;
    }
}