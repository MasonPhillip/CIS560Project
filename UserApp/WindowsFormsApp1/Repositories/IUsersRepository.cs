using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Repositories
{
    public interface IUsersRepository
    {
        Users FetchUser(int userId);

        Users CreateUser(string username, string password, string name, string recoveryEmail);
    }
}
