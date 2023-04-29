using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Repositories
{
    public interface IPersonalRatingsRepository
    {
        PersonalRatings FetchPersonalRating(int ratingId);

        PersonalRatings CreatePersonalRating(int movieId, int authorUserId, int personalRating, string ratingDescription);

        void SavePersonalRating(int ratingId, int movieId, int authorUserId, int personalRating, string ratingDescription);

        IReadOnlyList<PersonalRatings> RetrievePersonalRatings();

        IReadOnlyList<PersonalRatings> GetReviewsForMovie(int movieId);
    }
}
