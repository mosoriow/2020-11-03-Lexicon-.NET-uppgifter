using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Encapsulation_1
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public Person()
        {
            firstName = "";
            lastName = "";
            age = 0;
        }

        public Person(string argName, string argSurname, int argAge)
        {
            firstName = argName;
            lastName = argSurname;
            age = argAge;
        }

        public override string ToString ()
        {
            if (age==1)
                return firstName + " " + lastName + " is " + age.ToString() + " year old";
            else
                return firstName + " " + lastName + " is " + age.ToString() + " years old";
        }

        public string FirstName
        {
            get { return firstName;  }
        }

        public int Age
        {
            get { return age; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var lines = 5;
            var persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));
                persons.Add(person);
            }

            persons.OrderBy(p => p.FirstName)
                   .ThenBy(p => p.Age)
                   .ToList()
                   .ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
