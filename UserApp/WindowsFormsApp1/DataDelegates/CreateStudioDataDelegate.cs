using WindowsFormsApp1.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;
using System;

namespace WindowsFormsApp1.DataDelegates
{
    internal class CreateStudioDataDelegate : NonQueryDataDelegate<Studios>
    {
        public readonly string studioName;

        public CreateStudioDataDelegate(string studioName)
           : base("Movie.CreateStudio")
        {
            this.studioName = studioName;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("StudioName", studioName);

            var p = command.Parameters.Add("StudioId", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override Studios Translate(SqlCommand command)
        {
            return new Studios((int)command.Parameters["StudioId"].Value, studioName);
        }
    }
}
