using System;
using System.Collections.Generic;

namespace Random_List
{
    class RandomList : List<string>
    {
        public string RandomString()
        {
            string result = "";
            int total = this.Count;
            Random rnd = new Random();

            if (total > 0)
            {
                int removeIndex = rnd.Next(0, total);

                result = this[removeIndex];
                this.RemoveAt(removeIndex);
            }

            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            RandomList myList = new RandomList { "one","two","three","four","five","six","seven","eight","nine","ten" };

            for(int i = 0; i < 10; i++)
            {
                string randValue = myList.RandomString();
                Console.Write("{0} ",randValue);
            }
            Console.WriteLine();
            Console.WriteLine("left: {0}",myList.Count);
        }
    }
}
