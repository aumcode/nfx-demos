using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NFX.Environment;

namespace LaconicConfig.Demos.Classes
{
    public enum Countries { USA, Canada, Japan }

    [Config("Person/data")]
    public class Person
    {
        private const string PERSON_DATA = "Person data:";

        [Config("$private-salary")]
        private int m_salary;

        [Config("$protected-phone")]
        protected string m_Phone;
        
        [Config("$public-name")]
        public string Name { get; set; }

        [Config("$DOB")]
        public DateTime DOB { get; set; }

        [Config("$height", 180)]
        public int Height { get; set; }

        [Config("extra/$enum-country")]
        public Countries Country { get; set; }

        [Config]
        public byte[] AgesOfChildren;

        [Config("extra/address")]
        public IConfigSectionNode Address { get; set; }

        public int GetSalary()
        {
            return m_salary ;
        }

        public string GetPhone()
        {
            return m_Phone;
        }

        public override string ToString()
        {
            var res = new StringBuilder();
            res.AppendLine(PERSON_DATA);
            res.AppendLine();
            res.AppendLine("Salary = " + GetSalary());
            res.AppendLine("Phone = " + GetPhone());
            res.AppendLine("Name = " + Name);
            res.AppendLine("DOB = " + DOB.ToShortDateString());
            res.AppendLine("Height = " + Height);
            res.AppendLine("Country = " + Country);
            res.AppendLine("Ages of children = " + bytesToString());
            res.AppendLine(@"// Instance of configuration node");
            res.AppendLine("Address[\"zipcode\"] = " + Address["zipcode"].Value);
            res.AppendLine("Address.AttrByName(\"city\") = " + Address.AttrByName("city").Value);
            return res.ToString();
        }

        private string bytesToString()
        {
            if (AgesOfChildren == null)
                return "null";
            var res = new StringBuilder("[");
            var len = AgesOfChildren.Length - 1;
            for (var i = 0; i < len; i++)
            {
                res.Append(string.Format("{0:X}", AgesOfChildren[i]) + ", ");
            }
            res.Append(string.Format("{0:X}", AgesOfChildren[len]) + "]");
            return res.ToString();
        }
    }
}
