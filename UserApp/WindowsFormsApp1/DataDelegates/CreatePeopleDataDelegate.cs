using WindowsFormsApp1.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;
using System;

namespace WindowsFormsApp1.DataDelegates
{
    internal class CreatePeopleDataDelegate : NonQueryDataDelegate<People>
    {
        public readonly string firstName;
        public readonly string lastName;

        public CreatePeopleDataDelegate(string firstName, string lastName)
           : base("Movie.CreatePeople")
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("FirstName", firstName);
            command.Parameters.AddWithValue("LastName", lastName);

            var p = command.Parameters.Add("PersonId", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override People Translate(SqlCommand command)
        {
            return new People((int)command.Parameters["PersonId"].Value, firstName, lastName);
        }
    }
}

