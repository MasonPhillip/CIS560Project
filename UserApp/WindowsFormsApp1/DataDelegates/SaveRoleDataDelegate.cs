using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DataDelegates
{
    internal class SaveRoleDataDelegate : DataDelegate
    {
        public readonly int roleId;
        public readonly int personId;
        public readonly int movieId;
        public readonly bool isDirector;
        public readonly bool isActor;
        public readonly int amountPaid;

        public SaveRoleDataDelegate(int roleId, int personId, int movieId, bool isDirector, bool isActor, int amountPaid)
           : base("Movie.SaveRole")
        {
            this.roleId = roleId;
            this.personId = personId;
            this.movieId = movieId;
            this.isDirector = isDirector;
            this.isActor = isActor;
            this.amountPaid = amountPaid;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("RoleId", roleId);
            command.Parameters.AddWithValue("PersonId", personId);
            command.Parameters.AddWithValue("MovieId", movieId);
            command.Parameters.AddWithValue("IsDirector", isDirector);
            command.Parameters.AddWithValue("IsActor", isActor);
            command.Parameters.AddWithValue("AmountPaid", amountPaid);
        }
    }
}
