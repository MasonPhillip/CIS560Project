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
    internal class GetMoviesByNameDataDelegate : DataReaderDelegate<IReadOnlyList<Movies>>
    {
        private readonly string movieName;

        public GetMoviesByNameDataDelegate(string movieName)
            : base("Movie.GetMoviesByName")
        {
            this.movieName = movieName;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("MovieName", movieName);
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
