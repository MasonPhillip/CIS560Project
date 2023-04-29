using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DataDelegates;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Repositories
{
    internal class SqlGenresRepository : IGenresRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlGenresRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Genres CreateGenre(string genre)
        {
            var d = new CreateGenreDataDelegate(genre);
            return executor.ExecuteNonQuery(d);
        }

        public Genres FetchGenre(int genreId)
        {
            var d = new FetchGenreDataDelegate(genreId);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Genres> RetrieveGenres()
        {
            return executor.ExecuteReader(new RetrieveGenreDataDelegate());
        }
    }
}
