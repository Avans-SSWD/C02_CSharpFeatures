using System;
using System.Collections.Generic;

namespace Domain
{
    public class Person
    {

        public Person(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        public string FirstName { get; set; }

        public string LastName { get; }
        public string City { get; set; }

        public Person Related { get; set; }

        public decimal Salary { get; set; }

        public DateTime DateOfBirth { get; set; }


        public string GetName() => "";

        public string GetRelatedName() => "";

        public string GetSalaryAsString() => "";

        public int CountChildren { get; set; }

        public IEnumerable<string> Hobbies { get; set; }



    }


}
