using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Movies
    {
        public int MovieId { get; }
        public int StudioId { get; }
        public string MovieName { get; }
        public Int16 ReleaseDate { get; }
        public decimal IMDBRating { get; }
        public int RottenTomatoesAudienceRating { get; }
        public long DomesticRevenue { get; }
        public long InternationalRevenue { get; }
        public int Cost { get; }
        public int GenreId { get; }
        public int RottenTomatoesCriticRating { get; }
        internal Movies(int movieId, int studioId, string movieName, Int16 releaseDate, decimal iMDBRating, int rottenTomatoesAudienceRating, long domesticRevenue, long internationalRevenue, int cost, int genreId, int rottenTomatoesCriticRating)
        {
            MovieId = movieId;
            StudioId = studioId;
            MovieName = movieName;
            ReleaseDate = releaseDate;
            IMDBRating = iMDBRating;
            RottenTomatoesAudienceRating = rottenTomatoesAudienceRating;
            DomesticRevenue = domesticRevenue;
            InternationalRevenue = internationalRevenue;
            Cost = cost;
            GenreId = genreId;
            RottenTomatoesCriticRating = rottenTomatoesCriticRating;
        }

        public override string ToString()
        {
            return MovieName;
        }
    }
}
