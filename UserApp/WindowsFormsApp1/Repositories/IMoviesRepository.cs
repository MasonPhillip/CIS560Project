using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Repositories
{
    public interface IMoviesRepository
    {
        Movies FetchMovie(int movieId);

        Movies CreateMovie(int studioId, string movieName, Int16 releaseDate, decimal imdb, int audience, long domestic, long international, int cost, int genreId, int critic);

        void SaveMovie(int movieId, int studioId, string movieName, Int16 releaseDate, decimal imdb, int audience, long domestic, long international, int cost, int genreId, int critic);

        IReadOnlyList<Movies> RetrieveMovies();

        IReadOnlyList<Movies> GetMoviesByName(string movieName);
    }
}
