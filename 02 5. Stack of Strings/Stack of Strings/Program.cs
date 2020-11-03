using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;

namespace Stack_of_Strings
{
    class StackOfStrings
    {
        private List<string> data;

        public StackOfStrings()
        {
            data = new List<string>();
        }

        public void Push(string item)
        {
            this.data.Add(item);
        }
        public string Pop()
        {
            string result = "";
            int index = this.data.Count-1;
            if (index >= 0)
            {
                result = this.data[index];
                this.data.RemoveAt(index);
            }

            return result;
        }

        public string Peek()
        {
            string result = "";
            int index = this.data.Count-1;
            if (index >= 0)
                result = this.data[index];

            return result;
        }

        public bool IsEmpty()
        {
            return this.data.Count == 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StackOfStrings myStack = new StackOfStrings();

            Console.WriteLine("Does the stack starts empty? {0}",myStack.IsEmpty());
            myStack.Push("first");
            myStack.Push("second");
            Console.WriteLine("Is it empty after pushing two values? {0}", myStack.IsEmpty());

            Console.WriteLine("poped value: {0}", myStack.Pop());
            myStack.Push("third");
            Console.WriteLine("peek value: {0}", myStack.Peek());
            Console.WriteLine("poped value: {0}", myStack.Pop());
            Console.WriteLine("poped value: {0}", myStack.Pop());
        }
    }
}
