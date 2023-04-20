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
        public bool IsDirector { get; }
        public bool IsActor { get; }
        public int AmountPaid { get; }
        internal Roles(int roleId, int personId, int movieId, bool isDirector, bool isActor, int amountPaid) 
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
