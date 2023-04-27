using WindowsFormsApp1.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;
using System;

namespace WindowsFormsApp1.DataDelegates
{
    internal class FetchPeopleDataDelegate : DataReaderDelegate<People>
    {
        private readonly int personId;

        public FetchPeopleDataDelegate(int personId)
           : base("Movie.FetchPerson")
        {
            this.personId = personId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("PersonId", personId);
        }

        public override People Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(personId.ToString());

            return new People(personId,
               reader.GetString("FirstName"),
               reader.GetString("LastName"));
        }
    }
}