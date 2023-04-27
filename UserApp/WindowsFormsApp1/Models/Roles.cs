using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Roles
    {
        public int RoleId { get; }
        public int PersonId { get; }
        public int MovieId { get; }
        public byte IsDirector { get; }
        public byte IsActor { get; }
        public int AmountPaid { get; }
        internal Roles(int roleId, int personId, int movieId, byte isDirector, byte isActor, int amountPaid) 
        { 
            RoleId = roleId;
            PersonId = personId;
            MovieId = movieId;
            IsDirector = isDirector;
            IsActor = isActor;
            AmountPaid = amountPaid;
        }
    }
}
