using System;

namespace Single_Inheritance
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
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal();
            Dog dog = new Dog();

            cat.Eat();
            dog.Eat();
            dog.Bark();
        }
    }
}
