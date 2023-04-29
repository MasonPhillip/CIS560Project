using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DataDelegates;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Repositories
{
    internal class SqlPersonalRatingsRepository : IPersonalRatingsRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlPersonalRatingsRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public PersonalRatings CreatePersonalRating(int movieId, int authorUserId, int personalRating, string ratingDescription)
        {
            if (string.IsNullOrWhiteSpace(ratingDescription))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(ratingDescription));

            var d = new CreatePersonalRatingDataDelegate(movieId, authorUserId, personalRating, ratingDescription);
            return executor.ExecuteNonQuery(d);
        }

        public PersonalRatings FetchPersonalRating(int ratingId)
        {
            var d = new FetchPersonalRatingDataDelegate(ratingId);
            return executor.ExecuteReader(d);
        }

        public void SavePersonalRating(int ratingId, int movieId, int authorUserId, int personalRating, string ratingDescription)
        {
            executor.ExecuteNonQuery(new SavePersonalRatingDataDelegate(ratingId, movieId, authorUserId, personalRating, ratingDescription));
        }

        public IReadOnlyList<PersonalRatings> RetrievePersonalRatings()
        {
            return executor.ExecuteReader(new RetrievePersonalRatingDataDelegate());
        }

        public IReadOnlyList<PersonalRatings> GetReviewsForMovie(int movieId)
        {
            return executor.ExecuteReader(new GetReviewForMovieDataDelegate(movieId));
        }
    }
}
