using System;

namespace PracticeTask
{
    internal static class Program
    {
        public static void Main()
        {
            Process();
        }
        
        public static void Process()
    {
        //Programmcode wird in diesem Block ausgeführt
            //Die Ausführung erfolgt von oben nach unten
            //Linkshiervon darf Code stehen

            /*
             * Mehrzeilige
             * Kommentare
             * sehen so aus.
             */
            
            //In jeder Zeile schreibt man normalerweise eine Anweisung
            //Anweisung dürfen auch mehrzeilig sein.
            //Jede Anweisung wird beendet von einem Semikolon ;
            
            Console.WriteLine("Bier und Pizza");

            // Aufgabe 2
            PrintTask(2);
            Console.WriteLine(15+3);
            Console.WriteLine(437-87);
            
            // Aufgabe 3
            PrintTask(3);
            ProcessWood(7, 2);
            
            // Aufgabe 4
            PrintTask(4);
            
            /*
             * A...
             * 5
             * 3
             * 10
             * 0
             */
            
            /*
             * B geht nicht, man kann nicht durch 0 teilen
             */
            
            //C...
            Console.WriteLine(13/2);
            Console.WriteLine(21/5);
            Console.WriteLine(27/5);
            Console.WriteLine(7/2);
            
            //D...
            Console.WriteLine(13%2);
            Console.WriteLine(21%5);
            Console.WriteLine(27%5);
            Console.WriteLine(7%2); // Gibt den Rest nach Division aus
            
            // Aufgabe 5
            PrintTask(5);
            ProcessWood(713, 13);
            
            // Aufgabe 6
            PrintTask(6);
            ProcessTimeHours(0, 143);
            
            // Aufgabe 7
            PrintTask(7);
            ProcessTimeHours(14, 17);
            
            /*
             * Aufgabe 8
             * Write schreibt nur und WriteLine schreibt mit einer neuen Zeile am Ende
             */
            
            // Aufgabe 9
            PrintTask(9);
            Console.WriteLine(6.09/5.076);
            Console.WriteLine(4.72+18.32);
            Console.WriteLine(345.32-56.3);
            
            Console.WriteLine((14.75+17.5)%24);
            
            // Aufgabe 10
            PrintTask(10);
            Console.WriteLine(8.5/2.5);
            
            // Aufgabe 11
            PrintTask(11);
            ProcessWood(2.5, 1.2);
            
            // Aufgabe 12
            PrintTask(12);
            Console.WriteLine(2.5/1.2);
            Console.WriteLine(2.5%1.2);
            
            // Aufgabe 13
            PrintTask(13);
            ProcessWood(734.5, 13.2);
            
            // Aufgabe 14
            PrintTask(14);
            ProcessTimeHours(14.75, 17.5);
            
            // Aufgabe 15
            PrintTask(15);
            var meineZahl = 5;
            var meineZweiteZahl = 10;
            
            // a
            Console.WriteLine(meineZahl+meineZweiteZahl); 
            Console.WriteLine(meineZahl-meineZweiteZahl);
            Console.WriteLine(meineZahl*meineZweiteZahl); 
            Console.WriteLine(meineZahl/meineZweiteZahl);
            Console.WriteLine(meineZahl%meineZweiteZahl);

            // b
            meineZahl += 3;
            Console.WriteLine(meineZahl);
            
            // Aufgabe 16
            PrintTask(16);
            // 9
            
            // Aufgabe 17
            PrintTask(17);
            // 50
            int meineDritteZahl; 
            meineDritteZahl = 5; 
            int meineVierteZahl; 
            meineVierteZahl = 10; 
            meineDritteZahl *= meineVierteZahl; 
            meineDritteZahl -= 10;
            meineVierteZahl += meineDritteZahl;
            Console.WriteLine("Erste " + meineDritteZahl);
            Console.WriteLine("Zwite " + meineVierteZahl);
            
            // Aufgabe 18
            PrintTask(18);
            
            // a
            var balance = 0;
            balance += 27 * 5; // Einzahlung
            balance += 3 * 6; // Verspätung
            balance -= 30; // Bastel
            balance -= 60; // Schwimmbad
            Console.WriteLine($"Es bleiben über: {balance}");

            // b
            var perUser = balance/30;
            var leftOver = balance%30;
            Console.WriteLine($"Jeder kriegt: {perUser}");
            Console.WriteLine($"Bleibt über: {leftOver}");
            
            // c
            Console.WriteLine($"Jeder kriegt mit Rest: {perUser + (Convert.ToDouble(leftOver)/30)}");

            // Aufgabe 19
            PrintTask(19);
            const int mine = 5;
            const int yours = 10;
            
            Console.WriteLine(mine < yours);
            Console.WriteLine(mine > yours);
            Console.WriteLine(mine == 8);
            Console.WriteLine(yours == 5);
            
            // Aufgabe 20
            PrintTask(20);
            
            Console.WriteLine(mine != yours);
            Console.WriteLine(mine >= yours);
            
            // Aufgabe 21
            PrintTask(21);

            var playerOne = 0;
            var playerTwo = 0;

            playerOne += 10;
            playerTwo += 5;
            playerOne -= 3;
            playerTwo *= 2;
            playerOne += 11;
            playerTwo -= 1;
            playerOne += playerTwo;
            playerOne -= 9;
            playerTwo += 9;
            
            Console.WriteLine(playerOne == playerTwo);
            Console.WriteLine(playerOne > playerTwo);
            Console.WriteLine(playerOne > 20);
            Console.WriteLine(playerTwo > 20);
            
            // Aufgabe 22
            PrintTask(22);

            // a
            const double doubleOne = 10.1;
            const double doubleTwo = 10.5;
            const double doubleThree = 10.2;
            
            // b
            const double middleOne = (doubleOne+doubleTwo+doubleThree)/3;
            Console.WriteLine(middleOne);

            const double middleTwo = (9.9 + 10.3 + 10.4) / 3;
            
            Console.WriteLine(middleTwo == middleOne);
            Console.WriteLine(middleTwo > middleOne);
            Console.WriteLine(middleTwo < middleOne);
            
            // Aufgabe 23
            PrintTask(23);

            /*
             * int id = 0.5;
             * Es ist nicht möglich, da C# nicht automatisch auf-, beziehungsweise abrunded
             */
            
            /*
             * double number = 7;
             * Ist möglich, da es keinen Unterschied macht, ob nach dem Komma 0 kommt oder eine andere Zahl
             */
            
            // Aufgabe 24
            PrintTask(24);
            
            Console.WriteLine(5<13.2);
            
            // Aufgabe 25
            PrintTask(25);
            SimulateConsole();
    }

        private static void PrintTask(int task)
    {
     Console.WriteLine($"Aufgabe {task}:");
    }

    private static void ProcessWood(double amount, double decrement)
    {
     var counter = 0;

     while (amount >= decrement)
     {
      amount -= decrement;
      counter++;
     }
            
     Console.WriteLine($"There are {counter} pieces and {amount} are left");
    }

    private static void ProcessTimeHours(double currentTime, double timeToGo)
    {
     while (timeToGo >= 24)
     {
      timeToGo -= 24;
     }
     currentTime += timeToGo;
     if (currentTime > 24)
     {
      currentTime -= 24;
     }
     Console.WriteLine($"Current time: {currentTime}:00");
    }

    private static void SimulateConsole()
    {
     var running = true;
     var counter = 0;
     while (running)
     {
      counter += 1;
      Console.WriteLine($"Counter = {counter}");
      if (counter == 10)
      {
       running = false;
      }
     }
    }
    }
}