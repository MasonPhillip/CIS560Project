using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class People
    {
        public int PersonId { get; }
        public string FirstName { get; }
        public string LastName { get; }
        internal People(int personId, string firstName, string lastName) 
        {
            PersonId = personId;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
