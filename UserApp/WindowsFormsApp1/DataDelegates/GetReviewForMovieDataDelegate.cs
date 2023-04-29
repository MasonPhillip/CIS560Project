using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.DataDelegates
{
    internal class GetReviewForMovieDataDelegate : DataReaderDelegate<IReadOnlyList<PersonalRatings>>
    {
        private readonly int movieId;

        public GetReviewForMovieDataDelegate(int movieId)
            : base("Movie.GetReviewsForMovie")
        {
            this.movieId = movieId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("MovieId", movieId);
        }

        public override IReadOnlyList<PersonalRatings> Translate(SqlCommand command, IDataRowReader reader)
        {
            var reviews = new List<PersonalRatings>();

            while (reader.Read())
            {
                reviews.Add(new PersonalRatings(
                    reader.GetInt32("RatingId"),
                    reader.GetInt32("MovieId"),
                    reader.GetInt32("AuthorUserId"),
                    reader.GetInt32("PersonalRating"),
                    reader.GetString("RatingDescription")));
            }

            return reviews;
        }
    }
}
