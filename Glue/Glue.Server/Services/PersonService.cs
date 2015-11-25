using NFX;
using System.Linq;
using System.Collections.Generic;
using Glue.Contracts.DataContracts;
using Glue.Contracts.Services;

namespace Glue.Server.Services
{
    /// <summary>
    /// This class is singleton by contract as it maintains global
    /// state: m_Persons.
    /// </summary>
    public class PersonService : IPersonService
    {
        private List<Person> m_Persons;

        public PersonService()
        {
            m_Persons = new List<Person>();
        }

        public List<Person> FindByName(string pattern)
        {
            if (pattern.IsNullOrEmpty())
                return null;

            lock(m_Persons)
                return m_Persons.Where(p => p.Name.ToLowerInvariant().Contains(pattern.ToLowerInvariant()))
                                .ToList();
        }

        public void Set(Person person)
        {
            if (person == null) return;
            lock(m_Persons)
                m_Persons.Add(person);
        }
    }
}
