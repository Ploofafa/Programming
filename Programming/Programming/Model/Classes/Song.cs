using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Song
    {
        private int _id;
        private int _duration;
        private string _album;
        private string _name;

        public Song()
        {
        }
        public Song MakeSong(int id,
                            int duration,
                            string album,
                            string name)
        {
            Song song = new Song();
            _duration = duration;
            _id = id;
            _album = album;
            _name = name;
            return song;
        }
        public int Id
        {
            get { return _id; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Id can be only > 0");
                }
                _id = value;
            }
        }
        public int Duration
        {
            get { return _duration; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Duration can't be < 0");
                }
                _duration = value;
            }
        }
        public string Album { get; set; }
        public string Name { get; set; }
    }
}
