using WindowsFormsApp1.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;
using System;

namespace WindowsFormsApp1.DataDelegates
{
    internal class FetchMovieDataDelegate : DataReaderDelegate<Movies>
    {
        public readonly int movieId;

        public FetchMovieDataDelegate(int movieId)
           : base("Movie.FetchMovie")
        {
            this.movieId = movieId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("MovieId", movieId);
        }

        public override Movies Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(movieId.ToString());

            return new Movies(movieId,
               reader.GetInt32("StudioId"),
               reader.GetString("MovieName"),
               reader.GetValue<Int16>("ReleaseDate"),
               reader.GetValue<decimal>("IMDBRating"),
               reader.GetInt32("RottenTomatoesAudienceRating"),
               reader.GetValue<long>("DomesticRevenue"),
               reader.GetValue<long>("InternationalRevenue"),
               reader.GetInt32("Cost"),
               reader.GetInt32("GenreId"),
               reader.GetInt32("RottenTomatoesCriticRating"));
        }
    }
}
