using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using WindowsFormsApp1.Models;
using PersonData;
using DataAccess;
using WindowsFormsApp1.DataDelegates;

namespace WindowsFormsApp1.Repositories
{
    public class SqlPeopleRepository : IPeopleRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlPeopleRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public People CreatePerson(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(firstName));

            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(lastName));

            var d = new CreatePeopleDataDelegate(firstName, lastName);
            return executor.ExecuteNonQuery(d);
        }

        public People FetchPerson(int personId)
        {
            var d = new FetchPeopleDataDelegate(personId);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<People> RetrievePeople()
        {
            return executor.ExecuteReader(new RetrievePersonDataDelegate());
        }
    }
}