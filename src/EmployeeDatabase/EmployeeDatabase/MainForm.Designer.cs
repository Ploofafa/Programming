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
            inputEmployeeControl = new Panels.InputEmployeeControl();
            SuspendLayout();
            // 
            // inputEmployeeControl
            // 
            inputEmployeeControl.Dock = DockStyle.Fill;
            inputEmployeeControl.Employees = null;
            inputEmployeeControl.Location = new Point(0, 0);
            inputEmployeeControl.MinimumSize = new Size(717, 397);
            inputEmployeeControl.Name = "inputEmployeeControl";
            inputEmployeeControl.Size = new Size(717, 397);
            inputEmployeeControl.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 397);
            Controls.Add(inputEmployeeControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(723, 436);
            Name = "MainForm";
            Text = "Employee database";
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load_1;
            ResumeLayout(false);
        }

        #endregion

        private Panels.InputEmployeeControl inputEmployeeControl;
    }
}