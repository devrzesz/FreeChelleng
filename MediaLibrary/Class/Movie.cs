using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeChalleng.MediaLibrary.Class
{
    class Movie : Media
    {
        public string Title { get; }
        public string Director { get; }


        public Movie(string title, string director)
        {
            Title = title;
            Director = director;
        }

        public override string ToString()
        {
            return $"The movie: {Title} has wrote by {Director}";
        }
    }
}
