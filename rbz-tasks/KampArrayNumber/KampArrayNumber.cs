using System;
using System.Text.RegularExpressions;
using TaskSystem;

namespace KampArrayNumber
{
    public class KampArrayNumberTaskProcessor: ITaskProcessor
    {
        public void Process()
        {
            Console.WriteLine("Bitte gebe die Größe ein");
            var line = Console.ReadLine();

            int number;
            if (line != null && Regex.IsMatch(line, @"^\d+$"))
            {
                number = int.Parse(line);
            }
            else
            {
                throw new Exception("Das ist keine Nummer");
            }
            var array = new int[number];

            var random = new Random();
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 11);
            }
            
            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    for (var index = 1; index < array.Length; index++)
                    {
                        array[index - 1] = array[index];
                    }

                    array[array.Length - 1] = 0;
                }
            }

            Console.WriteLine($"[{string.Join(", ", array)}]");
        }

        public string GetName()
        {
            return "ArrayNumber";
        }
    }
}