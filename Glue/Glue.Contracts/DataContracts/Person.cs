using System;
using System.Collections.Generic;
using NFX;

namespace Glue.Contracts.DataContracts
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public int Height { get; set; }
        public Country Citizenship { get; set; }
        public List<Location> Locations { get; set; }

        public override string ToString()
        {
            return "name: {0}, DOB: {1}, height: {2}, citizenship: {3}, locations: {4}"
                .Args(Name ?? "-", DOB, Height, Citizenship, Locations == null ? "-" : Locations.Count.ToString());
        }
    }
}
