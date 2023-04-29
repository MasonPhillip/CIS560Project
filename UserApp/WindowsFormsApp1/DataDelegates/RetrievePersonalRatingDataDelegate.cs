using WindowsFormsApp1.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace WindowsFormsApp1.DataDelegates
{
    internal class RetrievePersonalRatingDataDelegate : DataReaderDelegate<IReadOnlyList<PersonalRatings>>
    {
        public RetrievePersonalRatingDataDelegate()
            : base("Movie.RetrievePersonalRating")
        {
        }

        public override IReadOnlyList<PersonalRatings> Translate(SqlCommand command, IDataRowReader reader)
        {
            var ratings = new List<PersonalRatings>();

            while (reader.Read())
            {
                ratings.Add(new PersonalRatings(
                    reader.GetInt32("RatingId"),
                    reader.GetInt32("MovieId"),
                    reader.GetInt32("AuthorUserId"),
                    reader.GetInt32("PersonalRating"),
                    reader.GetString("RatingDescription")));
            }

            return ratings;
        }
    }
}
