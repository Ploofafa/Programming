using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Movie
    {
        private string Name;
        private int Duration;
        private int Year;
        private string Genre;
        private double Rating;
        
        Movie MakeMovie(string title,
                        string genre,
                        int year,
                        int Duration,
                        double Rating)
        {
            Movie movie = new Movie();
            
            return movie;
        }
    }
}
