using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewSample
{
    public class Person
    {
        public string Name { get; set; }
    }

    class People
    {
        public List<Person> PersonList { get; set; }

        public People()
        {
            this.PersonList = new List<Person>
            {
                new Person{ Name = "Abe"},
                new Person{ Name = "Alice"},
                new Person{ Name = "Bell"},
                new Person{ Name = "Ben"},
                new Person{ Name = "Bob"},
                new Person{ Name = "Fox"},
                new Person{ Name = "Gray"},
                new Person{ Name = "James"},
                new Person{ Name = "Jane"},
                new Person{ Name = "Roy"},
                new Person{ Name = "Vincent"}
            };
        }
    }
}
