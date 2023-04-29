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
    internal class FetchRoleDataDelegate : DataReaderDelegate<Roles>
    {
        private readonly int roleId;

        public FetchRoleDataDelegate(int roleId)
           : base("Movie.FetchRole")
        {
            this.roleId = roleId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("RoleId", roleId);
        }

        public override Roles Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(roleId.ToString());

            return new Roles(roleId,
               reader.GetInt32("PersonId"),
               reader.GetInt32("MovieId"),
               reader.GetValue<bool>("isDirector"),
               reader.GetValue<bool>("isActor"),
               reader.GetInt32("AmountPaid"));
        }
    }
}
