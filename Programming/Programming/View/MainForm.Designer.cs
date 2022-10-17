namespace Programming.View
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Classes = new System.Windows.Forms.TabPage();
            this.MoviesGroupBox = new System.Windows.Forms.GroupBox();
            this.movies1 = new Programming.Model.Panels.MoviesControl();
            this.RectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.classesRectangle1 = new Programming.Model.Panels.ClassesRectangleControl();
            this.Enums = new System.Windows.Forms.TabPage();
            this.GroupBoxSeason = new System.Windows.Forms.GroupBox();
            this.seasondHandler1 = new Programming.Model.Panels.SeasonHandlerControl();
            this.groupBoxParse = new System.Windows.Forms.GroupBox();
            this.weekdayParsing1 = new Programming.Model.Panels.WeekdayParsingControl();
            this.GroupBoxEnum = new System.Windows.Forms.GroupBox();
            this.enumerations1 = new Programming.Model.Panels.EnumerationsControl();
            this.MainTab = new System.Windows.Forms.TabControl();
            this.RectanglesTabPage = new System.Windows.Forms.TabPage();
            this.rectanglesCollisionControl1 = new Programming.Model.Panels.RectanglesCollisionControl();
            this.Classes.SuspendLayout();
            this.MoviesGroupBox.SuspendLayout();
            this.RectanglesGroupBox.SuspendLayout();
            this.Enums.SuspendLayout();
            this.GroupBoxSeason.SuspendLayout();
            this.groupBoxParse.SuspendLayout();
            this.GroupBoxEnum.SuspendLayout();
            this.MainTab.SuspendLayout();
            this.RectanglesTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // Classes
            // 
            this.Classes.Controls.Add(this.MoviesGroupBox);
            this.Classes.Controls.Add(this.RectanglesGroupBox);
            this.Classes.Location = new System.Drawing.Point(4, 22);
            this.Classes.Name = "Classes";
            this.Classes.Size = new System.Drawing.Size(572, 386);
            this.Classes.TabIndex = 1;
            this.Classes.Text = "Classes";
            this.Classes.UseVisualStyleBackColor = true;
            // 
            // MoviesGroupBox
            // 
            this.MoviesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MoviesGroupBox.Controls.Add(this.movies1);
            this.MoviesGroupBox.Location = new System.Drawing.Point(283, 0);
            this.MoviesGroupBox.Name = "MoviesGroupBox";
            this.MoviesGroupBox.Size = new System.Drawing.Size(277, 379);
            this.MoviesGroupBox.TabIndex = 8;
            this.MoviesGroupBox.TabStop = false;
            this.MoviesGroupBox.Text = "Movies";
            // 
            // movies1
            // 
            this.movies1.Location = new System.Drawing.Point(6, 19);
            this.movies1.Name = "movies1";
            this.movies1.Size = new System.Drawing.Size(240, 284);
            this.movies1.TabIndex = 0;
            // 
            // RectanglesGroupBox
            // 
            this.RectanglesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RectanglesGroupBox.Controls.Add(this.classesRectangle1);
            this.RectanglesGroupBox.Location = new System.Drawing.Point(0, 0);
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.Size = new System.Drawing.Size(277, 379);
            this.RectanglesGroupBox.TabIndex = 0;
            this.RectanglesGroupBox.TabStop = false;
            this.RectanglesGroupBox.Text = "Rectangles";
            // 
            // classesRectangle1
            // 
            this.classesRectangle1.Location = new System.Drawing.Point(3, 19);
            this.classesRectangle1.Name = "classesRectangle1";
            this.classesRectangle1.Size = new System.Drawing.Size(242, 286);
            this.classesRectangle1.TabIndex = 0;
            // 
            // Enums
            // 
            this.Enums.Controls.Add(this.GroupBoxSeason);
            this.Enums.Controls.Add(this.groupBoxParse);
            this.Enums.Controls.Add(this.GroupBoxEnum);
            this.Enums.Location = new System.Drawing.Point(4, 22);
            this.Enums.Name = "Enums";
            this.Enums.Padding = new System.Windows.Forms.Padding(3);
            this.Enums.Size = new System.Drawing.Size(572, 386);
            this.Enums.TabIndex = 0;
            this.Enums.Text = "Enums";
            this.Enums.UseVisualStyleBackColor = true;
            // 
            // GroupBoxSeason
            // 
            this.GroupBoxSeason.Controls.Add(this.seasondHandler1);
            this.GroupBoxSeason.Location = new System.Drawing.Point(283, 204);
            this.GroupBoxSeason.Name = "GroupBoxSeason";
            this.GroupBoxSeason.Size = new System.Drawing.Size(280, 112);
            this.GroupBoxSeason.TabIndex = 8;
            this.GroupBoxSeason.TabStop = false;
            this.GroupBoxSeason.Text = "Season Handle";
            // 
            // seasondHandler1
            // 
            this.seasondHandler1.BackColor = System.Drawing.Color.White;
            this.seasondHandler1.Location = new System.Drawing.Point(3, 19);
            this.seasondHandler1.Name = "seasondHandler1";
            this.seasondHandler1.Size = new System.Drawing.Size(271, 87);
            this.seasondHandler1.TabIndex = 0;
            // 
            // groupBoxParse
            // 
            this.groupBoxParse.Controls.Add(this.weekdayParsing1);
            this.groupBoxParse.Location = new System.Drawing.Point(0, 204);
            this.groupBoxParse.Name = "groupBoxParse";
            this.groupBoxParse.Size = new System.Drawing.Size(280, 112);
            this.groupBoxParse.TabIndex = 7;
            this.groupBoxParse.TabStop = false;
            this.groupBoxParse.Text = "Weekday Parsing";
            // 
            // weekdayParsing1
            // 
            this.weekdayParsing1.Location = new System.Drawing.Point(0, 19);
            this.weekdayParsing1.Name = "weekdayParsing1";
            this.weekdayParsing1.Size = new System.Drawing.Size(274, 87);
            this.weekdayParsing1.TabIndex = 0;
            // 
            // GroupBoxEnum
            // 
            this.GroupBoxEnum.Controls.Add(this.enumerations1);
            this.GroupBoxEnum.Location = new System.Drawing.Point(0, 0);
            this.GroupBoxEnum.Margin = new System.Windows.Forms.Padding(5);
            this.GroupBoxEnum.Name = "GroupBoxEnum";
            this.GroupBoxEnum.Size = new System.Drawing.Size(563, 198);
            this.GroupBoxEnum.TabIndex = 6;
            this.GroupBoxEnum.TabStop = false;
            this.GroupBoxEnum.Text = "Enumerations";
            // 
            // enumerations1
            // 
            this.enumerations1.Location = new System.Drawing.Point(-15, 6);
            this.enumerations1.Name = "enumerations1";
            this.enumerations1.Size = new System.Drawing.Size(429, 198);
            this.enumerations1.TabIndex = 0;
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.Enums);
            this.MainTab.Controls.Add(this.Classes);
            this.MainTab.Controls.Add(this.RectanglesTabPage);
            this.MainTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTab.Location = new System.Drawing.Point(0, 0);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(580, 412);
            this.MainTab.TabIndex = 0;
            // 
            // RectanglesTabPage
            // 
            this.RectanglesTabPage.Controls.Add(this.rectanglesCollisionControl1);
            this.RectanglesTabPage.Cursor = System.Windows.Forms.Cursors.Default;
            this.RectanglesTabPage.Location = new System.Drawing.Point(4, 22);
            this.RectanglesTabPage.Name = "RectanglesTabPage";
            this.RectanglesTabPage.Size = new System.Drawing.Size(572, 386);
            this.RectanglesTabPage.TabIndex = 2;
            this.RectanglesTabPage.Text = "Rectangles";
            this.RectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl1
            // 
            this.rectanglesCollisionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectanglesCollisionControl1.Location = new System.Drawing.Point(0, 0);
            this.rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            this.rectanglesCollisionControl1.Size = new System.Drawing.Size(572, 386);
            this.rectanglesCollisionControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 412);
            this.Controls.Add(this.MainTab);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Programming Demo";
            this.Classes.ResumeLayout(false);
            this.MoviesGroupBox.ResumeLayout(false);
            this.RectanglesGroupBox.ResumeLayout(false);
            this.Enums.ResumeLayout(false);
            this.GroupBoxSeason.ResumeLayout(false);
            this.groupBoxParse.ResumeLayout(false);
            this.GroupBoxEnum.ResumeLayout(false);
            this.MainTab.ResumeLayout(false);
            this.RectanglesTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage Classes;
        private System.Windows.Forms.GroupBox MoviesGroupBox;
        private System.Windows.Forms.GroupBox RectanglesGroupBox;
        private System.Windows.Forms.TabPage Enums;
        private System.Windows.Forms.GroupBox GroupBoxSeason;
        private System.Windows.Forms.GroupBox groupBoxParse;
        private System.Windows.Forms.GroupBox GroupBoxEnum;
        private System.Windows.Forms.TabControl MainTab;
        private System.Windows.Forms.TabPage RectanglesTabPage;
        private Model.Panels.RectanglesCollisionControl rectanglesCollisionControl1;
        private Model.Panels.EnumerationsControl enumerations1;
        private Model.Panels.WeekdayParsingControl weekdayParsing1;
        private Model.Panels.SeasonHandlerControl seasondHandler1;
        private Model.Panels.ClassesRectangleControl classesRectangle1;
        private Model.Panels.MoviesControl movies1;
    }
}

