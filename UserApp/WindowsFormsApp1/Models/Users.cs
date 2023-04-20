using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Users
    {
        public int PersonId { get; }
        public string Username { get; }
        public string Password { get; }
        public string Name { get; }
        public string RecoveryEmail { get; }
        internal Users(int personId, string username, string password, string name, string recoveryEmail)
        {
            PersonId = personId;
            Username = username;
            Password = password;
            Name = name;
            RecoveryEmail = recoveryEmail;
        }
    }
}
