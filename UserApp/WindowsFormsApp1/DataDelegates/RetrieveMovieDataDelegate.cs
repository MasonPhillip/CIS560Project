using WindowsFormsApp1.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace WindowsFormsApp1.DataDelegates
{
    internal class RetrieveMovieDataDelegate : DataReaderDelegate<IReadOnlyList<Movies>>
    {
        public RetrieveMovieDataDelegate()
            : base("Movie.RetrieveMovie")
        {
        }

        public override IReadOnlyList<Movies> Translate(SqlCommand command, IDataRowReader reader)
        {
            var movies = new List<Movies>();

            while (reader.Read())
            {
                movies.Add(new Movies(
                    reader.GetInt32("MovieId"),
                    reader.GetInt32("StudioId"),
                    reader.GetString("MovieName"),
                    reader.GetValue<Int16>("ReleaseDate"),
                    reader.GetValue<decimal>("IMDBRating"),
                    reader.GetInt32("RottenTomatoesAudienceRating"),
                    reader.GetValue<long>("DomesticRevenue"),
                    reader.GetValue<long>("InternationalRevenue"),
                    reader.GetInt32("Cost"),
                    reader.GetInt32("GenreId"),
                    reader.GetInt32("RottenTomatoesCriticRating")));
            }

            return movies;
        }
    }
}
