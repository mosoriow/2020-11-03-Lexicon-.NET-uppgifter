using System;
using System.Threading.Tasks.Dataflow;

namespace Hierarchical_Inheritance
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
    class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("meowing...");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.Eat();
            dog.Bark();

            cat.Eat();
            cat.Meow();
        }
    }
}
