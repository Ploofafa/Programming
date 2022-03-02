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
            this.MainTab = new System.Windows.Forms.TabControl();
            this.Enums = new System.Windows.Forms.TabPage();
            this.GroupBoxSeason = new System.Windows.Forms.GroupBox();
            this.WinterLabel = new System.Windows.Forms.Label();
            this.SeasonButton = new System.Windows.Forms.Button();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.SeasonLabel = new System.Windows.Forms.Label();
            this.groupBoxParse = new System.Windows.Forms.GroupBox();
            this.ParseTextOutput = new System.Windows.Forms.Label();
            this.WeekdayTextBox = new System.Windows.Forms.TextBox();
            this.ParseButton = new System.Windows.Forms.Button();
            this.ParseTextValue = new System.Windows.Forms.Label();
            this.EnumListBox = new System.Windows.Forms.ListBox();
            this.GroupBoxEnum = new System.Windows.Forms.GroupBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.IntValue = new System.Windows.Forms.Label();
            this.ChooseValue = new System.Windows.Forms.Label();
            this.IndexBox = new System.Windows.Forms.TextBox();
            this.ChooseEnum = new System.Windows.Forms.Label();
            this.MainTab.SuspendLayout();
            this.Enums.SuspendLayout();
            this.GroupBoxSeason.SuspendLayout();
            this.groupBoxParse.SuspendLayout();
            this.GroupBoxEnum.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.Enums);
            this.MainTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTab.Location = new System.Drawing.Point(0, 0);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(571, 342);
            this.MainTab.TabIndex = 0;
            // 
            // Enums
            // 
            this.Enums.Controls.Add(this.GroupBoxSeason);
            this.Enums.Controls.Add(this.groupBoxParse);
            this.Enums.Controls.Add(this.EnumListBox);
            this.Enums.Controls.Add(this.GroupBoxEnum);
            this.Enums.Location = new System.Drawing.Point(4, 22);
            this.Enums.Name = "Enums";
            this.Enums.Padding = new System.Windows.Forms.Padding(3);
            this.Enums.Size = new System.Drawing.Size(563, 316);
            this.Enums.TabIndex = 0;
            this.Enums.Text = "Enums";
            this.Enums.UseVisualStyleBackColor = true;
            // 
            // GroupBoxSeason
            // 
            this.GroupBoxSeason.Controls.Add(this.WinterLabel);
            this.GroupBoxSeason.Controls.Add(this.SeasonButton);
            this.GroupBoxSeason.Controls.Add(this.SeasonComboBox);
            this.GroupBoxSeason.Controls.Add(this.SeasonLabel);
            this.GroupBoxSeason.Location = new System.Drawing.Point(262, 204);
            this.GroupBoxSeason.Name = "GroupBoxSeason";
            this.GroupBoxSeason.Size = new System.Drawing.Size(292, 109);
            this.GroupBoxSeason.TabIndex = 8;
            this.GroupBoxSeason.TabStop = false;
            this.GroupBoxSeason.Text = "Season Handle";
            // 
            // WinterLabel
            // 
            this.WinterLabel.AutoSize = true;
            this.WinterLabel.Location = new System.Drawing.Point(6, 71);
            this.WinterLabel.Name = "WinterLabel";
            this.WinterLabel.Size = new System.Drawing.Size(176, 13);
            this.WinterLabel.TabIndex = 11;
            this.WinterLabel.Text = "Зима... Рука на мышке мерзнет…";
            this.WinterLabel.Visible = false;
            // 
            // SeasonButton
            // 
            this.SeasonButton.Location = new System.Drawing.Point(161, 46);
            this.SeasonButton.Name = "SeasonButton";
            this.SeasonButton.Size = new System.Drawing.Size(75, 19);
            this.SeasonButton.TabIndex = 10;
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
            this.SeasonComboBox.Location = new System.Drawing.Point(9, 47);
            this.SeasonComboBox.Name = "SeasonComboBox";
            this.SeasonComboBox.Size = new System.Drawing.Size(146, 21);
            this.SeasonComboBox.TabIndex = 9;
            // 
            // SeasonLabel
            // 
            this.SeasonLabel.AutoSize = true;
            this.SeasonLabel.Location = new System.Drawing.Point(6, 30);
            this.SeasonLabel.Name = "SeasonLabel";
            this.SeasonLabel.Size = new System.Drawing.Size(83, 13);
            this.SeasonLabel.TabIndex = 0;
            this.SeasonLabel.Text = "Choose season:";
            // 
            // groupBoxParse
            // 
            this.groupBoxParse.Controls.Add(this.ParseTextOutput);
            this.groupBoxParse.Controls.Add(this.WeekdayTextBox);
            this.groupBoxParse.Controls.Add(this.ParseButton);
            this.groupBoxParse.Controls.Add(this.ParseTextValue);
            this.groupBoxParse.Location = new System.Drawing.Point(6, 204);
            this.groupBoxParse.Name = "groupBoxParse";
            this.groupBoxParse.Size = new System.Drawing.Size(250, 109);
            this.groupBoxParse.TabIndex = 7;
            this.groupBoxParse.TabStop = false;
            this.groupBoxParse.Text = "Weekday Parsing";
            // 
            // ParseTextOutput
            // 
            this.ParseTextOutput.AutoSize = true;
            this.ParseTextOutput.Location = new System.Drawing.Point(6, 69);
            this.ParseTextOutput.Name = "ParseTextOutput";
            this.ParseTextOutput.Size = new System.Drawing.Size(0, 13);
            this.ParseTextOutput.TabIndex = 9;
            // 
            // WeekdayTextBox
            // 
            this.WeekdayTextBox.Location = new System.Drawing.Point(4, 47);
            this.WeekdayTextBox.Name = "WeekdayTextBox";
            this.WeekdayTextBox.Size = new System.Drawing.Size(145, 20);
            this.WeekdayTextBox.TabIndex = 8;
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(155, 46);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(75, 20);
            this.ParseButton.TabIndex = 7;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // ParseTextValue
            // 
            this.ParseTextValue.AutoSize = true;
            this.ParseTextValue.Location = new System.Drawing.Point(6, 30);
            this.ParseTextValue.Name = "ParseTextValue";
            this.ParseTextValue.Size = new System.Drawing.Size(115, 13);
            this.ParseTextValue.TabIndex = 6;
            this.ParseTextValue.Text = "Type value for parsing:";
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
            this.EnumListBox.Location = new System.Drawing.Point(6, 34);
            this.EnumListBox.Name = "EnumListBox";
            this.EnumListBox.ScrollAlwaysVisible = true;
            this.EnumListBox.Size = new System.Drawing.Size(117, 147);
            this.EnumListBox.TabIndex = 0;
            this.EnumListBox.SelectedIndexChanged += new System.EventHandler(this.EnumListBox_SelectedIndexChanged);
            // 
            // GroupBoxEnum
            // 
            this.GroupBoxEnum.Controls.Add(this.ValuesListBox);
            this.GroupBoxEnum.Controls.Add(this.IntValue);
            this.GroupBoxEnum.Controls.Add(this.ChooseValue);
            this.GroupBoxEnum.Controls.Add(this.IndexBox);
            this.GroupBoxEnum.Controls.Add(this.ChooseEnum);
            this.GroupBoxEnum.Location = new System.Drawing.Point(0, 0);
            this.GroupBoxEnum.Name = "GroupBoxEnum";
            this.GroupBoxEnum.Size = new System.Drawing.Size(560, 198);
            this.GroupBoxEnum.TabIndex = 6;
            this.GroupBoxEnum.TabStop = false;
            this.GroupBoxEnum.Text = "Enumaraions";
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.Location = new System.Drawing.Point(145, 34);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.ScrollAlwaysVisible = true;
            this.ValuesListBox.Size = new System.Drawing.Size(111, 147);
            this.ValuesListBox.TabIndex = 1;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // IntValue
            // 
            this.IntValue.AutoSize = true;
            this.IntValue.Location = new System.Drawing.Point(274, 18);
            this.IntValue.Name = "IntValue";
            this.IntValue.Size = new System.Drawing.Size(51, 13);
            this.IntValue.TabIndex = 5;
            this.IntValue.Text = "Int value:";
            // 
            // ChooseValue
            // 
            this.ChooseValue.AutoSize = true;
            this.ChooseValue.Location = new System.Drawing.Point(142, 18);
            this.ChooseValue.Name = "ChooseValue";
            this.ChooseValue.Size = new System.Drawing.Size(75, 13);
            this.ChooseValue.TabIndex = 4;
            this.ChooseValue.Text = "Choose value:";
            // 
            // IndexBox
            // 
            this.IndexBox.Location = new System.Drawing.Point(276, 34);
            this.IndexBox.Name = "IndexBox";
            this.IndexBox.Size = new System.Drawing.Size(100, 20);
            this.IndexBox.TabIndex = 2;
            // 
            // ChooseEnum
            // 
            this.ChooseEnum.AutoSize = true;
            this.ChooseEnum.Location = new System.Drawing.Point(6, 18);
            this.ChooseEnum.Name = "ChooseEnum";
            this.ChooseEnum.Size = new System.Drawing.Size(107, 13);
            this.ChooseEnum.TabIndex = 3;
            this.ChooseEnum.Text = "Choose enumaration:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 342);
            this.Controls.Add(this.MainTab);
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.MainTab.ResumeLayout(false);
            this.Enums.ResumeLayout(false);
            this.GroupBoxSeason.ResumeLayout(false);
            this.GroupBoxSeason.PerformLayout();
            this.groupBoxParse.ResumeLayout(false);
            this.groupBoxParse.PerformLayout();
            this.GroupBoxEnum.ResumeLayout(false);
            this.GroupBoxEnum.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTab;
        private System.Windows.Forms.TabPage Enums;
        private System.Windows.Forms.Label IntValue;
        private System.Windows.Forms.Label ChooseValue;
        private System.Windows.Forms.Label ChooseEnum;
        private System.Windows.Forms.TextBox IndexBox;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.ListBox EnumListBox;
        private System.Windows.Forms.GroupBox GroupBoxEnum;
        private System.Windows.Forms.GroupBox groupBoxParse;
        private System.Windows.Forms.TextBox WeekdayTextBox;
        private System.Windows.Forms.Button ParseButton;
        private System.Windows.Forms.Label ParseTextValue;
        private System.Windows.Forms.Label ParseTextOutput;
        private System.Windows.Forms.GroupBox GroupBoxSeason;
        private System.Windows.Forms.Button SeasonButton;
        private System.Windows.Forms.ComboBox SeasonComboBox;
        private System.Windows.Forms.Label SeasonLabel;
        private System.Windows.Forms.Label WinterLabel;
    }
}

