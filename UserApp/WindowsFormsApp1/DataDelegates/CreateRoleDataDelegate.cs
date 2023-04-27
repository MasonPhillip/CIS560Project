using WindowsFormsApp1.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;
using System;

namespace WindowsFormsApp1.DataDelegates
{
    internal class CreateRoleDataDelegate : NonQueryDataDelegate<Roles>
    {
        public readonly int personId;
        public readonly int movieId;
        public readonly byte isDirector;
        public readonly byte isActor;
        public readonly int amountPaid;

        public CreateRoleDataDelegate(int personId, int movieId, byte isDirector, byte isActor, int amountPaid)
           : base("Movie.CreateRole")
        {
            this.personId = personId;
            this.movieId = movieId;
            this.isDirector = isDirector;
            this.isActor = isActor;
            this.amountPaid = amountPaid;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("PersonId", personId);
            command.Parameters.AddWithValue("MovieId", movieId);
            command.Parameters.AddWithValue("IsDirector", isDirector);
            command.Parameters.AddWithValue("IsActor", isActor);
            command.Parameters.AddWithValue("AmountPaid", amountPaid);

            var p = command.Parameters.Add("RoleId", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override Roles Translate(SqlCommand command)
        {
            return new Roles((int)command.Parameters["RoleId"].Value, personId, movieId, isDirector, isActor, amountPaid);
        }
    }
}

