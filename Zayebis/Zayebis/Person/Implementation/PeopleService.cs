using System.Collections.Generic;
using System.Threading.Tasks;
using Zayebis.Util;

namespace Zayebis.Person.Implementation
{
    public class PeopleService : IPeopleService
    {
        public Task<IEnumerable<Model.Person>> GetPeople()
        {
            const int numberOfPeopleToGenerate = 50;
            return Task.Run(() => GeneratePeople(numberOfPeopleToGenerate));
        }

        private IEnumerable<Model.Person> GeneratePeople(int numberOfPeopleToGenerate)
        {
            var people = new List<Model.Person>();
            for(int i = 0; i < numberOfPeopleToGenerate; i++)
            {
                people.Add(new Model.Person (NameGenerator.GenRandomFirstName(), NameGenerator.GenRandomLastName()));
            }
            return people;
        }
    }
}
