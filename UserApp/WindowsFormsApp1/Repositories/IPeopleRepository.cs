using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Repositories
{
    public interface IPeopleRepository
    {
        IReadOnlyList<People> RetrievePeople();

        People FetchPerson(int personId);

        People CreatePerson(string firstName, string lastName);
    }
}
