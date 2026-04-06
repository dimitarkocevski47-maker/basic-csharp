using Class09.Exercises.Enums;
using Class09.Exercises.Models;

Cinema cinema = new Cinema("Cineplex", 5);

cinema.ListOfMovies.Add(new Movie("Movie1", Genres.Action, 5));
cinema.ListOfMovies.Add(new Movie("Movie2", Genres.Comedy, 4));
cinema.ListOfMovies.Add(new Movie("Movie3", Genres.Horror, 3));
cinema.ListOfMovies.Add(new Movie("Movie4", Genres.Drama, 2));
cinema.ListOfMovies.Add(new Movie("Movie5", Genres.SciFi, 5));
cinema.ListOfMovies.Add(new Movie("Movie6", Genres.Action, 4));
cinema.ListOfMovies.Add(new Movie("Movie7", Genres.Comedy, 3));
cinema.ListOfMovies.Add(new Movie("Movie8", Genres.Horror, 2));
cinema.ListOfMovies.Add(new Movie("Movie9", Genres.Drama, 1));
cinema.ListOfMovies.Add(new Movie("Movie10", Genres.SciFi, 5));

cinema.MoviePlaying(cinema.ListOfMovies[0]);