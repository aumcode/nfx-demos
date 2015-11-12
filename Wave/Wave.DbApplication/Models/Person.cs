using System;

namespace Wave.DbApplication.Models
{
    public class Person
    {
        public string ID { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public DateTime DOB { get; set; }

        public string EMail { get; set; }
    }
}
