using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DataDelegates
{
    internal class SavePersonalRatingDataDelegate : DataDelegate
    {
        public readonly int ratingId;
        public readonly int movieId;
        public readonly int authorUserId;
        public readonly int personalRating;
        public readonly string ratingDescription;

        public SavePersonalRatingDataDelegate(int ratingId, int movieId, int authorUserId, int personalRating, string ratingDescription)
           : base("Movie.SavePersonalRating")
        {
            this.ratingId = ratingId;
            this.movieId = movieId;
            this.authorUserId = authorUserId;
            this.personalRating = personalRating;
            this.ratingDescription = ratingDescription;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("RatingId", ratingId);
            command.Parameters.AddWithValue("MovieId", movieId);
            command.Parameters.AddWithValue("AuthorUserId", authorUserId);
            command.Parameters.AddWithValue("PersonalRating", personalRating);
            command.Parameters.AddWithValue("RatingDescription", ratingDescription);
        }
    }
}
