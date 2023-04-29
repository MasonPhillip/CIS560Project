using WindowsFormsApp1.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace WindowsFormsApp1.DataDelegates
{
    internal class RetrieveUserDataDelegate : DataReaderDelegate<IReadOnlyList<Users>>
    {
        public RetrieveUserDataDelegate()
            : base("Movie.RetrieveUser")
        {
        }

        public override IReadOnlyList<Users> Translate(SqlCommand command, IDataRowReader reader)
        {
            var users = new List<Users>();

            while (reader.Read())
            {
                users.Add(new Users(
                    reader.GetInt32("UserId"),
                    reader.GetString("UserName"),
                    reader.GetString("Password"),
                    reader.GetString("Name"),
                    reader.GetString("RecoveryEmail")));
            }

            return users;
        }
    }
}
