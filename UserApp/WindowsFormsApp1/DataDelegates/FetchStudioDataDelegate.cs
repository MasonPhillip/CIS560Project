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
    internal class FetchStudioDataDelegate : DataReaderDelegate<Studios>
    {
        private readonly int studioId;

        public FetchStudioDataDelegate(int studioId)
           : base("Movie.FetchStudio")
        {
            this.studioId = studioId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("StudioId", studioId);
        }

        public override Studios Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(studioId.ToString());

            return new Studios(studioId,
               reader.GetString("StudioName"));
        }
    }
}
