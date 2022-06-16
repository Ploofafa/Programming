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

    /// <summary>
    ///Содержит логику пользовательского элемента <see cref="MoviesControl"/>.
    /// </summary>
    public partial class MoviesControl : UserControl
    {

        /// <summary>
        /// Хранит переменную для подсказок пользователю в элементах.
        /// </summary>
        private ToolTip _toolTip = new ToolTip();

        /// <summary>
        /// Хранит массив со всеми фильмами.
        /// </summary>
        private Movie[] _movies;

        /// <summary>
        /// Хранит текущий выбранный фильм.
        /// </summary>
        private Movie _currentMovie;

        /// <summary>
        /// Генерирует рандомное вещественное число.
        /// </summary>
        /// <param name="randomBottomBorder">Нижняя граница рандомного числа.</param>
        /// <param name="randomTopBorder">Верхняя граница рандомного числа.</param>
        /// <param name="precision">Количество знаков после запятой.</param>
        /// <param name="random">Переменная для случайного генерирования.</param>
        /// <returns>Возвращает полученное рандомное число.</returns>
        private Double DoubleRandom(int randomBottomBorder,
                                    int randomTopBorder,
                                    int precision,
                                    Random random)
        {
            var number = random.Next(randomBottomBorder, randomTopBorder) +
                                Math.Round(random.NextDouble(), precision);
            return number;
        }

        /// <summary>
        /// Генерирует нужное количества фильмов.
        /// </summary>
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

        /// <summary>
        /// Ищет фильм с максимальным рейтингом.
        /// </summary>
        /// <param name="movies">Массив фильмов, в котором происходит поиск.</param>
        /// <returns>Возвращает первый фильм с максимальным рейтингом.</returns>
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

        public MoviesControl()
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
            MoviesYearTextBox.BackColor = AppColors.NormalColor;
            try
            {
                _currentMovie.Year = Convert.ToInt32(MoviesYearTextBox.Text);
                _toolTip.SetToolTip(MoviesYearTextBox, "");
            }
            catch (Exception exception)
            {
                MoviesYearTextBox.BackColor = AppColors.ErrorColor;
                _toolTip.SetToolTip(MoviesYearTextBox, exception.Message);
            }
        }

        private void MoviesRatingTextBox_TextChanged(object sender, EventArgs e)
        {
            MoviesRatingTextBox.BackColor = AppColors.NormalColor;
            try
            {
                _currentMovie.Rating = Convert.ToDouble(MoviesRatingTextBox.Text);
                _toolTip.SetToolTip(MoviesRatingTextBox, "");
            }
            catch (Exception exception)
            {
                MoviesRatingTextBox.BackColor = AppColors.ErrorColor;
                _toolTip.SetToolTip(MoviesRatingTextBox, exception.Message);
            }
        }
    }
}
