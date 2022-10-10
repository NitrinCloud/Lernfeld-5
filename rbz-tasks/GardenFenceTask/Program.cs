using System;

namespace GardenFenceTask
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var firstGeheim = Geheim("HABEAMSONNTAGKEINEZEITMUSSLERNENSORRY");

            Console.WriteLine($"Der geheime Code lautet: {firstGeheim}");
        
            var secondGeheim = NichtGeheim("LEEMTEOAEENLMTITROLNIBRIVRNKGLASIDEEBHE");
        
            Console.WriteLine($"Der nicht mehr geheime Code lautet: {secondGeheim}");
        
        
            var thirdGeheim = NichtGeheim("AMTWCFLEDERTNWITNEASMITOHALNIESEZESUDNU");
        
            Console.WriteLine($"Der nicht mehr geheime Code lautet: {thirdGeheim}");
        
            Console.WriteLine("Gebe dein Text zur Verschlüsselung ein...");
            var encode = Console.ReadLine() ?? throw new InvalidOperationException();
            Console.WriteLine($"Deine Verschlüsselung: {Geheim(encode)}");
        
            Console.WriteLine("Gebe dein Text zur Entschlüsselung ein...");
            var decode = Console.ReadLine() ?? throw new InvalidOperationException();
            Console.WriteLine($"Deine Entschlüsselung: {NichtGeheim(decode)}");
        }
        
        private static string Geheim(string input)
        {
            var first = "";
            var second = "";
            for (var i = 0; i < input.Length; i++)
            {
                var character = input[i];
                if (i % 2 == 0)
                {
                    first = $"{first}{character}";
                }
                else
                {
                    second = $"{second}{character}";
                }
            }
            return $"{first}{second}";
        }

        private static string NichtGeheim(string input)
        {
            var inputLength = input.Length / 2;
            var length = inputLength + input.Length % 2;

            var output = "";
            for (var i = 0; i < length; i++)
            {
                output = $"{output}{input[i]}";

                if (i < inputLength)
                {
                    output = $"{output}{input[length + i]}";
                }
            }
            return output;
        }
    }
}