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
    internal class FetchUserDataDelegate : DataReaderDelegate<Users>
    {
        public readonly int userId;

        public FetchUserDataDelegate(int userId)
           : base("Movie.FetchUser")
        {
            this.userId = userId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("UserId", userId);
        }

        public override Users Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(userId.ToString());

            return new Users(userId,
               reader.GetString("UserName"),
               reader.GetString("Password"),
               reader.GetString("Name"),
               reader.GetString("RecoveryEmail"));
        }
    }
}
