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
            this.RectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.RectangleLengthTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RectangleWidthLabel = new System.Windows.Forms.Label();
            this.RectangleWidthTextBox = new System.Windows.Forms.TextBox();
            this.XCentre = new System.Windows.Forms.Label();
            this.RectangleColorLabel = new System.Windows.Forms.Label();
            this.XCentreTextBox = new System.Windows.Forms.TextBox();
            this.RectangleColorTextBox = new System.Windows.Forms.TextBox();
            this.YCentre = new System.Windows.Forms.Label();
            this.YCentreTextBox = new System.Windows.Forms.TextBox();
            this.RectangleIdLabel = new System.Windows.Forms.Label();
            this.RectangleIdTextBox = new System.Windows.Forms.TextBox();
            this.RectangleFindButton = new System.Windows.Forms.Button();
            this.MoviesGroupBox = new System.Windows.Forms.GroupBox();
            this.MoviesListBox = new System.Windows.Forms.ListBox();
            this.MoviesRatingLabel = new System.Windows.Forms.Label();
            this.MoviesRatingTextBox = new System.Windows.Forms.TextBox();
            this.MoviesTitleLabel = new System.Windows.Forms.Label();
            this.MoviesTitleTextBox = new System.Windows.Forms.TextBox();
            this.MoviesYearLabel = new System.Windows.Forms.Label();
            this.MoviesYearTextBox = new System.Windows.Forms.TextBox();
            this.MoviesFindButton = new System.Windows.Forms.Button();
            this.Enums = new System.Windows.Forms.TabPage();
            this.GroupBoxEnum = new System.Windows.Forms.GroupBox();
            this.ChooseEnum = new System.Windows.Forms.Label();
            this.IndexBox = new System.Windows.Forms.TextBox();
            this.ChooseValue = new System.Windows.Forms.Label();
            this.IntValue = new System.Windows.Forms.Label();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumListBox = new System.Windows.Forms.ListBox();
            this.groupBoxParse = new System.Windows.Forms.GroupBox();
            this.ParseTextValue = new System.Windows.Forms.Label();
            this.ParseButton = new System.Windows.Forms.Button();
            this.WeekdayTextBox = new System.Windows.Forms.TextBox();
            this.ParseTextOutput = new System.Windows.Forms.Label();
            this.GroupBoxSeason = new System.Windows.Forms.GroupBox();
            this.SeasonLabel = new System.Windows.Forms.Label();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.SeasonButton = new System.Windows.Forms.Button();
            this.WinterLabel = new System.Windows.Forms.Label();
            this.MainTab = new System.Windows.Forms.TabControl();
            this.Classes.SuspendLayout();
            this.RectanglesGroupBox.SuspendLayout();
            this.MoviesGroupBox.SuspendLayout();
            this.Enums.SuspendLayout();
            this.GroupBoxEnum.SuspendLayout();
            this.groupBoxParse.SuspendLayout();
            this.GroupBoxSeason.SuspendLayout();
            this.MainTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // Classes
            // 
            this.Classes.Controls.Add(this.MoviesGroupBox);
            this.Classes.Controls.Add(this.RectanglesGroupBox);
            this.Classes.Location = new System.Drawing.Point(4, 22);
            this.Classes.Name = "Classes";
            this.Classes.Size = new System.Drawing.Size(563, 316);
            this.Classes.TabIndex = 1;
            this.Classes.Text = "Classes";
            this.Classes.UseVisualStyleBackColor = true;
            // 
            // RectanglesGroupBox
            // 
            this.RectanglesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RectanglesGroupBox.Controls.Add(this.RectangleFindButton);
            this.RectanglesGroupBox.Controls.Add(this.RectangleIdTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectangleIdLabel);
            this.RectanglesGroupBox.Controls.Add(this.YCentreTextBox);
            this.RectanglesGroupBox.Controls.Add(this.YCentre);
            this.RectanglesGroupBox.Controls.Add(this.RectangleColorTextBox);
            this.RectanglesGroupBox.Controls.Add(this.XCentreTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectangleColorLabel);
            this.RectanglesGroupBox.Controls.Add(this.XCentre);
            this.RectanglesGroupBox.Controls.Add(this.RectangleWidthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectangleWidthLabel);
            this.RectanglesGroupBox.Controls.Add(this.label1);
            this.RectanglesGroupBox.Controls.Add(this.RectangleLengthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectanglesListBox);
            this.RectanglesGroupBox.Location = new System.Drawing.Point(0, 0);
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.Size = new System.Drawing.Size(277, 316);
            this.RectanglesGroupBox.TabIndex = 0;
            this.RectanglesGroupBox.TabStop = false;
            this.RectanglesGroupBox.Text = "Rectangles";
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.Items.AddRange(new object[] {
            "Rectangle 1",
            "Rectangle 2",
            "Rectangle 3",
            "Rectangle 4",
            "Rectangle 5"});
            this.RectanglesListBox.Location = new System.Drawing.Point(6, 19);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(127, 277);
            this.RectanglesListBox.TabIndex = 1;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // RectangleLengthTextBox
            // 
            this.RectangleLengthTextBox.Location = new System.Drawing.Point(141, 35);
            this.RectangleLengthTextBox.Name = "RectangleLengthTextBox";
            this.RectangleLengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.RectangleLengthTextBox.TabIndex = 1;
            this.RectangleLengthTextBox.TextChanged += new System.EventHandler(this.RectangleLengthTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Length:";
            // 
            // RectangleWidthLabel
            // 
            this.RectangleWidthLabel.AutoSize = true;
            this.RectangleWidthLabel.Location = new System.Drawing.Point(138, 58);
            this.RectangleWidthLabel.Name = "RectangleWidthLabel";
            this.RectangleWidthLabel.Size = new System.Drawing.Size(38, 13);
            this.RectangleWidthLabel.TabIndex = 3;
            this.RectangleWidthLabel.Text = "Width:";
            // 
            // RectangleWidthTextBox
            // 
            this.RectangleWidthTextBox.Location = new System.Drawing.Point(141, 74);
            this.RectangleWidthTextBox.Name = "RectangleWidthTextBox";
            this.RectangleWidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.RectangleWidthTextBox.TabIndex = 4;
            this.RectangleWidthTextBox.TextChanged += new System.EventHandler(this.RectangleWidthTextBox_TextChanged);
            // 
            // XCentre
            // 
            this.XCentre.AutoSize = true;
            this.XCentre.Location = new System.Drawing.Point(138, 137);
            this.XCentre.Name = "XCentre";
            this.XCentre.Size = new System.Drawing.Size(50, 13);
            this.XCentre.TabIndex = 3;
            this.XCentre.Text = "X centre:";
            // 
            // RectangleColorLabel
            // 
            this.RectangleColorLabel.AutoSize = true;
            this.RectangleColorLabel.Location = new System.Drawing.Point(138, 97);
            this.RectangleColorLabel.Name = "RectangleColorLabel";
            this.RectangleColorLabel.Size = new System.Drawing.Size(34, 13);
            this.RectangleColorLabel.TabIndex = 5;
            this.RectangleColorLabel.Text = "Color:";
            // 
            // XCentreTextBox
            // 
            this.XCentreTextBox.Location = new System.Drawing.Point(141, 153);
            this.XCentreTextBox.Name = "XCentreTextBox";
            this.XCentreTextBox.Size = new System.Drawing.Size(100, 20);
            this.XCentreTextBox.TabIndex = 4;
            this.XCentreTextBox.TextChanged += new System.EventHandler(this.RectangleWidthTextBox_TextChanged);
            // 
            // RectangleColorTextBox
            // 
            this.RectangleColorTextBox.Location = new System.Drawing.Point(141, 113);
            this.RectangleColorTextBox.Name = "RectangleColorTextBox";
            this.RectangleColorTextBox.Size = new System.Drawing.Size(100, 20);
            this.RectangleColorTextBox.TabIndex = 6;
            // 
            // YCentre
            // 
            this.YCentre.AutoSize = true;
            this.YCentre.Location = new System.Drawing.Point(138, 176);
            this.YCentre.Name = "YCentre";
            this.YCentre.Size = new System.Drawing.Size(50, 13);
            this.YCentre.TabIndex = 5;
            this.YCentre.Text = "Y centre:";
            // 
            // YCentreTextBox
            // 
            this.YCentreTextBox.Location = new System.Drawing.Point(141, 192);
            this.YCentreTextBox.Name = "YCentreTextBox";
            this.YCentreTextBox.Size = new System.Drawing.Size(100, 20);
            this.YCentreTextBox.TabIndex = 6;
            // 
            // RectangleIdLabel
            // 
            this.RectangleIdLabel.AutoSize = true;
            this.RectangleIdLabel.Location = new System.Drawing.Point(138, 216);
            this.RectangleIdLabel.Name = "RectangleIdLabel";
            this.RectangleIdLabel.Size = new System.Drawing.Size(70, 13);
            this.RectangleIdLabel.TabIndex = 5;
            this.RectangleIdLabel.Text = "Rectangle id:";
            // 
            // RectangleIdTextBox
            // 
            this.RectangleIdTextBox.Location = new System.Drawing.Point(141, 232);
            this.RectangleIdTextBox.Name = "RectangleIdTextBox";
            this.RectangleIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.RectangleIdTextBox.TabIndex = 6;
            // 
            // RectangleFindButton
            // 
            this.RectangleFindButton.Location = new System.Drawing.Point(139, 273);
            this.RectangleFindButton.Name = "RectangleFindButton";
            this.RectangleFindButton.Size = new System.Drawing.Size(100, 23);
            this.RectangleFindButton.TabIndex = 7;
            this.RectangleFindButton.Text = "Find";
            this.RectangleFindButton.UseVisualStyleBackColor = true;
            this.RectangleFindButton.Click += new System.EventHandler(this.RectangleFindButton_Click);
            // 
            // MoviesGroupBox
            // 
            this.MoviesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MoviesGroupBox.Controls.Add(this.MoviesFindButton);
            this.MoviesGroupBox.Controls.Add(this.MoviesYearTextBox);
            this.MoviesGroupBox.Controls.Add(this.MoviesYearLabel);
            this.MoviesGroupBox.Controls.Add(this.MoviesTitleTextBox);
            this.MoviesGroupBox.Controls.Add(this.MoviesTitleLabel);
            this.MoviesGroupBox.Controls.Add(this.MoviesRatingTextBox);
            this.MoviesGroupBox.Controls.Add(this.MoviesRatingLabel);
            this.MoviesGroupBox.Controls.Add(this.MoviesListBox);
            this.MoviesGroupBox.Location = new System.Drawing.Point(283, 0);
            this.MoviesGroupBox.Name = "MoviesGroupBox";
            this.MoviesGroupBox.Size = new System.Drawing.Size(277, 316);
            this.MoviesGroupBox.TabIndex = 8;
            this.MoviesGroupBox.TabStop = false;
            this.MoviesGroupBox.Text = "Movies";
            // 
            // MoviesListBox
            // 
            this.MoviesListBox.FormattingEnabled = true;
            this.MoviesListBox.Items.AddRange(new object[] {
            "Movie 1",
            "Movie 2",
            "Movie 3",
            "Movie 4",
            "Movie 5",
            "Movie 6",
            "Movie 7",
            "Movie 8",
            "Movie 9",
            "Movie 10"});
            this.MoviesListBox.Location = new System.Drawing.Point(6, 19);
            this.MoviesListBox.Name = "MoviesListBox";
            this.MoviesListBox.Size = new System.Drawing.Size(127, 277);
            this.MoviesListBox.TabIndex = 0;
            this.MoviesListBox.SelectedIndexChanged += new System.EventHandler(this.MoviesListBox_SelectedIndexChanged);
            // 
            // MoviesRatingLabel
            // 
            this.MoviesRatingLabel.AutoSize = true;
            this.MoviesRatingLabel.Location = new System.Drawing.Point(136, 97);
            this.MoviesRatingLabel.Name = "MoviesRatingLabel";
            this.MoviesRatingLabel.Size = new System.Drawing.Size(41, 13);
            this.MoviesRatingLabel.TabIndex = 1;
            this.MoviesRatingLabel.Text = "Rating:";
            // 
            // MoviesRatingTextBox
            // 
            this.MoviesRatingTextBox.Location = new System.Drawing.Point(139, 113);
            this.MoviesRatingTextBox.Name = "MoviesRatingTextBox";
            this.MoviesRatingTextBox.Size = new System.Drawing.Size(100, 20);
            this.MoviesRatingTextBox.TabIndex = 2;
            this.MoviesRatingTextBox.TextChanged += new System.EventHandler(this.MoviesRatingTextBox_TextChanged);
            // 
            // MoviesTitleLabel
            // 
            this.MoviesTitleLabel.AutoSize = true;
            this.MoviesTitleLabel.Location = new System.Drawing.Point(136, 19);
            this.MoviesTitleLabel.Name = "MoviesTitleLabel";
            this.MoviesTitleLabel.Size = new System.Drawing.Size(30, 13);
            this.MoviesTitleLabel.TabIndex = 4;
            this.MoviesTitleLabel.Text = "Title:";
            // 
            // MoviesTitleTextBox
            // 
            this.MoviesTitleTextBox.Location = new System.Drawing.Point(139, 35);
            this.MoviesTitleTextBox.Name = "MoviesTitleTextBox";
            this.MoviesTitleTextBox.Size = new System.Drawing.Size(100, 20);
            this.MoviesTitleTextBox.TabIndex = 5;
            // 
            // MoviesYearLabel
            // 
            this.MoviesYearLabel.AutoSize = true;
            this.MoviesYearLabel.Location = new System.Drawing.Point(136, 58);
            this.MoviesYearLabel.Name = "MoviesYearLabel";
            this.MoviesYearLabel.Size = new System.Drawing.Size(32, 13);
            this.MoviesYearLabel.TabIndex = 6;
            this.MoviesYearLabel.Text = "Year:";
            // 
            // MoviesYearTextBox
            // 
            this.MoviesYearTextBox.Location = new System.Drawing.Point(139, 74);
            this.MoviesYearTextBox.Name = "MoviesYearTextBox";
            this.MoviesYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.MoviesYearTextBox.TabIndex = 7;
            this.MoviesYearTextBox.TextChanged += new System.EventHandler(this.MoviesYearTextBox_TextChanged);
            // 
            // MoviesFindButton
            // 
            this.MoviesFindButton.Location = new System.Drawing.Point(139, 273);
            this.MoviesFindButton.Name = "MoviesFindButton";
            this.MoviesFindButton.Size = new System.Drawing.Size(100, 23);
            this.MoviesFindButton.TabIndex = 8;
            this.MoviesFindButton.Text = "Find";
            this.MoviesFindButton.UseVisualStyleBackColor = true;
            this.MoviesFindButton.Click += new System.EventHandler(this.MoviesFindButton_Click);
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
            // GroupBoxEnum
            // 
            this.GroupBoxEnum.Controls.Add(this.ValuesListBox);
            this.GroupBoxEnum.Controls.Add(this.IntValue);
            this.GroupBoxEnum.Controls.Add(this.ChooseValue);
            this.GroupBoxEnum.Controls.Add(this.IndexBox);
            this.GroupBoxEnum.Controls.Add(this.ChooseEnum);
            this.GroupBoxEnum.Location = new System.Drawing.Point(0, 0);
            this.GroupBoxEnum.Margin = new System.Windows.Forms.Padding(5);
            this.GroupBoxEnum.Name = "GroupBoxEnum";
            this.GroupBoxEnum.Size = new System.Drawing.Size(560, 198);
            this.GroupBoxEnum.TabIndex = 6;
            this.GroupBoxEnum.TabStop = false;
            this.GroupBoxEnum.Text = "Enumerations";
            // 
            // ChooseEnum
            // 
            this.ChooseEnum.AutoSize = true;
            this.ChooseEnum.Location = new System.Drawing.Point(6, 18);
            this.ChooseEnum.Name = "ChooseEnum";
            this.ChooseEnum.Size = new System.Drawing.Size(107, 13);
            this.ChooseEnum.TabIndex = 3;
            this.ChooseEnum.Text = "Choose enumeration:";
            // 
            // IndexBox
            // 
            this.IndexBox.Location = new System.Drawing.Point(276, 34);
            this.IndexBox.Name = "IndexBox";
            this.IndexBox.Size = new System.Drawing.Size(100, 20);
            this.IndexBox.TabIndex = 2;
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
            // IntValue
            // 
            this.IntValue.AutoSize = true;
            this.IntValue.Location = new System.Drawing.Point(274, 18);
            this.IntValue.Name = "IntValue";
            this.IntValue.Size = new System.Drawing.Size(51, 13);
            this.IntValue.TabIndex = 5;
            this.IntValue.Text = "Int value:";
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
            // groupBoxParse
            // 
            this.groupBoxParse.Controls.Add(this.ParseTextOutput);
            this.groupBoxParse.Controls.Add(this.WeekdayTextBox);
            this.groupBoxParse.Controls.Add(this.ParseButton);
            this.groupBoxParse.Controls.Add(this.ParseTextValue);
            this.groupBoxParse.Location = new System.Drawing.Point(0, 204);
            this.groupBoxParse.Name = "groupBoxParse";
            this.groupBoxParse.Size = new System.Drawing.Size(280, 112);
            this.groupBoxParse.TabIndex = 7;
            this.groupBoxParse.TabStop = false;
            this.groupBoxParse.Text = "Weekday Parsing";
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
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(157, 48);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(75, 20);
            this.ParseButton.TabIndex = 7;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // WeekdayTextBox
            // 
            this.WeekdayTextBox.Location = new System.Drawing.Point(6, 48);
            this.WeekdayTextBox.Name = "WeekdayTextBox";
            this.WeekdayTextBox.Size = new System.Drawing.Size(145, 20);
            this.WeekdayTextBox.TabIndex = 8;
            // 
            // ParseTextOutput
            // 
            this.ParseTextOutput.AutoSize = true;
            this.ParseTextOutput.Location = new System.Drawing.Point(6, 69);
            this.ParseTextOutput.Name = "ParseTextOutput";
            this.ParseTextOutput.Size = new System.Drawing.Size(0, 13);
            this.ParseTextOutput.TabIndex = 9;
            // 
            // GroupBoxSeason
            // 
            this.GroupBoxSeason.Controls.Add(this.WinterLabel);
            this.GroupBoxSeason.Controls.Add(this.SeasonButton);
            this.GroupBoxSeason.Controls.Add(this.SeasonComboBox);
            this.GroupBoxSeason.Controls.Add(this.SeasonLabel);
            this.GroupBoxSeason.Location = new System.Drawing.Point(283, 204);
            this.GroupBoxSeason.Name = "GroupBoxSeason";
            this.GroupBoxSeason.Size = new System.Drawing.Size(280, 112);
            this.GroupBoxSeason.TabIndex = 8;
            this.GroupBoxSeason.TabStop = false;
            this.GroupBoxSeason.Text = "Season Handle";
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
            // SeasonButton
            // 
            this.SeasonButton.Location = new System.Drawing.Point(161, 47);
            this.SeasonButton.Name = "SeasonButton";
            this.SeasonButton.Size = new System.Drawing.Size(75, 21);
            this.SeasonButton.TabIndex = 10;
            this.SeasonButton.Text = "Go!";
            this.SeasonButton.UseVisualStyleBackColor = true;
            this.SeasonButton.Click += new System.EventHandler(this.SeasonButton_Click);
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
            // MainTab
            // 
            this.MainTab.Controls.Add(this.Enums);
            this.MainTab.Controls.Add(this.Classes);
            this.MainTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTab.Location = new System.Drawing.Point(0, 0);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(571, 342);
            this.MainTab.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 342);
            this.Controls.Add(this.MainTab);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Programming Demo";
            this.Classes.ResumeLayout(false);
            this.RectanglesGroupBox.ResumeLayout(false);
            this.RectanglesGroupBox.PerformLayout();
            this.MoviesGroupBox.ResumeLayout(false);
            this.MoviesGroupBox.PerformLayout();
            this.Enums.ResumeLayout(false);
            this.GroupBoxEnum.ResumeLayout(false);
            this.GroupBoxEnum.PerformLayout();
            this.groupBoxParse.ResumeLayout(false);
            this.groupBoxParse.PerformLayout();
            this.GroupBoxSeason.ResumeLayout(false);
            this.GroupBoxSeason.PerformLayout();
            this.MainTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage Classes;
        private System.Windows.Forms.GroupBox MoviesGroupBox;
        private System.Windows.Forms.Button MoviesFindButton;
        private System.Windows.Forms.TextBox MoviesYearTextBox;
        private System.Windows.Forms.Label MoviesYearLabel;
        private System.Windows.Forms.TextBox MoviesTitleTextBox;
        private System.Windows.Forms.Label MoviesTitleLabel;
        private System.Windows.Forms.TextBox MoviesRatingTextBox;
        private System.Windows.Forms.Label MoviesRatingLabel;
        private System.Windows.Forms.ListBox MoviesListBox;
        private System.Windows.Forms.GroupBox RectanglesGroupBox;
        private System.Windows.Forms.Button RectangleFindButton;
        private System.Windows.Forms.TextBox RectangleIdTextBox;
        private System.Windows.Forms.Label RectangleIdLabel;
        private System.Windows.Forms.TextBox YCentreTextBox;
        private System.Windows.Forms.Label YCentre;
        private System.Windows.Forms.TextBox RectangleColorTextBox;
        private System.Windows.Forms.TextBox XCentreTextBox;
        private System.Windows.Forms.Label RectangleColorLabel;
        private System.Windows.Forms.Label XCentre;
        private System.Windows.Forms.TextBox RectangleWidthTextBox;
        private System.Windows.Forms.Label RectangleWidthLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RectangleLengthTextBox;
        private System.Windows.Forms.ListBox RectanglesListBox;
        private System.Windows.Forms.TabPage Enums;
        private System.Windows.Forms.GroupBox GroupBoxSeason;
        private System.Windows.Forms.Label WinterLabel;
        private System.Windows.Forms.Button SeasonButton;
        private System.Windows.Forms.ComboBox SeasonComboBox;
        private System.Windows.Forms.Label SeasonLabel;
        private System.Windows.Forms.GroupBox groupBoxParse;
        private System.Windows.Forms.Label ParseTextOutput;
        private System.Windows.Forms.TextBox WeekdayTextBox;
        private System.Windows.Forms.Button ParseButton;
        private System.Windows.Forms.Label ParseTextValue;
        private System.Windows.Forms.ListBox EnumListBox;
        private System.Windows.Forms.GroupBox GroupBoxEnum;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.Label IntValue;
        private System.Windows.Forms.Label ChooseValue;
        private System.Windows.Forms.TextBox IndexBox;
        private System.Windows.Forms.Label ChooseEnum;
        private System.Windows.Forms.TabControl MainTab;
    }
}

