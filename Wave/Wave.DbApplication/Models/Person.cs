using NFX.DataAccess.CRUD;
using System;

namespace Wave.DbApplication.Models
{
    public class Person : TypedRow
    {
        [Field(key: true, required: true)]
        public string ID { get; set; }

        [Field(required: true, maxLength: 32, description: "First Name")]
        public string FirstName { get; set; }

        [Field(required: false, maxLength: 32, description: "Middle Name")]
        public string MiddleName { get; set; }

        [Field(required: true, maxLength: 32, description: "Last Name")]
        public string LastName { get; set; }

        [Field(required: false, kind: DataKind.Date, description: "Date of Birth")]
        public DateTime DOB { get; set; }

        [Field(required: true, kind: DataKind.EMail, description: "Primary E-mail")]
        public string EMail { get; set; }
    }
}
