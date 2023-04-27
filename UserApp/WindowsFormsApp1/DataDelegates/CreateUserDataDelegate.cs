using WindowsFormsApp1.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;
using System;

namespace WindowsFormsApp1.DataDelegates
{
    internal class CreateUserDataDelegate : NonQueryDataDelegate<Users>
    {
        public readonly string username;
        public readonly string password;
        public readonly string name;
        public readonly string recoveryEmail;

        public CreateUserDataDelegate(string username, string password, string name, string recoveryEmail)
           : base("Movie.CreateUsers")
        {
            this.username = username;
            this.password = password;
            this.name = name;
            this.recoveryEmail = recoveryEmail;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Username", username);
            command.Parameters.AddWithValue("Password", password);
            command.Parameters.AddWithValue("Name", name);
            command.Parameters.AddWithValue("RecoveryEmail", recoveryEmail);

            var p = command.Parameters.Add("UserId", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override Users Translate(SqlCommand command)
        {
            return new Users((int)command.Parameters["UserId"].Value, username, password, name, recoveryEmail);
        }
    }
}
