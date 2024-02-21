using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // En array med strängar
        string[] inputArray = { "axeman", "archer", "swordsman", "knight", };

        // Filtrera elementen i array med det som börjar på A
        List<string> resultList = new List<string>();
        foreach (string element in inputArray)
        {
            if (element.StartsWith("a", StringComparison.OrdinalIgnoreCase))
            {
                resultList.Add(element);
            }
        }

        // Visa de filtrerade elemeten
        Console.WriteLine("Elements starting with 'a':");
        foreach (string element in resultList)
        {
            Console.WriteLine(element);
        }

        Console.ReadLine();
    }
}