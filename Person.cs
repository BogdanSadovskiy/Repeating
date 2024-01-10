using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat
{
    internal class Person
    {
        private  string name;
        private  int age;

       
        public  Person(string name_, int age_)
        {
            name = name_;
            age = age_;
        }

        public static List<Person> createTenPerson()
        {
            List<Person> persons= new List<Person>();
            persons.Add(new Person("Bogdan", 27));
            persons.Add(new Person("Olia", 39));
            persons.Add(new Person("Taras", 32));
            persons.Add(new Person("Marta", 18));
            persons.Add(new Person("Daniel", 5));
            persons.Add(new Person("Max", 23));
            persons.Add(new Person("Denis", 16));
            persons.Add(new Person("Roman", 40));
            persons.Add(new Person("Igor", 78));
            persons.Add(new Person("Anna", 21));
            return persons;
        }
        public string getName()
        {
            return name;
        }
        public int getAge()
        {
            return age;
        }

    }
}
