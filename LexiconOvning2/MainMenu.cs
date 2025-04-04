using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconOvning2;


internal class MainMenu
{
    /// <summary>
    /// This class contains the main menu for the program, allowing users to choose between different functions.
    /// </summary>
    public static void Run()
    {

        string mainMenuGreeting = "Welcome to the main menu! \n" +
            "You will now get a few options to test out some functions. \n" +
            "To toggle in the menu, press the correct number to active the desired function. \n" +
            "\n" +
            "### MAIN MENU ### \n" +
            "1: Cinema \n" +
            "2: Repeat message\n" +
            "3: The third word\n" +
            "4: Working with stringbuilder!\n" +
            "0: Exit program";

        bool isRunning = true;
        while (isRunning)
        {
            Console.Clear();
            Console.WriteLine(mainMenuGreeting);

            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Cinema.Menu();
                    break;
                case "2":
                    Repeat.Menu();
                    break;
                case "3":
                    ThirdWord.Run();
                    break;
                case "4":
                    WorkingWithStringBuilder.Menu();
                    break;
                case "0":
                    Console.WriteLine("Exiting program...");
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Wrong input, please try again.");
                    break;
            }
            Console.ReadLine();

        }

    }
}
