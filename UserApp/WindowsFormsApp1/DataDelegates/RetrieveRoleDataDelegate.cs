using WindowsFormsApp1.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace WindowsFormsApp1.DataDelegates
{
    internal class RetrieveRoleDataDelegate : DataReaderDelegate<IReadOnlyList<Roles>>
    {
        public RetrieveRoleDataDelegate()
            : base("Movie.RetrieveRole")
        {
        }

        public override IReadOnlyList<Roles> Translate(SqlCommand command, IDataRowReader reader)
        {
            var roles = new List<Roles>();

            while (reader.Read())
            {
                roles.Add(new Roles(
                    reader.GetInt32("RoleId"),
                    reader.GetInt32("PersonId"),
                    reader.GetInt32("MovieId"),
                    reader.GetValue<bool>("isDirector"),
                    reader.GetValue<bool>("isActor"),
                    reader.GetInt32("AmountPaid")));
            }

            return roles;
        }
    }
}
