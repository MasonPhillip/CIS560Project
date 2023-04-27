using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Repositories
{
    public interface IRolesRepository
    {
        Roles FetchRole(int roleId);

        Roles CreateRole(int personId, int movieId, bool isDirector, bool isActor, int amountPaid);

        void SaveRole(int roleId, int personId, int movieId, bool isDirector, bool isActor, int amountPaid);
    }
}
