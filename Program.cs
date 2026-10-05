using System.Reflection;

namespace movietheaterapp_hickman;

public enum MovieRating { G, Pg, Pg13, R, Nc17 } // enum index starts at 0, in this case G=0, NC17=4, ratings are ordered from least to most restrictive

public struct Movie
{
    public string Title;// The name of the movie
    public double Price; //Cost of one ticket in $
    public MovieRating Rating; //MPAA rating
    public int Screen; //Screen number which the movie is showing on
    public string Time1; // first showtime
    public string Time2; //second showtime
    public string Time3;// third showtime
}

public struct Purchase
{
    public int MovieIndex;
    public int showingIndex;
    public int ticketquantity;
}

class Program

{
    static void Main(string[] args)
    {
        Movie[] movies =
        {
            new Movie
            {
                Title = "Obsession", Rating = MovieRating.R, Price = 11.99, Screen = 3, Time1 = "14.00",
                Time2 = "17:00",
                Time3 = "20:00"
            },
            new Movie
            {
                Title = "Fight Club", Rating = MovieRating.R, Price = 8.99, Screen = 5, Time1 = "10:00",
                Time2 = "13:00", Time3 = "19:00",

            },

            new Movie
            {
                Title = "Toy Story", Rating = MovieRating.G, Price = 7.99, Screen = 7, Time1 = "12:00", Time2 = "14:30",
                Time3 = "17:00"
            },

            new Movie
            {
                Title = "Disclosure Day", Rating = MovieRating.Pg13, Price = 9.99, Screen = 8, Time1 = "13:00",
                Time2 = "16:00", Time3 = "19:30"
            },

            new Movie
            {
                Title = "Requiem for a Dream", Rating = MovieRating.R, Price = 8.99, Screen = 1, Time1 = "12:00",
                Time2 = "15:30", Time3 = "20:00"
            }


        };
        List<Purchase> purchases = new List<Purchase>();
        bool purchaseAgain; //boolean determining whether to return to movie menu or finish transaction

        int maxCapacity = 100;
        string theaterName = "Hickman Theatres";
        
        Console.WriteLine($"Welcome to {theaterName}");
        Console.WriteLine("Please choose a movie from the numbered list below");
        try
        {
            // Begin the purchase loop; each pass records one selection.
            do
            {
                Console.WriteLine("\nAvailable movies:");
                // Begin the catalog loop; i is a zero-based movie index.
                for (int i = 0; i < movies.Length; i++)
                    Console.WriteLine($"{i + 1}. {movies[i].Title} ({FormatRating(movies[i].Rating)}) — {movies[i].Price:C} per ticket");
                // End the catalog loop.

                int movieIndex; // Validated movie index with at least one available showing.
                // Begin the movie-availability loop; allow another movie if all its times are full.
                while (true)
                {
                    movieIndex = ReadInteger("Please enter your movie number: ", 1, movies.Length) - 1;
                    if (RemainingSeats(purchases, movieIndex, 0) > 0 ||
                        RemainingSeats(purchases, movieIndex, 1) > 0 ||
                        RemainingSeats(purchases, movieIndex, 2) > 0)
                        break;
                    Console.WriteLine("All showings of {movie.Title} are sold out. Please select another movie.");
                }




    }
}

