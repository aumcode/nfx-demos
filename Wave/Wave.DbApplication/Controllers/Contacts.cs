using System;
using System.Linq;
using System.Collections.Generic;
using Wave.DbApplication.Models;
using NFX.Wave.MVC;
using Wave.DbApplication.Pages;
using NFX.DataAccess.CRUD;

namespace Wave.DbApplication.Controllers
{
    public class Contacts : Controller
    {
        [Action]
        public object Index()
        {
            var persons = new List<Person>();

            var query = new Query("Data.Scripts.GetAllPersons", typeof(Person));
            var set = AppContext.DataStore.Load(query);
            if (set != null && set.Any())
            {
                persons.AddRange(set[0].Cast<Person>());
            }

            return new Index { Persons = persons };
        }

        [Action]
        public void Delete(string personId)
        {
            var query = new Query("Data.Scripts.DeletePerson")
                            {
                                new Query.Param("id", personId)
                            };
            AppContext.DataStore.ExecuteWithoutFetch(query);
        }

        [Action]
        public object Edit(string personId)
        {
            Person person;
            if (personId != null)
            {
                var query = new Query("Data.Scripts.GetPersonByID", typeof(Person))
                            {
                                new Query.Param("id", personId)
                            };
                person = AppContext.DataStore.LoadOneRow(query) as Person;
            }
            else
            {
                person = new Person { ID = Guid.NewGuid().ToString("N") };
            }

            return new Edit { Person = person };
        }

        [Action]
        public object Save(Person person)
        {
            AppContext.DataStore.Upsert(person);

            return new Index();
        }
    }
}
