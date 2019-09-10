using System;

namespace FreeChalleng
{
    public class MediaLibrary
    {
        public static void Program()
        {
            Book book1, book2, book3;
            Movie movie1, movie2, movie3;
            Album album1, album2, album3;

            InitializeObjects(out book1, out book2, out book3, out movie1, out movie2, out movie3, out album1, out album2, out album3);

            Book[] books = { book1, book2, book3 };
            Album[] albums = { album1, album2, album3 };
            Movie[] movies = { movie1, movie2, movie3 };


            DisplayText(books);
            DisplayText(albums);
            DisplayText(movies);

            book1.Loan();
            book2.Loan("Ariel");

            movie1.Loan();
            movie2.Loan("Agata");

            album1.Loan();
            album2.Loan("Antropolog");

            DisplayText(books);
            DisplayText(albums);
            DisplayText(movies);

        }

        private static void InitializeObjects(out Book book1, out Book book2, out Book book3, out Movie movie1, out Movie movie2, out Movie movie3, out Album album1, out Album album2, out Album album3)
        {
            book1 = new Book("Władca Piersieni", "Tolkien");
            book2 = new Book("Harry Potter", "Knowling");
            book3 = new Book("Harry Potter 2", "Knowling 2");
            movie1 = new Movie("Władca Piersieni", "Tolkien");
            movie2 = new Movie("Harry Potter", "Knowling");
            movie3 = new Movie("Harry Potter 2", "Knowling 2");
            album1 = new Album("Władca Piersieni", "Tolkien");
            album2 = new Album("Harry Potter", "Knowling");
            album3 = new Album("Harry Potter 2", "Knowling 2");
        }


        private static void DisplayText(object[] objs)
        {
            if (objs is Book[])
            {
                Console.WriteLine("\nDisplay Books:");

                foreach (Book book in objs)
                {
                    Console.WriteLine(book.GetDisplayText());
                }

                return;
            }

            if (objs is Album[])
            {
                Console.WriteLine("\nDisplay Albums:");

                foreach (Album album in objs)
                {
                    Console.WriteLine(album.GetDisplayText());
                }

                return;
            }

            if (objs is Movie[])
            {
                Console.WriteLine("\nDisplay Movies:");

                foreach (Movie movie in objs)
                {
                    Console.WriteLine(movie.GetDisplayText());
                }

                return;
            }

        }

    }
}
   

