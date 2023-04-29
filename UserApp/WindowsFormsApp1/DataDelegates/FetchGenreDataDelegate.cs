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
    internal class FetchGenreDataDelegate : DataReaderDelegate<Genres>
    {
        private readonly int genreId;

        public FetchGenreDataDelegate(int genreId)
           : base("Movie.FetchGenre")
        {
            this.genreId = genreId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("GenreId", genreId);
        }

        public override Genres Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(genreId.ToString());

            return new Genres(genreId,
               reader.GetString("Genre"));
        }
    }
}
