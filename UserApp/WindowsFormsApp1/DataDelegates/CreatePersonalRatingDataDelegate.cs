using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;
using DataAccess;
using System.Runtime.InteropServices;

namespace WindowsFormsApp1.DataDelegates
{
    internal class CreatePersonalRatingDataDelegate : NonQueryDataDelegate<PersonalRatings>
    {
        public readonly int movieId;
        public readonly int authorId;
        public readonly int personalRating;
        public readonly string ratingDescription;

        public CreatePersonalRatingDataDelegate(int movieId, int authorId, int personalRating, string ratingDescription)
           : base("Movie.CreatePersonalRatings")
        {
            this.movieId = movieId;
            this.authorId = authorId;
            this.personalRating = personalRating;
            this.ratingDescription = ratingDescription;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("MovieId", movieId);
            command.Parameters.AddWithValue("AuthorUserId", authorId);
            command.Parameters.AddWithValue("PersonalRating", personalRating);
            command.Parameters.AddWithValue("RatingDescription", ratingDescription);

            var p = command.Parameters.Add("RatingId", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override PersonalRatings Translate(SqlCommand command)
        {
            return new PersonalRatings((int)command.Parameters["RatingId"].Value, movieId, authorId, personalRating, ratingDescription);
        }
    }
}
