using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Programming.Model.Enums;
using Programming.Model.Classes;
using Rectangle = Programming.Model.Classes.Rectangle;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        private readonly Color _normalColor = Color.White;

        private readonly Color _errorColor = Color.LightPink;

        private Model.Classes.Rectangle[] _rectanglesClasses;

        private Model.Classes.Rectangle _currentRectangleClasses;

        private ToolTip _toolTip = new ToolTip();

        private Movie[] _movies;
        
        private Movie _currentMovie;

        private List<Model.Classes.Rectangle> _rectanglesLists = new List<Model.Classes.Rectangle>(200);

        private Model.Classes.Rectangle _currentRectangleLists;

        private List<Panel> _rectanglePanels = new List<Panel>();

        private int _rectangleId = 0;

        private int _rectanglesCount = 5;

        private Double DoubleRandom(int randomBottomBorder,
                                    int randomTopBorder,
                                    int precision,
                                    Random random)
        {
            var number = random.Next(randomBottomBorder, randomTopBorder) + Math.Round(random.NextDouble(), precision);
            return number;
        }

        private void InitRectangles()
        {
            _rectanglesClasses = new Rectangle[_rectanglesCount];
            Random random = new Random();
            string[] rectangleColor = new string[] { "Black", "Yellow", "Green", "Blue", "Red", "White" };

            for (int i = 0; i < _rectanglesClasses.Length; i++)
            {
                _rectanglesClasses[i] = new Model.Classes.Rectangle();
                _rectanglesClasses[i].Width = random.Next(1, 200);
                _rectanglesClasses[i].Height = random.Next(1, 200);
                _rectanglesClasses[i].Color = rectangleColor[random.Next(0, rectangleColor.Length)];
                _rectanglesClasses[i].Centre = new Point2D(random.Next(0, 100), random.Next(0, 150));
            }
            RectangleListBox.SelectedIndex = 0;
        }
        
        private Rectangle ItemAddListBox(Rectangle rectangle)
        {
            _rectanglesLists.Add(rectangle);
            RectanglesListBox.Items.Add("");
            return rectangle;
        }

        private Rectangle RectanglesCreate()
        
        {
            Random random = new Random();
            Model.Classes.Rectangle rectangle = new Model.Classes.Rectangle();
            rectangle.Width = random.Next(1, 200);
            rectangle.Height = random.Next(1, 200);
            rectangle.Centre = new Point2D(random.Next(0, 100), random.Next(0, 150));
            return rectangle;
        }

        private void UpdateRectanglesInfo(Model.Classes.Rectangle rectangle)
        {
            RectanglesListBox.Items[RectanglesListBox.SelectedIndex] = ($"{rectangle.RectangleId}:" +
                    $"X = {rectangle.Centre.X}; Y = {rectangle.Centre.Y};" +
                    $"W = {rectangle.Width}; H = {rectangle.Height}");
        }

        private void PanelAddListBox(Panel panel)
        {
            _rectanglePanels.Add(panel);
            CanvasPanel.Controls.Add(panel);
        }

        private void InitMovies()
        {
            Random random = new Random();
            int moviesCount = 10;
            _movies = new Movie[moviesCount];
            string[] moviesTitle = new string[] { "The Power of the Dog", "Undine", "King Richard", "Mass",
            "Identifying Features", "Nightmare Alley", "Drive My Car", "Licorice Pizza", "The French Dispatch",
            "Petite Maman", "C’mon C’mon", "The Green Knight", "Dune", "Summer of Soul", "The Lost Daughter"};

            for (int i = 0; i < _movies.Length; i++)
            {
                _movies[i] = new Movie();
                _movies[i].Year = random.Next(1900, 2022);
                _movies[i].Rating = DoubleRandom(1, 10, 2, random);
                _movies[i].Title = moviesTitle[random.Next(0, moviesTitle.Length)];
            }
            MoviesListBox.SelectedIndex = 0;
        }

        private int FindMovieWithMaxRating(Movie[] movies)
        {
            double maxRating = -1;
            int currentIndex = 0;
            for (int i = 0; i < movies.Length; i++)
            {
                if (movies[i].Rating > maxRating)
                {
                    maxRating = movies[i].Rating;
                    currentIndex = i;
                }
            }
            return currentIndex;
        }

        private int FindRectangleWithMaxWidth(Model.Classes.Rectangle[] rectangles)
        {
            double maxWidth = -1;
            int currentIndex = 0;
            for (int i = 0; i < rectangles.Length; i++)
            {
                if (rectangles[i].Width > maxWidth)
                {
                    maxWidth = rectangles[i].Width;
                    currentIndex = i;
                }
            }
            return currentIndex;
        }

        private Panel PanelCreate(Model.Classes.Rectangle rectangle)
        {
            Panel panel = new Panel();
            panel.Location = new Point(rectangle.Centre.X, rectangle.Centre.Y);
            panel.Size = new Size(rectangle.Width, rectangle.Height);
            panel.BackColor = Color.FromArgb(127, 127, 255, 127);
            return panel;
        }

        private void ChangedRectanglesPanel(Panel panel)
        {
                panel.Location = new Point(_currentRectangleLists.Centre.X, _currentRectangleLists.Centre.Y);
                panel.Size = new Size(_currentRectangleLists.Width, _currentRectangleLists.Height);
        }

        private void FindCollisions()
        {
            for(int i = 0; i < _rectanglesLists.Count; i++)
            {
                _rectanglePanels[i].BackColor = Color.FromArgb(127, 127, 255, 127);
            }
            for (int i = 0; i < _rectanglesLists.Count; i++)
            {
                for (int g = i + 1; g < _rectanglesLists.Count; g++)
                {
                    if (CollisionManager.IsCollision(_rectanglesLists[i], _rectanglesLists[g]) == true)
                    {
                        _rectanglePanels[i].BackColor = Color.FromArgb(127, 255, 127, 127);
                        _rectanglePanels[g].BackColor = Color.FromArgb(127, 255, 127, 127);
                    }
                }
            }
        }

        public MainForm()
        {
            InitializeComponent();
            EnumListBox.DataSource = Enum.GetValues(typeof(Enums));
            SeasonComboBox.DataSource = Enum.GetValues(typeof(Season));
            EnumListBox.SelectedIndex = 0;
            RectanglesIdTextBox.ReadOnly = true;

            InitRectangles();

            InitMovies();
        }
        
        private void EnumListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IndexBox.Clear();
            switch (EnumListBox.SelectedItem)
            {
                case Programming.View.Enums.Colors:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Colors));
                    break;
                case Programming.View.Enums.Genre:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Genre));
                    break;
                case Programming.View.Enums.Weekday:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Weekday));
                    break;
                case Programming.View.Enums.StudyForm:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(StudyForm));
                    break;
                case Programming.View.Enums.Manufacturers:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Manufacturers));
                    break;
                case Programming.View.Enums.Season:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Season));
                    break;
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentIndex = ValuesListBox.SelectedItem;
            IndexBox.Text = ((int)currentIndex).ToString();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            Weekday day = new Weekday();
            Enum.TryParse(WeekdayTextBox.Text, out day);
            if (Enum.TryParse(WeekdayTextBox.Text, out day) & (int)day < 7)   
            {
                ParseTextOutput.Text = $"Это день недели ({day.ToString()} = {(int)day + 1}).";
            }

            else
            {
                ParseTextOutput.Text = "Такого дня недели не существует :(";
            }
        }

        private void SeasonButton_Click(object sender, EventArgs e)
        {
            WinterLabel.Visible = false;
            GroupBoxSeason.BackColor = Color.White;
            SeasonComboBox.ForeColor = Color.Black;
            
            switch (SeasonComboBox.SelectedItem)
            { 
                case Season.Summer:
                    MessageBox.Show("Ура! Солнце!", "Summer");
                    break;
                case Season.Winter:
                    WinterLabel.Visible = true;
                    break;
                case Season.Spring:
                    GroupBoxSeason.BackColor = Color.Chartreuse;
                    break;
                case Season.Autumn:
                    SeasonComboBox.ForeColor = Color.Orange;
                    break;
            }
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedRectangle = RectangleListBox.SelectedIndex;
            _currentRectangleClasses = _rectanglesClasses[selectedRectangle];
            RectangleLengthTextBox.Text = _currentRectangleClasses.Height.ToString();
            RectangleWidthTextBox.Text = _currentRectangleClasses.Width.ToString();
            RectangleColorTextBox.Text = _currentRectangleClasses.Color.ToString();
            XCentreTextBox.Text = _currentRectangleClasses.Centre.X.ToString();
            YCentreTextBox.Text = _currentRectangleClasses.Centre.Y.ToString();
            RectangleIdTextBox.Text = _currentRectangleClasses.RectangleId.ToString();
        }

        private void RectangleLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            RectangleLengthTextBox.BackColor = _normalColor;
            try
            {
                _currentRectangleClasses.Height = Convert.ToInt32(RectangleLengthTextBox.Text);
                _toolTip.SetToolTip(RectangleLengthTextBox, "");
            }
            catch (Exception exception)
            {
                RectangleLengthTextBox.BackColor = _errorColor ;
                _toolTip.SetToolTip(RectangleLengthTextBox, exception.Message);
            }
        }

        private void RectangleWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            RectangleWidthTextBox.BackColor = _normalColor;
            try
            {
                _currentRectangleClasses.Width = Convert.ToInt32(RectangleWidthTextBox.Text);
                _toolTip.SetToolTip(RectangleWidthTextBox, "");
            }
            catch (Exception exception)
            {
                RectangleWidthTextBox.BackColor = _errorColor;
                _toolTip.SetToolTip(RectangleWidthTextBox, exception.Message);
            }
        }

        private void RectangleFindButton_Click(object sender, EventArgs e)
        {
            RectangleListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectanglesClasses);
        }

        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedMovie = MoviesListBox.SelectedIndex;
            _currentMovie = _movies[selectedMovie];
            MoviesTitleTextBox.Text = _currentMovie.Title.ToString();
            MoviesYearTextBox.Text = _currentMovie.Year.ToString();
            MoviesRatingTextBox.Text = _currentMovie.Rating.ToString();
        }

        private void MoviesFindButton_Click(object sender, EventArgs e)
        {
            MoviesListBox.SelectedIndex = FindMovieWithMaxRating(_movies);
        }

        private void MoviesYearTextBox_TextChanged(object sender, EventArgs e)
        {
            MoviesYearTextBox.BackColor = _normalColor;
            try
            {
                _currentMovie.Year = Convert.ToInt32(MoviesYearTextBox.Text);
                _toolTip.SetToolTip(MoviesYearTextBox, "");
            }
            catch (Exception exception)
            {
                MoviesYearTextBox.BackColor = _errorColor;
                _toolTip.SetToolTip(MoviesYearTextBox, exception.Message);
            }
        }

        private void MoviesRatingTextBox_TextChanged(object sender, EventArgs e)
        {
            MoviesRatingTextBox.BackColor = _normalColor;
            try
            {
                _currentMovie.Rating = Convert.ToDouble(MoviesRatingTextBox.Text);
                _toolTip.SetToolTip(MoviesRatingTextBox, "");
            }
            catch (Exception exception)
            {
                MoviesRatingTextBox.BackColor = _errorColor;
                _toolTip.SetToolTip(MoviesRatingTextBox, exception.Message);
            }
        }

        private void YCentreTextBox_TextChanged(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CentreTextBox_TextChanged(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void RectangleIdTextBox_TextChanged(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void RectanglesAddButton_MouseHover(object sender, EventArgs e)
        {
            RectanglesAddButton.Image = Programming.Properties.Resources.rectangle_add_24x24;
        }

        private void RectanglesAddButton_MouseLeave(object sender, EventArgs e)
        {
            RectanglesAddButton.Image = Programming.Properties.Resources.rectangle_add_24x24_uncolor;
        }

        private void RectanglesAddButton_MouseEnter(Object sender, EventArgs e)
        {
            RectanglesAddButton.Image = Programming.Properties.Resources.rectangle_add_24x24;
        }

        private void RectanglesAddButton_Click(object sender, EventArgs e)
        {
            if (_rectanglesClasses.Length > _rectangleId)
            {
                Rectangle rectangle = _rectanglesClasses[_rectangleId];
                ItemAddListBox(rectangle);
                RectanglesListBox.SelectedIndex = RectanglesListBox.Items.Count - 1;
                Panel panel = PanelCreate(rectangle);
                PanelAddListBox(panel);
                _rectangleId++;
            }
            else
            {
                Rectangle rectangle = RectanglesCreate();
                ItemAddListBox(rectangle);
                RectanglesListBox.SelectedIndex = RectanglesListBox.Items.Count - 1;
                Panel panel = PanelCreate(rectangle);
                PanelAddListBox(panel);
                _rectangleId++;
            }
            FindCollisions();
        }

        private void RectanglesDeleteButton_MouseHover(object sender, EventArgs e)
        {
            RectangleDeleteButton.Image = Programming.Properties.Resources.rectangle_remove_24x24;
        }

        private void RectanglesDeleteButton_MouseLeave(object sender, EventArgs e)
        {
            RectangleDeleteButton.Image = Programming.Properties.Resources.rectangle_remove_24x24_uncolor;
        }

        private void RectanglesDeleteButton_MouseEnter(Object sender, EventArgs e)
        {
            RectangleDeleteButton.Image = Programming.Properties.Resources.rectangle_remove_24x24;
        }

        private void RectanglesDeleteButton(object sender, EventArgs e)
        {
            if (RectanglesListBox.Items.Count != 0)
            {
                _rectanglesLists.RemoveAt(RectanglesListBox.SelectedIndex);
                CanvasPanel.Controls.Remove(_rectanglePanels[RectanglesListBox.SelectedIndex]);
                _rectanglePanels.RemoveAt(RectanglesListBox.SelectedIndex);
                RectanglesListBox.Items.RemoveAt(RectanglesListBox.SelectedIndex);
                if (RectanglesListBox.Items.Count != 0)
                {
                    RectanglesListBox.SelectedIndex = 0;
                }
            }
            FindCollisions();
        }

        private void RectanglesListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex != -1)
            {
                _currentRectangleLists = _rectanglesLists[RectanglesListBox.SelectedIndex];
                RectanglesIdTextBox.Text = _currentRectangleLists.RectangleId.ToString();
                RectanglesWidthTextBox.Text = _currentRectangleLists.Width.ToString();
                RectanglesHeightTextBox.Text = _currentRectangleLists.Height.ToString();
                RectanglesXTextBox.Text = _currentRectangleLists.Centre.X.ToString();
                RectanglesYTextBox.Text = _currentRectangleLists.Centre.Y.ToString();
            }
            else
            {
                RectanglesIdTextBox.Clear();
                RectanglesYTextBox.Clear();
                RectanglesWidthTextBox.Clear();
                RectanglesHeightTextBox.Clear();
                RectanglesXTextBox.Clear();
            }

        }

        private void RectanglesWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RectanglesWidthTextBox.Text) == false)
            {
                try
                {
                    RectanglesWidthTextBox.BackColor = _normalColor;
                    _currentRectangleLists.Width = Convert.ToInt32(RectanglesWidthTextBox.Text);
                    _toolTip.SetToolTip(RectanglesWidthTextBox, "");
                    UpdateRectanglesInfo(_currentRectangleLists);
                    ChangedRectanglesPanel(_rectanglePanels[RectanglesListBox.SelectedIndex]);                    
                }

                catch (Exception exception)
                {
                    RectanglesWidthTextBox.BackColor = _errorColor;
                    _toolTip.SetToolTip(RectanglesWidthTextBox, exception.Message);
                }
            }
        }

        private void RectanglesHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RectanglesHeightTextBox.Text) == false)
            {
                try
                {
                    RectanglesHeightTextBox.BackColor = _normalColor;
                    _currentRectangleLists.Height = Convert.ToInt32(RectanglesHeightTextBox.Text);
                    _toolTip.SetToolTip(RectanglesHeightTextBox, "");
                    UpdateRectanglesInfo(_currentRectangleLists);
                    ChangedRectanglesPanel(_rectanglePanels[RectanglesListBox.SelectedIndex]);                    
                }

                catch (Exception exception)
                {
                    RectanglesHeightTextBox.BackColor = _errorColor;
                    _toolTip.SetToolTip(RectanglesHeightTextBox, exception.Message);
                }
            }
        }

        private void RectanglesXTextBox_TextChanged(object sender, EventArgs e)
        {  
            if (string.IsNullOrEmpty(RectanglesXTextBox.Text) == false)
            {                                
                try
                {
                    RectanglesXTextBox.BackColor = _normalColor;
                    _currentRectangleLists.Centre.X = Convert.ToInt32(RectanglesXTextBox.Text);
                    _toolTip.SetToolTip(RectanglesXTextBox, "");
                    UpdateRectanglesInfo(_currentRectangleLists);
                    ChangedRectanglesPanel(_rectanglePanels[RectanglesListBox.SelectedIndex]);                 
                }

                catch (Exception exception)
                {
                    RectanglesXTextBox.BackColor = _errorColor;
                    _toolTip.SetToolTip(RectanglesXTextBox, exception.Message);
                }
            }
        }

        private void RectanglesYTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RectanglesYTextBox.Text) == false)
            {                
                try
                {
                    RectanglesYTextBox.BackColor = _normalColor;
                    _currentRectangleLists.Centre.Y = Convert.ToInt32(RectanglesYTextBox.Text);
                    _toolTip.SetToolTip(RectanglesYTextBox, "");
                    ChangedRectanglesPanel(_rectanglePanels[RectanglesListBox.SelectedIndex]);
                    UpdateRectanglesInfo(_currentRectangleLists);
                }
                catch (Exception exception)
                {                    
                    _toolTip.SetToolTip(RectanglesYTextBox, exception.Message);
                    RectanglesYTextBox.BackColor = _errorColor;
                }
            }
        }
    }
}
