using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] tokens = command.Split();
                string action = tokens[0];

                if (action == "Delete")
                {
                    int element = int.Parse(tokens[1]);
                    numbers.RemoveAll(num => num == element);
                }
                else if (action == "Insert")
                {
                    int element = int.Parse(tokens[1]);
                    int position = int.Parse(tokens[2]);
                    if (position >= 0 && position <= numbers.Count)
                    {
                        numbers.Insert(position, element);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
