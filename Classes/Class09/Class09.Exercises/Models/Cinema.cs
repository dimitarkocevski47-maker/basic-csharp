namespace Class09.Exercises.Models;

public class Cinema
{
    public string Name { get; set; }
    public int Halls { get; set; }
    public List<Movie> ListOfMovies { get; set; }

    public Cinema(string name, int halls)
    {
        Name = name;
        Halls = halls;
        ListOfMovies = new List<Movie>();
    }
    public void MoviePlaying(Movie movie)
    {
        Console.WriteLine($"Watching {movie.Title}");
    }
}
