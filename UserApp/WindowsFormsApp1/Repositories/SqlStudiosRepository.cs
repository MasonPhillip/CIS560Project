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
    public class SqlStudiosRepository : IStudiosRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlStudiosRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Studios CreateStudio(string studioName)
        {
            if (string.IsNullOrWhiteSpace(studioName))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(studioName));

            var d = new CreateStudioDataDelegate(studioName);
            return executor.ExecuteNonQuery(d);
        }

        public Studios FetchStudio(int studioId)
        {
            var d = new FetchStudioDataDelegate(studioId);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Studios> RetrieveStudios()
        {
            return executor.ExecuteReader(new RetrieveStudioDataDelegate());
        }
    }
}