using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconOvning2;

internal class Repeat
{
    /// <summary>
    /// This class contains methods to repeat a message a specified number of times.
    /// </summary>
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

    /// <summary>
    /// Repeats the user's input text 10 times.
    /// </summary>
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
    /// <summary>
    /// Repeats the user's input text a specified number of times.
    /// </summary>
    private static void DynamicRepeat()
    {
        Console.Write("What message do you want to repeat?\n" +
                        "Your text: ");
        string input = Console.ReadLine();

        Console.Write("How many times do you want to repeat it? \n" +
            "Your number: ");
        string number = Console.ReadLine();

        if (!uint.TryParse(number, out uint repeatCount))
        {
            Console.WriteLine("Invalid input. Please enter a whole number.");
            Console.ReadLine();
            return;
        }
        // creates a list of strings with the repeated message
        string result = string.Join(", ", Enumerable.Range(1, (int)repeatCount).Select(i => $"{i}. {input}"));
        Console.WriteLine(result);
        Console.ReadLine();
    }

}
