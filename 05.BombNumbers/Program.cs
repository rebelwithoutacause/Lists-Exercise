using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
         
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

         
        int[] bombInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int bombNumber = bombInfo[0];
        int bombPower = bombInfo[1];

         
        while (numbers.Contains(bombNumber))
        {
            int bombIndex = numbers.IndexOf(bombNumber);

             
            int start = Math.Max(0, bombIndex - bombPower);
            int end = Math.Min(numbers.Count - 1, bombIndex + bombPower);

             
            numbers.RemoveRange(start, end - start + 1);
        }

         
        Console.WriteLine(numbers.Sum());
    }
}