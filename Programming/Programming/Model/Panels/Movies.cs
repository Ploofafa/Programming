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
using Rectangle = Programming.Model.Classes.Rectangle;


namespace Programming.Model.Panels
{
    public partial class Movies : UserControl
    {
        private readonly Color _normalColor = Color.White;

        private readonly Color _errorColor = Color.LightPink;

        private ToolTip _toolTip = new ToolTip();

        private Movie[] _movies;

        private Movie _currentMovie;

        private Double DoubleRandom(int randomBottomBorder,
                                    int randomTopBorder,
                                    int precision,
                                    Random random)
        {
            var number = random.Next(randomBottomBorder, randomTopBorder) +
                                Math.Round(random.NextDouble(), precision);
            return number;
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

        public Movies()
        {
            InitializeComponent();

            InitMovies();
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
    }
}
