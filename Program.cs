using System.Reflection;

namespace movietheaterapp_hickman;

public enum MovieRating { G, PG, PG13, R, NC17} // enum index starts at 0, in this case G=0, NC17=4, ratings are ordered from least to most restrictive

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
                Title= "Fight Club", Rating= MovieRating.R, Price= 8.99, Screen=5, Time1 = "10:00", Time2="13:00", Time3 = "19:00", 
                
            },
            
            new Movie
            {
                Title= "Toy Story", Rating=MovieRating.G, Price=7.99, Screen=7, Time1 = "12:00", Time2="14:30", Time3 = "17:00"
            },
            
            new Movie
            {
                Title = "Disclosure Day", Rating = MovieRating.PG13, Price=9.99, Screen=8, Time1 = "13:00", Time2="16:00", Time3 = "19:30"
            },
            
            new Movie
            {
                Title = "Requiem for a Dream", Rating = MovieRating.R, Price=8.99, Screen=1, Time1 = "12:00", Time2 = "15:30", Time3="20:00"
            }
            
            



    }


}
}

