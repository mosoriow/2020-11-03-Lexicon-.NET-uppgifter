using System;
using System.Collections.Generic;

namespace Validate_Data
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public Person(string argName, string argSurname, int argAge, decimal argSalary)
        {
            FirstName = argName;
            LastName = argSurname;
            Age = argAge;
            Salary = argSalary;
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
            private set
            {
                if (value.Length < 3)
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                firstName = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            private set
            {
                if (value.Length < 3)
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                lastName = value;
            }
        }

        public int Age
        {
            get { return age; }
            private set
            {
                if (value < 1)
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                age = value;
            }
        }

        public decimal Salary
        {
            get { return salary; }
            private set
            {
                if (value < 460)
                    throw new ArgumentException("Salary cannot be less than 460 dollars!");
                salary = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var cmdArgs = Console.ReadLine().Split();

            try
            {
                var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), decimal.Parse(cmdArgs[3]));
                var bonus = decimal.Parse(Console.ReadLine());

                person.IncreaseSalary(bonus);
                Console.WriteLine(person.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("{0}", e);
            }
        }
    }
}
