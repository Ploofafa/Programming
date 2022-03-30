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
        private Rectangles[] _rectangles;
        private Rectangles _currentRectangle;
        private Color _normalColor = Color.White;
        private Color _errorlColor = Color.LightPink;
        private ToolTip _toolTip = new ToolTip();
        
        private Movies[] _movies;
        private Movies _currentMovie;

        public MainForm()
        {
            InitializeComponent();
            EnumListBox.DataSource = Enum.GetValues(typeof(Enums));
            SeasonComboBox.DataSource = Enum.GetValues(typeof(Season));
            EnumListBox.SelectedIndex = 0;
            
            int RectanglesAmount = 5;
            _rectangles = new Rectangles[RectanglesAmount];
            Random rnd = new Random();
            String[] RectangleColor = new string[] {"Black", "Yellow", "Green", "Blue", "Red", "White"};
                
            for (int i = 0; i < _rectangles.Length; i++)
            {
                _rectangles[i] = new Rectangles();
                _rectangles[i].Width = rnd.Next (1, 100);
                _rectangles[i].Length = rnd.Next(1, 100);
                _rectangles[i].Color = RectangleColor[rnd.Next(0, RectangleColor.Length)];

            }
            RectanglesListBox.SelectedIndex = 0;

            int MoviesAmount = 10;
            _movies = new Movies[MoviesAmount];
            string[] MoviesTitle = new string[] { "The Power of the Dog", "Undine", "King Richard", "Mass",
            "Identifying Features", "Nightmare Alley", "Drive My Car", "Licorice Pizza", "The French Dispatch",
            "Petite Maman", "C’mon C’mon", "The Green Knight", "Dune", "Summer of Soul", "The Lost Daughter"};

            for (int i = 0; i < _movies.Length; i++)
            {
                _movies[i] = new Movies();
                _movies[i].Year = rnd.Next(1900, 2022);
                _movies[i].Rating = Math.Round(rnd.NextDouble() * 10, 1);
                _movies[i].Title = MoviesTitle[rnd.Next(0, MoviesTitle.Length)];
            }
            MoviesListBox.SelectedIndex = 0;
        }
        
        private void EnumListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IndexBox.Clear();
            switch (EnumListBox.SelectedItem)
            {
                case Programming.View.Enums.Colors:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Weekday));
                    break;
                case Programming.View.Enums.Genre:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Genre));
                    break;
                case Programming.View.Enums.Weekday:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Colors));
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
            var CuredIndex = ValuesListBox.SelectedItem;
            IndexBox.Text = ((int)CuredIndex).ToString();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            Weekday day;
            if (Enum.TryParse(WeekdayTextBox.Text, out day))
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
            
        }

        private void RectangleLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            RectangleLengthTextBox.BackColor = _normalColor;
            try
            {
                _currentRectangle.Length = Convert.ToDouble(RectangleLengthTextBox.Text);
                _toolTip.SetToolTip(RectangleLengthTextBox, "");

            }
            catch
            {
                RectangleLengthTextBox.BackColor = _errorlColor ;
                _toolTip.SetToolTip(RectangleLengthTextBox, "ERROR");
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
            catch
            {
                RectangleWidthTextBox.BackColor = _errorlColor;
                _toolTip.SetToolTip(RectangleWidthTextBox, "ERROR");
            }
        }

        private int FindRectangleWithMaxWidth(Rectangles[] rectangles)
        {
            Double max = -1;
            int currentIndex = 0;
            for (int i = 0; i < rectangles.Length; i++)
            {
                if(rectangles[i].Width > max)
                {
                    max = rectangles[i].Width;
                    currentIndex = i;
                }
            }
            return currentIndex;
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

        private int FindMovieWithMaxRating(Movies[] movies)
        {
            Double max = -1;
            int currentIndex = 0;
            for (int i = 0; i < movies.Length; i++)
            {
                if (movies[i].Rating > max)
                {
                    max = movies[i].Rating;
                    currentIndex = i;
                }
            }
            return currentIndex;
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
            catch
            {
                MoviesYearTextBox.BackColor = _errorlColor;
                _toolTip.SetToolTip(MoviesYearTextBox, "ERROR");
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
            catch
            {
                MoviesRatingTextBox.BackColor = _errorlColor;
                _toolTip.SetToolTip(MoviesRatingTextBox, "ERROR");
            }
        }
    }
}
