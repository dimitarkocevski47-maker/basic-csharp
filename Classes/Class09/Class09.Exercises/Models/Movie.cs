using Class09.Exercises.Enums;

namespace Class09.Exercises.Models;

public class Movie
{
    public string Title { get; set; }
    public Genres Genre { get; set; }
    public int Rating { get; set; }


    public double TicketPrice { get; set; }


    public Movie(string title, Genres genre, int raiting)
    {
        try
        {
            Title = title ?? throw new ArgumentNullException(nameof(title));
            Genre = genre;
            if (raiting< 1 || raiting > 5)
                throw new ArgumentOutOfRangeException("Rating must be between 1 and 5.");

            Rating = raiting;
            TicketPrice = 5 * Rating;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error creating movie: {ex.Message}");
            throw;
        }

    }

}
