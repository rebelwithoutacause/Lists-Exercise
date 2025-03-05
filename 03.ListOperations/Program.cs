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
            while ((command = Console.ReadLine()) != "End")
            {
                string[] inputParts = command.Split();
                string action = inputParts[0];

                if (action == "Add")
                {
                    int number = int.Parse(inputParts[1]);
                    numbers.Add(number);
                }
                else if (action == "Insert")
                {
                    int number = int.Parse(inputParts[1]);
                    int index = int.Parse(inputParts[2]);
                    if (index >= 0 && index < numbers.Count)
                    {
                        numbers.Insert(index, number);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (action == "Remove")
                {
                    int index = int.Parse(inputParts[1]);
                    if (index >= 0 && index < numbers.Count)
                    {
                        numbers.RemoveAt(index);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (action == "Shift")
                {
                    string direction = inputParts[1];
                    int count = int.Parse(inputParts[2]);
                    count %= numbers.Count;

                    if (direction == "left")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int first = numbers[0];
                            numbers.RemoveAt(0);
                            numbers.Add(first);
                        }
                    }
                    else if (direction == "right")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int last = numbers[numbers.Count - 1];
                            numbers.RemoveAt(numbers.Count - 1);
                            numbers.Insert(0, last);
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}