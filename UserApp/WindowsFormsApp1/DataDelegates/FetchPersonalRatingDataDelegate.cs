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
    internal class FetchPersonalRatingDataDelegate : DataReaderDelegate<PersonalRatings>
    {
        private readonly int ratingId;

        public FetchPersonalRatingDataDelegate(int ratingId)
           : base("Movie.FetchPersonalRating")
        {
            this.ratingId = ratingId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("RatingId", ratingId);
        }

        public override PersonalRatings Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(ratingId.ToString());

            return new PersonalRatings(ratingId,
               reader.GetInt32("MovieId"),
               reader.GetInt32("AuthorUserId"),
               reader.GetInt32("PersonalRating"),
               reader.GetString("RatingDescription"));
        }
    }
}
