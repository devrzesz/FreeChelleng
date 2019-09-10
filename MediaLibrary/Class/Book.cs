using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeChalleng
{
    public class Book : Media
    {
        public string Title { get; }
        public string Author { get; }

        
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public override string ToString()
        {
            return $"The book: {Title} has wrote by {Author}";
        }



    }
}
