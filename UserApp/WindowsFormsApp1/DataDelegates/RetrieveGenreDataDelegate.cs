using WindowsFormsApp1.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace WindowsFormsApp1.DataDelegates
{
    internal class RetrieveGenreDataDelegate : DataReaderDelegate<IReadOnlyList<Genres>>
    {
        public RetrieveGenreDataDelegate()
            : base("Movie.RetrieveGenre")
        {
        }

        public override IReadOnlyList<Genres> Translate(SqlCommand command, IDataRowReader reader)
        {
            var genres = new List<Genres>();

            while (reader.Read())
            {
                genres.Add(new Genres(
                    reader.GetInt32("GenreId"),
                    reader.GetString("Genre")));
            }

            return genres;
        }
    }
}
