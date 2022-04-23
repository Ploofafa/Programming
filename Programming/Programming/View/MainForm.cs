using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model.Enums;
using Programming.Model.Classes;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        private readonly Color _normalColor = Color.White;

        private readonly Color _errorColor = Color.LightPink;

        private Model.Classes.Rectangle[] _rectangles;

        private Model.Classes.Rectangle _currentRectangle;

        private ToolTip _toolTip = new ToolTip();

        private Movie[] _movies;
        
        private Movie _currentMovie;

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
            int rectanglesCount = 5;
            _rectangles = new Model.Classes.Rectangle[rectanglesCount];
            Random random = new Random();
            string[] rectangleColor = new string[] { "Black", "Yellow", "Green", "Blue", "Red", "White" };

            for (int i = 0; i < _rectangles.Length; i++)
            {
                _rectangles[i] = new Model.Classes.Rectangle();
                _rectangles[i].Width = DoubleRandom(1, 100, 1, random);
                _rectangles[i].Length = DoubleRandom(1, 100, 1, random);
                _rectangles[i].Color = rectangleColor[random.Next(0, rectangleColor.Length)];
                _rectangles[i].Centre = new Point2D(random.Next(1, 1000), random.Next(1, 1000));
            }
            RectanglesListBox.SelectedIndex = 0;
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

        public MainForm()
        {
            InitializeComponent();
            EnumListBox.DataSource = Enum.GetValues(typeof(Enums));
            SeasonComboBox.DataSource = Enum.GetValues(typeof(Season));
            EnumListBox.SelectedIndex = 0;

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
            var selectedRectangle = RectanglesListBox.SelectedIndex;
            _currentRectangle = _rectangles[selectedRectangle];
            RectangleLengthTextBox.Text = _currentRectangle.Length.ToString();
            RectangleWidthTextBox.Text = _currentRectangle.Width.ToString();
            RectangleColorTextBox.Text = _currentRectangle.Color.ToString();
            XCentreTextBox.Text = _currentRectangle.Centre.X.ToString();
            YCentreTextBox.Text = _currentRectangle.Centre.Y.ToString();
            RectangleIdTextBox.Text = _currentRectangle.RectangleId.ToString();
        }

        private void RectangleLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            RectangleLengthTextBox.BackColor = _normalColor;
            try
            {
                _currentRectangle.Length = Convert.ToDouble(RectangleLengthTextBox.Text);
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
                _currentRectangle.Width = Convert.ToDouble(RectangleWidthTextBox.Text);
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
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
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
    }
}
