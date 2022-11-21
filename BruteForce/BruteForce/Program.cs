using System.Security.Cryptography;
using System.Text;

namespace BruteForce;

internal static class Program
    {
        private static char[] array = new[]
        {
            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
        };
        
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

            var passwordLow = "";
            var indexLow = 0;
            
            while (!PassWordManager.PassWordCheck.CheckPassWordLow(passwordLow))
            {
                passwordLow = indexLow.ToString();
                indexLow += 1;
            }

            Console.WriteLine(PassWordManager.PassWordCheck.GetSecretLow(passwordLow));

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
            
            var passwordMedium = "krokodil";
            var indexMedium = 0;
            var runningMedium = true;

            while (runningMedium)
            {
                if (PassWordManager.PassWordCheck.CheckPassWordMedium(indexMedium.ToString() + passwordMedium))
                {
                    break;
                }
                else if (PassWordManager.PassWordCheck.CheckPassWordMedium(passwordMedium + indexMedium.ToString()))
                {
                    break;
                }
                indexMedium += 1;
            }

            if (PassWordManager.PassWordCheck.CheckPassWordMedium(indexMedium.ToString() + passwordMedium))
            {
                passwordMedium = indexMedium.ToString() + passwordMedium;
            }
            else if (PassWordManager.PassWordCheck.CheckPassWordMedium(passwordMedium + indexMedium.ToString()))
            {
                passwordMedium = passwordMedium + indexMedium.ToString();
            }

            Console.WriteLine(PassWordManager.PassWordCheck.GetSecretMedium(passwordMedium));

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

            Console.WriteLine(PassWordManager.PassWordCheck.GetSecretHard(GetPasswordHard()));
        }

        private static string GetPasswordHard()
        {
            StringBuilder builder = new StringBuilder();
            
            while (!PassWordManager.PassWordCheck.CheckPassWordHard(builder.ToString()))
            {
                Increment(builder, 0);
            }

            return builder.ToString();
        }

        private static void Increment(StringBuilder builder, int index)
        {
            if (index == builder.Length)
            {
                builder.Append(array[0]);
            }
            
            var character = builder[index];

            if (character == array[^1])
            {
                builder[index] = array[0];
                
                Increment(builder, index + 1);
            }
            else
            {
                builder[index] = array[GetIndex(character) + 1];
            }
        }

        private static int GetIndex(char character)
        {
            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] == character)
                {
                    return i;
                }
            }

            throw new Exception();
        }
    }

