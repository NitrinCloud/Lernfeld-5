using System;
using System.Linq;
using System.Text.RegularExpressions;
using TaskSystem;

namespace MagicNumber
{
    public class MagicNumberTaskProcessor: ITaskProcessor
    {
        public void Process()
        {
            Console.WriteLine($"Der geheime Code lautet: {GetMagicNumber(182).ToString()}");
            
            int? number = null;
            while (number == null)
            {
                Console.WriteLine("Gebe dein Zahl ein...");
                var line = Console.ReadLine() ?? throw new InvalidOperationException();

                if (Regex.IsMatch(line, @"^\d+$"))
                {
                    number = int.Parse(line);
                }
            }
            
            Console.WriteLine($"Deine MagicNumber ist {GetMagicNumber((int) number).ToString()}");
        }

        private static int GetMagicNumber(int number)
        {
            return number.ToString().Sum(character => Convert.ToInt32(character.ToString()));
        }

        public string GetName()
        {
            return "MagicNumber";
        }
    }
}