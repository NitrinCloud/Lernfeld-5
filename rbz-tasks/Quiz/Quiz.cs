using System;
using System.Linq;
using TaskSystem;

namespace Quiz
{
    public class QuizTaskProcessor: ITaskProcessor
    {
        public void Process()
        {
            Console.WriteLine("Ausflugsplanung");
            Console.WriteLine("---------------");
            Console.WriteLine();
            Console.WriteLine();
            
            var wochentag =
                new Question("Planes Sie, ihren Ausflug an einem Wochenende durchzuführen?", 
                    new[] { "Wochenende", "Wochentag" }).AskConsole().GetAnswer() == "Wochenende";
            var wochenEnde = !wochentag;
            var schoenWetter =
                new Question("Bei welchem Wetter planen Sie, ihren Ausflug durchzuführen?", 
                    new[] { "Sonne", "Regen" }).AskConsole().GetAnswer() == "Sonne";
            var schlechtWetter = !schoenWetter;
            var ferien =
                new Question("Planen Sie, ihren Ausflug in den Ferien durchzuführen?", 
                    new[] { "Ferien", "Schule" }).AskConsole().GetAnswer() == "Ferien";
            var schulzeit = !ferien;
            var tagsueber = 
                new Question("Planen Sie, ihren Ausflug Tagsüber durchzuführen?", 
                    new[] { "Tag", "Abend" }).AskConsole().GetAnswer() == "Tag";
            var abends = !tagsueber;
            var nurErwachsene = 
                new Question("Planen Sie, einen Ausflug mit oder für Kinder organisieren?", 
                    new[] { "j", "n" }).AskConsole().GetAnswer() != "j";
            
            var kegeln            = abends || wochenEnde;
            var freibad           = schoenWetter && tagsueber;
            var hallenbad         = !(ferien && wochenEnde);
            var musik             = abends && schulzeit;
            var brotbackkurs      = wochenEnde && schlechtWetter;
            var schieferbergwerk  = tagsueber || (wochenEnde && ferien);
            var goKurse           = (wochenEnde && schlechtWetter) || (wochentag && abends && schoenWetter);
            var billard           = nurErwachsene && (abends || wochenEnde);
            var rennauto          = nurErwachsene && tagsueber && ferien && wochenEnde;
            var openAirKino       = schoenWetter && (abends || wochenEnde);
            var korbflechten      = ferien && schlechtWetter && wochentag;

            Console.WriteLine();
            Console.WriteLine("---------------");
            Console.WriteLine();
            if (kegeln) Console.WriteLine("Kegeln");
            if (freibad) Console.WriteLine("Freibad");
            if (hallenbad) Console.WriteLine("Hallenbad");
            if (freibad) Console.WriteLine("Wandern im Dunkelwald");
            if (musik) Console.WriteLine("Musik");
            if (brotbackkurs) Console.WriteLine("Brotbackkurs");
            if (schieferbergwerk) Console.WriteLine("Schieferbergwerk");
            if (goKurse) Console.WriteLine("Go Kurs");
            if (billard) Console.WriteLine("Billiard");
            if (rennauto) Console.WriteLine("Rennauto");
            if (openAirKino) Console.WriteLine("Open-Air Kino");
            if (korbflechten) Console.WriteLine("Korbflechten");
            if (tagsueber) Console.WriteLine("Besuch des Wasserfalls");
            Console.WriteLine("Zoobesuch");
        }

        public string GetName()
        {
            return "Quiz";
        }
    }

    public class Question
    {
        private readonly string _question;
        private readonly string[] _answers;
        private string _answer;

        public Question(string question, string[] answers)
        {
            _question = question ?? throw new ArgumentNullException(nameof(question));
            _answers = answers ?? throw new ArgumentNullException(nameof(answers));
        }

        public Question AskConsole()
        {
            while (_answer == null)
            {
                Console.WriteLine(_question);
                Console.WriteLine($"[{string.Join(", ", _answers)}]");
                var cache = Console.ReadLine() ?? throw new InvalidOperationException();
                
                if (_answers.Contains(cache))
                {
                    _answer = cache;
                }
            }
            return this;
        }

        public string GetAnswer()
        {
            if (_answer == null)
            {
                throw new InvalidOperationException("Frage ist noch nicht beantwortet");
            }
            return _answer;
        }
    }
}