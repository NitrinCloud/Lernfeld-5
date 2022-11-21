using System;
using TaskSystem;

namespace Dice
{
    public class DiceTaskProcess: ITaskProcessor
    {
        public void Process()
        {
            var random = new Random();
            var playerOne = 0;
            var playerTwo = 0;

            do
            {
                playerOne += random.Next(1, 6);
                playerTwo += random.Next(1, 6);
                Console.WriteLine($"Spieler Eins: {playerOne.ToString()}");
                Console.WriteLine($"Spieler Zwei: {playerTwo.ToString()}");
            } while (playerOne != playerTwo);
            Console.WriteLine($"Die Spieler haben das gleiche Ergebnis: {playerOne.ToString()} : {playerTwo.ToString()}");
        }

        public string GetName()
        {
            return "DiceTask";
        }
    }
}