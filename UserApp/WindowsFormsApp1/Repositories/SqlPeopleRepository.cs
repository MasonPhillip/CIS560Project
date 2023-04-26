using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using WindowsFormsApp1.Models;
using System.Transactions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using PersonData;

namespace WindowsFormsApp1.Repositories
{
    public class SqlPeopleRepository : IPeopleRepository
    {
        private readonly string connectionString;

        public SqlPeopleRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public People CreatePerson(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(firstName));

            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(lastName));

            using (var transaction = new TransactionScope())
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    using (var command = new SqlCommand("Person.CreatePerson", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("FirstName", firstName);
                        command.Parameters.AddWithValue("LastName", lastName);

                        var p = command.Parameters.Add("PersonId", SqlDbType.Int);
                        p.Direction = ParameterDirection.Output;

                        connection.Open();

                        command.ExecuteNonQuery();

                        transaction.Complete();

                        var personId = (int)command.Parameters["PersonId"].Value;

                        return new People(personId, firstName, lastName);
                    }
                }
            }
        }

        public People FetchPerson(int personId)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("Person.FetchPerson", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("PersonId", personId);

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        var person = TranslatePerson(reader);

                        if (person == null)
                            throw new RecordNotFoundException(personId.ToString());

                        return person;
                    }
                }
            }
        }

        public IReadOnlyList<People> RetrievePeople()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("Person.RetrievePersons", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                        return TranslatePersons(reader);
                }
            }
        }

        private People TranslatePerson(SqlDataReader reader)
        {
            var personIdOrdinal = reader.GetOrdinal("PersonId");
            var firstNameOrdinal = reader.GetOrdinal("FirstName");
            var lastNameOrdinal = reader.GetOrdinal("LastName");

            if (!reader.Read())
                return null;

            return new People(
               reader.GetInt32(personIdOrdinal),
               reader.GetString(firstNameOrdinal),
               reader.GetString(lastNameOrdinal));
        }

        private IReadOnlyList<People> TranslatePersons(SqlDataReader reader)
        {
            var persons = new List<People>();

            var personIdOrdinal = reader.GetOrdinal("PersonId");
            var firstNameOrdinal = reader.GetOrdinal("FirstName");
            var lastNameOrdinal = reader.GetOrdinal("LastName");

            while (reader.Read())
            {
                persons.Add(new People(
                   reader.GetInt32(personIdOrdinal),
                   reader.GetString(firstNameOrdinal),
                   reader.GetString(lastNameOrdinal)));
            }

            return persons;
        }
    }
}