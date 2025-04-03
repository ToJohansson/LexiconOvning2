// See https://aka.ms/new-console-template for more information
using LexiconOvning2;


string mainMenuGreeting = "Welcome to the main menu! \n" +
    "You will now get a few options to test out some functions. \n" +
    "To toggle in the menu, press the correct number to active the desired function. \n" +
    "\n" +
    "### MAIN MENU ### \n" +
    "1: Cinema. \n" +
    "2: Repeat message." +
    "0: Exit program.";

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

