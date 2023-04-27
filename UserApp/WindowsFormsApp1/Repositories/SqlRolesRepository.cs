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
    internal class SqlRolesRepository : IRolesRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlRolesRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Roles CreateRole(int personId, int movieId, bool isDirector, bool isActor, int amountPaid)
        {
            var d = new CreateRoleDataDelegate(personId, movieId, isDirector, isActor, amountPaid);
            return executor.ExecuteNonQuery(d);
        }

        public Roles FetchRole(int roleId)
        {
            var d = new FetchRoleDataDelegate(roleId);
            return executor.ExecuteReader(d);
        }

        public void SaveRole(int roleId, int personId, int movieId, bool isDirector, bool isActor, int amountPaid)
        {
            executor.ExecuteNonQuery(new SaveRoleDataDelegate(roleId, personId, movieId, isDirector, isActor, amountPaid));
        }
    }
}
