namespace Brute_Force
{
    class Program
    {
        public static void Main()
        {
            /******************************************************************* 
            ******************** Hilfe ***************************************
            ******************************************************************* 
            *
            *  Die Funktion unten erwartet einen String als Eingabe und gibt anschließend
            *  "true" oder "false" zurück. Sie können damit das Passwort testen.
            *  Console.WriteLine(PassWordManager.PassWordCheck.CheckPassWordTest("1234"));  -> true
            *  Console.WriteLine(PassWordManager.PassWordCheck.CheckPassWordTest("1235"));  -> false
            *  
            *  Wenn Sie sich sicher sind, können Sie den Hinweis mit folgender Funktion abfragen.
            *  Console.WriteLine(PassWordManager.PassWordCheck.GetSecretTest("1234"));      -> Hinweis..
            *
            *  Viel Glück!
            */


            Console.WriteLine("Wir übergeben 1234 als Passwort und testen es.\n" +
                               PassWordManager.PassWordCheck.CheckPassWordTest("1234") +
                                "\nWir haben ein True erhalten und können nun den Hinweis anfordern\n" +
                                PassWordManager.PassWordCheck.GetSecretTest("1234") + "\n");





            /******************************************************************* 
             ******************** Low ***************************************
             ******************************************************************* 
             *
             *
             * Das Passwort besteht aus reinen Zahlen. 
             * Versuchen Sie es zu lösen - Viel Glück!
             * */

            // PassWordManager.PassWordCheck.CheckPassWordLow();
            // PassWordManager.PassWordCheck.GetSecretLow();


            /******************************************************************* 
             ******************** Medium ***************************************
             ******************************************************************* 
             *
             *
             * "krokodil" ist ein Bestandteil des Passworts und vorgegeben. Der Rest des Passworts besteht aus Zahlen -> z.B. 1234krokodil oder krokodil12345.
             * Viel Glück!
             */

            // PassWordManager.PassWordCheck.CheckPassWordMedium();
            // PassWordManager.PassWordCheck.GetSecretMedium();



            /******************************************************************* 
             ******************** SCHWER ***************************************
             ******************************************************************* 
             *
             *
             *  Das Passwort besteht aus Zahlen, Klein- und Großbuchstaben. 
             *  Versuchen Sie es zu lösen - Viel Glück!
             */

            // PassWordManager.PassWordCheck.CheckPassWordHard();
            //PassWordManager.PassWordCheck.GetSecretHard();

        }
    }
}
