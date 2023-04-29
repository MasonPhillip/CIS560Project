using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Repositories
{
    public interface IGenresRepository
    {
        Genres FetchGenre(int genreId);

        Genres CreateGenre(string genre);

        IReadOnlyList<Genres> RetrieveGenres();
    }
}
