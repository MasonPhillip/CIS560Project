using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DataDelegates
{
    internal class SaveMovieDataDelegate : DataDelegate
    {
        public readonly int movieId;
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

        public SaveMovieDataDelegate(int movieId, int studioId, string movieName, int releaseDate, decimal imdb, int audience, long domestic, long international, int cost, int genreId, int critic)
           : base("Movie.SaveMovie")
        {
            this.movieId = movieId;
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

            command.Parameters.AddWithValue("MovieId", movieId);
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
        }
    }
}
