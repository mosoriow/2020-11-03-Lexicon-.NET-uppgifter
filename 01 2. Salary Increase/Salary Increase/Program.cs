using System;
using System.Collections.Generic;

namespace Salary_Increase
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public Person()
        {
            firstName = "";
            lastName = "";
            age = 0;
            salary = 0;
        }

        public Person(string argName, string argSurname, int argAge)
        {
            firstName = argName;
            lastName = argSurname;
            age = argAge;
            salary = 0;
        }
        public Person(string argName, string argSurname, int argAge, decimal argSalary)
        {
            firstName = argName;
            lastName = argSurname;
            age = argAge;
            salary = argSalary;
        }

        public override string ToString()
        {
            return firstName + " " + lastName + " receives " + salary.ToString("0.00") + " dollars.";
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (age > 30)
                salary += salary * percentage / 100;
            else
                salary += salary * percentage / 200;
        }

        public string FirstName
        {
            get { return firstName; }
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
            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person(cmdArgs[0],
                                        cmdArgs[1],
                                        int.Parse(cmdArgs[2]),
                                        decimal.Parse(cmdArgs[3]));

                persons.Add(person);
            }
            var bonus = decimal.Parse(Console.ReadLine());
            persons.ForEach(p => p.IncreaseSalary(bonus));
            persons.ForEach(p => Console.WriteLine(p.ToString()));

        }
    }
}
