using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DataDelegates;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Repositories
{
    internal class SqlUsersRepository : IUsersRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlUsersRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Users CreateUser(string username, string password, string name, string recoveryEmail)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(username));
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(password));
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(name));
            if (string.IsNullOrWhiteSpace(recoveryEmail))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(recoveryEmail));

            var d = new CreateUserDataDelegate(username, password, name, recoveryEmail);
            return executor.ExecuteNonQuery(d);
        }

        public Users FetchUser(int userId)
        {
            var d = new FetchUserDataDelegate(userId);
            return executor.ExecuteReader(d);
        }

        public void SaveUser(int userId, string username, string password, string name, string recoveryEmail)
        {
            executor.ExecuteNonQuery(new SaveUserDataDelegate(userId, username, password, name, recoveryEmail));
        }

        public IReadOnlyList<Users> RetrieveUsers()
        {
            return executor.ExecuteReader(new RetrieveUserDataDelegate());
        }

        public Users GetUser(string username)
        {
            var d = new GetUserDataDelegate(username);
            return executor.ExecuteReader(d);
        }
    }
}
