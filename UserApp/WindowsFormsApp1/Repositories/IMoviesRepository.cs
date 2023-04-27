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

        Movies CreateMovie(int studioId, string movieName, DateTimeOffset releaseDate, decimal imdb, int audience, long domestic, long international, int cost, int genreId, int critic);
    }
}
