using WindowsFormsApp1.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;
using System;


namespace WindowsFormsApp1.DataDelegates
{
    internal class CreateGenreDataDelegate : NonQueryDataDelegate<Genres>
    {
        public readonly Genre genre;

        public CreateGenreDataDelegate(Genre genre)
           : base("Movie.CreateGenre")
        {
            this.genre = genre;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Genre", genre);

            var p = command.Parameters.Add("GenreId", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }
        
        public override Genres Translate(SqlCommand command)
        {
            return new Genres((int)command.Parameters["GenreId"].Value, genre);
        }
        
    }
}
