using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconOvning2
{
    internal class Repeat
    {
        /*
         * Menyval 2: Upprepa tio gånger
        För att använda en annan typ av iteration skall ni här implementera en for-loop. Detta ska
        ni skapa för att upprepa något en användare skriver in tio gånger. Det ska alltså inte
        skrivas via tio stycken ”Console.Write(Input);” utan via en loop som gör detta tio
        gånger. För att komma till den här funktionen skall ni lägga till ett case för ”3” i er
        huvudmeny samt text som förklarar detta.
        Händelseförloppet visas nedan:
        1. Användaren anger en godtycklig text
        2. Programmet sparar texten som en variabel
        3. Programmet skriver, via en for-loop ut denna text tio gånger på rad, alltså UTAN
        radbrott. Exempel på output: 1. Input, 2. Input, 3. Input osv.
         */
        public static void Menu()
        {
            bool isRunning = true;
            do
            {
                Console.Clear();
                Console.WriteLine("### Welcome to REPEAT! ### \n" +
                    "This function will repeat your message 10 times! \n" +
                    "1: Repeat text. \n" +
                    "2: Dynamic repeat. \n" +
                    "0: Back to main menu. \n");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        RepeatText();
                        break;
                    case "2":
                        DynamicRepeat();
                        break;
                    case "0":
                        Console.WriteLine("Going back to main menu...");
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Wrong input, please try again.");
                        break;
                }
            } while (isRunning);
        }

        private static void RepeatText()
        {
            Console.Write("What message do you want to repeat?\n" +
                "Your text: ");
            string input = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                if (i == 9)
                {
                    Console.Write((i + 1) + ". " + input);
                }
                else
                {
                    Console.Write((i + 1) + ". " + input + ", ");
                }
            }
            Console.ReadLine();
        }
        private static void DynamicRepeat()
        {
            Console.Write("What message do you want to repeat?\n" +
                            "Your text: ");
            string input = Console.ReadLine();
            Console.Write("How many times do you want to repeat it? \n" +
                "Your number: ");
            string number = Console.ReadLine();
            if (!int.TryParse(number, out int repeatCount))
            {
                Console.WriteLine("Invalid input. Please enter a whole number.");
                Console.ReadLine();
                return;
            }
            for (int i = 0; i < repeatCount; i++)
            {
                if (i == (repeatCount - 1))
                {
                    Console.Write((i + 1) + ". " + input);
                }
                else
                {
                    Console.Write((i + 1) + ". " + input + ", ");
                }
            }
            Console.ReadLine();
        }

    }
}
