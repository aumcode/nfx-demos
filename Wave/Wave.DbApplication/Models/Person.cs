using NFX.DataAccess.CRUD;
using System;

namespace Wave.DbApplication.Models
{
    public class Person : TypedRow
    {
        [Field(key: true, required: true)]
        public string ID { get; set; }

        [Field(required: true)]
        public string FirstName { get; set; }

        [Field(required: false)]
        public string MiddleName { get; set; }

        [Field(required: true)]
        public string LastName { get; set; }

        [Field(required: false)]
        public DateTime DOB { get; set; }

        [Field(required: true)]
        public string EMail { get; set; }
    }
}
