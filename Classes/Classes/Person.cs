using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hello {0}, my name is {1}", to, Name);
        }
        
        public static Person Parse(string newPerson)
        {
            var person = new Person();
            person.Name = newPerson;
            return person;
        }
    }
}
