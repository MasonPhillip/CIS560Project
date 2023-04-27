using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public enum Genre
    {
        Action = 1,
        Adventure = 2,
        Animated = 3,
        Comedy = 4,
        Drama = 5,
        Fantasy = 6,
        Historical = 7,
        Horror = 8,
        Musical = 9,
        Mystery = 10,
        Romance = 11,
        SciFi = 12,
        Sports = 13,
        Thriller = 14,
        War = 15,
        Western = 16
    }

    public class Genres
    {
        public int GenreId { get; }
        public Genre Genre { get; }

        internal Genres(int genreId, Genre genre)
        {
            GenreId = genreId;
            Genre = genre;
        }
    }
}
