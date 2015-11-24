using NFX;
using System.Linq;
using System.Collections.Generic;
using Glue.Contracts.DataContracts;
using Glue.Contracts.Services;

namespace Glue.Server.Services
{
    public class PersonService : IPersonService
    {
        private List<Person> _persons;

        public PersonService()
        {
            _persons = new List<Person>();
        }

        public List<Person> FindByName(string pattern)
        {
            if (pattern.IsNullOrEmpty())
                return null;

            return _persons.Where(p => p.Name.ToLowerInvariant().Contains(pattern.ToLowerInvariant()))
                            .ToList();
        }

        public void Set(Person person)
        {
            _persons.Add(person);
        }
    }
}
