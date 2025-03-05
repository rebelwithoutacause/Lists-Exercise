using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
         
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        while (true)
        {
            
            string command = Console.ReadLine();
            if (command == "end")
                break;

            string[] parts = command.Split();
            string action = parts[0];

            if (action == "Add")
            {
                int number = int.Parse(parts[1]);
                numbers.Add(number);
            }
            else if (action == "Remove")
            {
                int number = int.Parse(parts[1]);
                numbers.Remove(number);
            }
            else if (action == "RemoveAt")
            {
                int index = int.Parse(parts[1]);
                numbers.RemoveAt(index);
            }
            else if (action == "Insert")
            {
                int number = int.Parse(parts[1]);
                int index = int.Parse(parts[2]);
                numbers.Insert(index, number);
            }
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}