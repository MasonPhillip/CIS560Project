using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using WindowsFormsApp1.DataDelegates;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Repositories
{
    internal class SqlMoviesRepository : IMoviesRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlMoviesRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Movies CreateMovie(int studioId, string movieName, DateTimeOffset releaseDate, decimal imdb, int audience, long domestic, long international, int cost, int genreId, int critic)
        {
            if (string.IsNullOrWhiteSpace(movieName))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(movieName));

            var d = new CreateMovieDataDelegate(studioId, movieName, releaseDate, imdb, audience, domestic, international, cost, genreId, critic);
            return executor.ExecuteNonQuery(d);
        }

        public Movies FetchMovie(int movieId)
        {
            var d = new FetchMovieDataDelegate(movieId);
            return executor.ExecuteReader(d);
        }
    }
}
