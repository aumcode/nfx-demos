using System;
using System.Linq;
using System.Collections.Generic;

using NFX;
using NFX.Wave.MVC;
using NFX.DataAccess.CRUD; 

using Wave.DbApplication.Models;
using Wave.DbApplication.Pages;

namespace Wave.DbApplication.Controllers
{
    public class Contacts : Controller
    {
        [Action]
        public object Index()
        {
            var query = new Query("Data.Scripts.GetAllPersons", typeof(Person));
            var persons = AppContext.DataStore
                                    .LoadOneRowset(query)
                                    .AsEnumerableOf<Person>();

            return new Index { Persons = persons as IEnumerable<Person> };
        }

        [Action]
        public void Delete(string personId)
        {
            AppContext.DataStore.Delete(new Person { ID = personId });
        }

        [Action(name: "edit", order: 0, matchScript: "match{methods=GET}")]
        public object GetEdit(string personId)
        {
            Person person = null;
            if (personId.IsNotNullOrWhiteSpace())
            {
                var query = new Query("Data.Scripts.GetPersonByID", typeof(Person))
                            {
                                new Query.Param("id", personId)
                            };
                person = AppContext.DataStore.LoadOneRow(query) as Person;
            }

            if (person == null)
              person = new Person { ID = Guid.NewGuid().ToString("N") };

            return new Edit { Person = person };
        }

        [Action(name: "edit", order: 0, matchScript: "match{methods=POST}")]
        public object SaveEdit(Person person)
        {
            if (person == null)
                person = new Person { ID = Guid.NewGuid().ToString("N") };

            var error = person.Validate();
            if (error == null)
            {
                AppContext.DataStore.Upsert(person);
                if (WorkContext.RequestedJSON)
                  return new ClientRecord(person, null);
                else
                  return new Redirect("/");
            }

            if (WorkContext.RequestedJSON)
              return new ClientRecord(person, error);
            else
              return new Edit { Person = person, ValidationError = error };
        }
    }
}
