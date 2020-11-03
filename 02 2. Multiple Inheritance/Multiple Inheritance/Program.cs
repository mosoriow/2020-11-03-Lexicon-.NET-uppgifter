using System;

namespace Multiple_Inheritance
{
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("eating...");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("barking...");
        }
    }

    class Puppy : Dog
    {
        public void Weep()
        {
            Console.WriteLine("weeping...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal();
            Dog dog = new Dog();
            Puppy puppy = new Puppy();

            Console.WriteLine("Cat - just an animal");
            cat.Eat();

            Console.WriteLine("Dog");
            dog.Eat();
            dog.Bark();

            Console.WriteLine("Puppy");
            puppy.Eat();
            puppy.Bark();
            puppy.Weep();
        }
    }
}
