using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class PersonalRatings
    {
        public int RatingId { get; }
        public int MovieId { get; }
        public int AuthorUserId { get; }
        public int PersonalRating { get; }
        public string RatingDescription { get; }

        internal PersonalRatings(int  ratingId, int movieId, int authorUserId, int personalRating, string ratingDescription)
        {
            RatingId = ratingId;
            MovieId = movieId;
            AuthorUserId = authorUserId;
            PersonalRating = personalRating;
            RatingDescription = ratingDescription;
        }

        public override string ToString()
        {
            return RatingDescription;
        }
    }
}
