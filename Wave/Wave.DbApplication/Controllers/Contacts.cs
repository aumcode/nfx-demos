using System;
using System.Linq;
using System.Collections.Generic;
using Wave.DbApplication.Models;
using NFX.Wave.MVC;
using Wave.DbApplication.Pages;
using NFX;
using NFX.DataAccess.MySQL;
using NFX.DataAccess.CRUD;

namespace Wave.DbApplication.Controllers
{
    public class Contacts : Controller
    {
        [Action]
        public object Index()
        {
            //var persons = new List<Person>
            //{
            //    new Person { ID=Guid.NewGuid().ToString("N"), FirstName="Sergey", LastName="Polyanskikh", EMail="mathf@rambler.ru" },
            //    new Person { ID=Guid.NewGuid().ToString("N"), FirstName="Fedor", LastName="Lubenskii", EMail="lubenskiif@mail.ru" },
            //    new Person { ID=Guid.NewGuid().ToString("N"), FirstName="Grant", LastName="Kesyan", EMail="grant_k@gmail.com" },
            //}; 

            var persons = new List<Person>();

            var data = App.DataStore as MySQLDataStore;
            var query = new Query("Data.Scripts.GetAllPersons", typeof(Person));
            var set = data.Load(query);
            if (set != null && set.Any())
            {
                persons.AddRange(set[0].Cast<Person>());
            }

            return new Index { Persons = persons };
        }

        [Action]
        public void Delete(string personId)
        {
            var data = App.DataStore as MySQLDataStore;
            var query = new Query("Data.Scripts.DeletePerson")
                            {
                                new Query.Param("id", personId)
                            };
            data.ExecuteWithoutFetch(query);
        }

        [Action]
        public object Upsert(string personId)
        {
            var person = new Person
            {
                ID = Guid.NewGuid().ToString("N"),
                FirstName = "A",
                MiddleName = "B",
                LastName = "C",
                DOB = DateTime.Now,
                EMail = "abretok@gmail.com"
            };
            var data = App.DataStore as MySQLDataStore;
            data.Insert(person);

            return new Edit { Person = person };
        }
    }
}
