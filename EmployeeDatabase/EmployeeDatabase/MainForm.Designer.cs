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
            this.inputEmployeeControl1 = new EmployeeDatabase.Panels.InputEmployeeControl();
            this.SuspendLayout();
            // 
            // inputEmployeeControl1
            // 
            this.inputEmployeeControl1.Location = new System.Drawing.Point(12, 12);
            this.inputEmployeeControl1.Name = "inputEmployeeControl1";
            this.inputEmployeeControl1.Size = new System.Drawing.Size(765, 381);
            this.inputEmployeeControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 397);
            this.Controls.Add(this.inputEmployeeControl1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Employee datebase";
            this.ResumeLayout(false);

        }

        #endregion

        private Panels.InputEmployeeControl inputEmployeeControl1;
    }
}