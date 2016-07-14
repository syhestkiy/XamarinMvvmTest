using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zayebis.Person
{
    public interface IPeopleService
    {
        Task<IEnumerable<Model.Person>> GetPeople();
    }
}
