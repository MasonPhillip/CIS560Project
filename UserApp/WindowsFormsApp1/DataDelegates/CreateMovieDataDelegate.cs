using WindowsFormsApp1.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;
using System;

namespace WindowsFormsApp1.DataDelegates
{
    internal class CreateMovieDataDelegate : NonQueryDataDelegate<Movies>
    {
        public readonly int studioId;
        public readonly string movieName;
        public readonly int releaseDate;
        public readonly decimal imdb;
        public readonly int audience;
        public readonly long domestic;
        public readonly long international;
        public readonly int cost;
        public readonly int genreId;
        public readonly int critic;

        public CreateMovieDataDelegate(int studioId, string movieName, int releaseDate, decimal imdb, int audience, long domestic, long international, int cost, int genreId, int critic)
           : base("Movie.CreateMovie")
        {
            this.studioId = studioId;
            this.movieName = movieName;
            this.releaseDate = releaseDate;
            this.imdb = imdb;
            this.audience = audience;
            this.domestic = domestic;
            this.international = international;
            this.cost = cost;
            this.genreId = genreId;
            this.critic = critic;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("StudioId", studioId);
            command.Parameters.AddWithValue("MovieName", movieName);
            command.Parameters.AddWithValue("ReleaseDate", releaseDate);
            command.Parameters.AddWithValue("IMDBRating", imdb);
            command.Parameters.AddWithValue("RottenTomatoesAudienceRating", audience);
            command.Parameters.AddWithValue("DomesticRevenue", domestic);
            command.Parameters.AddWithValue("InternationlRevenue", international);
            command.Parameters.AddWithValue("Cost", cost);
            command.Parameters.AddWithValue("GenreId", genreId);
            command.Parameters.AddWithValue("RottenTomatoesCriticRating", critic);
            
            var p = command.Parameters.Add("MovieId", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override Movies Translate(SqlCommand command)
        {
            return new Movies((int)command.Parameters["MovieId"].Value, studioId, movieName, releaseDate, imdb, audience, domestic, international, cost, genreId, critic);
        }
    }
}

