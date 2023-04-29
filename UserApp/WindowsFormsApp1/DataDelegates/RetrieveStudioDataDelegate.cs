using WindowsFormsApp1.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace WindowsFormsApp1.DataDelegates
{
    internal class RetrieveStudioDataDelegate : DataReaderDelegate<IReadOnlyList<Studios>>
    {
        public RetrieveStudioDataDelegate()
            : base("Movie.RetrieveStudio")
        {
        }

        public override IReadOnlyList<Studios> Translate(SqlCommand command, IDataRowReader reader)
        {
            var studios = new List<Studios>();

            while (reader.Read())
            {
                studios.Add(new Studios(
                    reader.GetInt32("StudioId"),
                    reader.GetString("StudioName")));
            }

            return studios;
        }
    }
}
