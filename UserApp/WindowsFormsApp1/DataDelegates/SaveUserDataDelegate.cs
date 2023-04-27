using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DataDelegates
{
    internal class SaveUserDataDelegate : DataDelegate
    {
        public readonly int userId;
        public readonly string username;
        public readonly string password;
        public readonly string name;
        public readonly string recoveryEmail;

        public SaveUserDataDelegate(int userId, string username, string password, string name, string recoveryEmail)
           : base("Movie.SaveUser")
        {
            this.userId = userId;
            this.username = username;
            this.password = password;
            this.name = name;
            this.recoveryEmail = recoveryEmail;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("UserId", userId);
            command.Parameters.AddWithValue("Username", username);
            command.Parameters.AddWithValue("Password", password);
            command.Parameters.AddWithValue("Name", name);
            command.Parameters.AddWithValue("RecoveryEmail", recoveryEmail);
        }
    }
}
