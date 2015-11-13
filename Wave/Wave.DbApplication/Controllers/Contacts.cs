using System;
using System.Collections.Generic;
using Wave.DbApplication.Models;
using NFX.Wave.MVC;
using Wave.DbApplication.Pages;

namespace Wave.DbApplication.Controllers
{
    public class Contacts : Controller
    {
        [Action]
        public object Index()
        {
            var persons = new List<Person>
            {
                new Person { ID=Guid.NewGuid().ToString("N"), FirstName="Sergey", LastName="Polyanskikh", EMail="mathf@rambler.ru" },
                new Person { ID=Guid.NewGuid().ToString("N"), FirstName="Fedor", LastName="Lubenskii", EMail="lubenskiif@mail.ru" },
                new Person { ID=Guid.NewGuid().ToString("N"), FirstName="Grant", LastName="Kesyan", EMail="grant_k@gmail.com" },
            };

            return new Index { Persons = persons };
        }

        [Action]
        public void Delete(string personId)
        {

        }

        [Action]
        public object Upsert(string personId)
        {
            var person = new Person { ID = personId };
            return new Edit { Person = person };
        }
    }
}
