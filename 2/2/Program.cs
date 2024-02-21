using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Skapa lista av element
        List<string> elements = new List<string> { "axeman", "archer", "swordsman", "knight", "dan", "daniela", "dario", "dusan" };

        // Gruppera listan av element med deras första bokstav 
        GroupAndSaveElements(elements);

        Console.WriteLine("Job's Done");
        Console.ReadLine();
    }

    // Gruppera elementen beroende på deras första bokstav och sparar dem i ett directory 
    static void GroupAndSaveElements(List<string> elements)
    {
        foreach (string element in elements)
        {
            // Få fram första bokstaven i varje element, ändrar även om till liten bokstav
            char firstLetter = char.ToLower(element[0]);

            // Skapa ett directory för varje den första bokstaven om det inte finns
            string directoryPath = Path.Combine(Directory.GetCurrentDirectory(), firstLetter.ToString());
            if (!Directory.Exists(directoryPath))
                Directory.CreateDirectory(directoryPath);

            // Gör om elemeten till en fil och lägg i rätt directory
            string filePath = Path.Combine(directoryPath, element + ".txt");
            File.WriteAllText(filePath, element);
        }
    }
}