using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconOvning2;

internal class Cinema
{
    /// <summary>
    /// /// Constants for age and price categories.
    /// </summary>
    private const int MIN_AGE = 5;
    private const int MAX_AGE = 100;
    private const int YOUTH_AGE = 20;
    private const int SENIOR_AGE = 64;
    private const int YOUTH_PRICE = 80;
    private const int SENIOR_PRICE = 90;
    private const int STANDARD_PRICE = 120;

    /// <summary>
    /// Displays the cinema menu and allows the user to choose between checking the price for a single person or a group.
    /// </summary>
    public static void Menu()
    {
        bool isRunning = true;

        do
        {
            Console.Clear();

            Console.WriteLine("### CINEMA ### \n" +
                "1: Check price for a single person. \n" +
                    "2: Check price for a group. \n" +
                    "0: Back to main menu. \n");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    PriceForOnePerson();
                    break;
                case "2":
                    PriceForGroup();
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
    /// Checks the price for a single person based on their age.
    /// </summary>
    private static void PriceForOnePerson()
    {
        bool isRunning = true;

        do
        {
            Console.Clear();
            Console.Write("### CINEMA SINGLE ### \n" +
                "Check price for a single person. \n" +
                "Please enter your age: ");
            string input = Console.ReadLine();
            if (uint.TryParse(input, out uint age))
            {
                if (age < MIN_AGE || age > MAX_AGE)
                {
                    Console.WriteLine("You are free to enter the cinema!");
                }
                else if (age < YOUTH_AGE)
                {
                    Console.WriteLine($"Youth price: {YOUTH_PRICE}kr");
                }
                else if (age > SENIOR_AGE)
                {
                    Console.WriteLine($"Senior price: {SENIOR_PRICE}kr");
                }
                else
                {
                    Console.WriteLine($"Standard price: {STANDARD_PRICE}kr");
                }
                Console.ReadLine();
                isRunning = false;
            }
            else
            {
                Console.WriteLine("Invalid input. only whole number is accepted.");
                Console.ReadLine();
            }

        }
        while (isRunning);

    }


    /// <summary>
    /// Checks the total price for a group of people based on their ages.
    /// </summary>
    private static void PriceForGroup()
    {
        bool isRunning = true;
        do
        {
            Console.Clear();
            Console.Write("### CINEMA GROUP ### \n" +
                "Check price for a group. \n" +
                "How many people are in your group? ");
            string input = Console.ReadLine();
            if (uint.TryParse(input, out uint numberOfPeople))
            {
                uint totalPrice = 0;
                for (int i = 1; i <= numberOfPeople; i++)
                {
                    Console.Write($"Enter age for person {i}: ");
                    string ageInput = Console.ReadLine();
                    if (uint.TryParse(ageInput, out uint age))
                    {
                        if (age < MIN_AGE || age > MAX_AGE)
                        {
                            totalPrice += 0;
                        }
                        else if (age < YOUTH_AGE)
                        {
                            totalPrice += YOUTH_PRICE;
                        }
                        else if (age > SENIOR_AGE)
                        {
                            totalPrice += SENIOR_PRICE;
                        }
                        else
                        {
                            totalPrice += STANDARD_PRICE;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. only whole number is accepted.");
                    }
                }
                Console.WriteLine($"Total number of people: {numberOfPeople}");
                Console.WriteLine($"Total cost for the group: {totalPrice}kr");
                Console.ReadLine();
                isRunning = false;
            }
            else
            {
                Console.WriteLine("Invalid input. only whole number is accepted.");
                Console.ReadLine();
            }
        } while (isRunning);
    }
}

