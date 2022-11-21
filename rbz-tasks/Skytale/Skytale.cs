using System;
using System.Text.RegularExpressions;
using TaskSystem;

namespace Skytale
{
    public class SkytaleTaskProcessor: ITaskProcessor
    {

        public static void Main()
        {
            new SkytaleTaskProcessor().Process();
        }
        
        public void Process()
        {
            Console.WriteLine($"Der geheime Code lautet: {Geheim("HABEAMSONNTAGKEINEZEITMUSSLERNENSORRY", 5)}");
            Console.WriteLine($"Der nicht mehr geheime Code lautet: {NichtGeheim("LEEMTEOAEENLMTITROLNIBRIVRNKGLASIDEEBHE", 2)}");
            Console.WriteLine($"Der nicht mehr geheime Code lautet: {NichtGeheim("AMTWCFLEDERTNWITNEASMITOHALNIESEZESUDNU", 2)}");
            
            int? key = null;
            while (key == null)
            {
                Console.WriteLine("Gebe dein Key ein...");
                var line = Console.ReadLine() ?? throw new InvalidOperationException();

                if (Regex.IsMatch(line, @"^\d+$"))
                {
                    key = int.Parse(line);
                }
            }

            Console.WriteLine("Gebe dein Text zur Verschlüsselung ein...");
            var encode = Console.ReadLine() ?? throw new InvalidOperationException();
            Console.WriteLine($"Deine Verschlüsselung: {Geheim(encode, (int) key)}");
        
            Console.WriteLine("Gebe dein Text zur Entschlüsselung ein...");
            var decode = Console.ReadLine() ?? throw new InvalidOperationException();
            Console.WriteLine($"Deine Entschlüsselung: {NichtGeheim(decode, (int) key)}");
        }
        
        private static string Geheim(string input, int key)
        {
            var pages = Convert.ToInt32(Math.Ceiling(input.Length / Convert.ToDouble(key)));
            var array = new char[pages, key];
            var pageIndex = 0;
            var charIndex = 0;
            
            foreach (var character in input)
            {
                array[pageIndex, charIndex] = character;
                charIndex += 1;

                if (charIndex != key) continue;
                pageIndex += 1;
                charIndex = 0;
            }

            var code = "";
            for (var i = 0; i < key; i++)
            {
                for (var j = 0; j < pages; j++)
                {
                    var character = array[j, i];
                    if (character != 0)
                    {
                        code = $"{code}{character.ToString()}";
                    }
                }
            }

            return code;
        }

        private static string NichtGeheim(string input, int key)
        {
            var pages = Convert.ToInt32(Math.Ceiling(input.Length / Convert.ToDouble(key)));
            var array = new char[pages, key];
            var pageIndex = 0;
            var charIndex = 0;

            foreach (var character in input)
            {
                array[pageIndex, charIndex] = character;
                pageIndex += 1;
                
                if (pageIndex != pages) continue;
                pageIndex = 0;
                charIndex += 1;
            }
            
            var code = "";
            for (var i = 0; i < pages; i++)
            {
                for (var j = 0; j < key; j++)
                {
                    var character = array[i, j];
                    if (character != 0)
                    {
                        code = $"{code}{character.ToString()}";
                    }
                }
            }

            return code;
        }

        public string GetName()
        {
            return "Skytale";
        }
    }
}