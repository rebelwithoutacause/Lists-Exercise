using System;
using System.Collections.Generic;

namespace _02.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> guestList = new List<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] currentCmd = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = currentCmd[0];

                if (currentCmd.Length == 3)
                {
                    if (guestList.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guestList.Add(name);
                    }
                }
                else if (currentCmd.Length == 4)
                {
                    if (!guestList.Contains(name))
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                    else
                    {
                        guestList.Remove(name);
                    }
                }
            }

            foreach (string name in guestList)
            {
                Console.WriteLine(name);
            }
        }
    }
}