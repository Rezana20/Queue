using System;
using System.Collections.Generic;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> numbers = new Queue<string>();
            numbers.Enqueue("one");
            numbers.Enqueue("two");
            numbers.Enqueue("three");
            numbers.Enqueue("four");
            numbers.Enqueue("five");

            foreach (string num in numbers)
            {
                Console.Write($" {num}, ");
            }

            Console.WriteLine("\nDequeuing '{0}'", numbers.Dequeue());
            Console.WriteLine();
            Console.WriteLine("Peek at next item to dequeue: {0}", 
                numbers.Peek());
            Console.WriteLine();

            foreach (string num in numbers)
            {
                Console.Write($" {num}, ");
            }
            Console.WriteLine();

            Console.WriteLine("Dequeuing '{0}'", numbers.Dequeue());

            foreach (string num in numbers)
            {
                Console.Write($" {num}, ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
