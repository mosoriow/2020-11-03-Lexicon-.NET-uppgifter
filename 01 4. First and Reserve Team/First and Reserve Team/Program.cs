using System;
using System.Collections.Generic;

namespace First_and_Reserve_Team
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

    class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;

        public Team(string name)
        {
            this.name = name;
            firstTeam = new List<Person>();
            reserveTeam = new List<Person>();
        }

        public List<Person> FirstTeam
        {
            get { return this.firstTeam; }
        }
        public List<Person> ReserveTeam
        {
            get { return this.reserveTeam; }
        }

        public void AddPlayer(Person player)
        {
            if (player.Age < 40)
                firstTeam.Add(player);
            else
                reserveTeam.Add(player);
        }

        public int FirstLength
        {
            get { return this.firstTeam.Count; }
        }

        public int ReserveLength
        {
            get { return this.reserveTeam.Count; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());

            var persons = new List<Person>();

            var myTeam = new Team("Lexicon");

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

            foreach (Person p in persons)
            {
                myTeam.AddPlayer(p);
            }

            Console.WriteLine("First team has {0} players.",myTeam.FirstLength);
            Console.WriteLine("Reserve team has {0} players.",myTeam.ReserveLength);
        }
    }
}
