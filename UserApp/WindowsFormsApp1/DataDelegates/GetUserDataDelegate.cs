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
    internal class GetUserDataDelegate : DataReaderDelegate<Users>
    {
        private readonly string username;

        public GetUserDataDelegate(string username)
           : base("Movie.GetUser")
        {
            this.username = username;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("UserName", username);
        }

        public override Users Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new Users(
               reader.GetInt32("UserId"),
               username,
               reader.GetString("Password"),
               reader.GetString("Name"),
               reader.GetString("RecoveryEmail"));
        }
    }
}
