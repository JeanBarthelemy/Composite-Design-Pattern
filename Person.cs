using System;
using System.Collections.Generic;
using System.Text;

namespace Composite_Design_Pattern_Quête_2
{
    public class Person
    {
        public List<Person> descendants1 { get; } = new List<Person>();
        public string name { get; set; }
        public Person(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            string description = name;
            foreach (Person descendant in descendants1)
            {
                description = description + "\n-" + descendant;
            }
            return description;
        }
    }
}
