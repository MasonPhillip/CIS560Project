using WindowsFormsApp1.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace WindowsFormsApp1.DataDelegates
{
    internal class RetrievePersonDataDelegate : DataReaderDelegate<IReadOnlyList<People>>
    {
        public RetrievePersonDataDelegate()
            : base("Movie.RetrievePerson")
        {
        }

        public override IReadOnlyList<People> Translate(SqlCommand command, IDataRowReader reader)
        {
            var people = new List<People>();

            while (reader.Read())
            {
                people.Add(new People(
                    reader.GetInt32("PersonId"),
                    reader.GetString("FirstName"),
                    reader.GetString("LastName")));
            }

            return people;
        }
    }
}
