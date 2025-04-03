using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconOvning2;

internal class Cinema
{
    // This class contains methods to check the price for a single person and a group of people based on their ages.
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


    // Checks the price for a single person based on their age.
    private static void PriceForOnePerson()
    {
        bool isRunning = true;

        do
        {
            Console.Clear();
            Console.Write("### CINEMA ### \n" +
                "Check price for a single person. \n" +
                "Please enter your age: ");
            string input = Console.ReadLine();
            if (uint.TryParse(input, out uint age))
            {
                if (age < 5 || age > 100)
                {
                    Console.WriteLine("You are free to enter the cinema!");
                }
                else if (age < 20)
                {
                    Console.WriteLine("Youth price: 80kr");
                }
                else if (age > 64)
                {
                    Console.WriteLine("Senior price: 90kr");
                }
                else
                {
                    Console.WriteLine("Standard price: 120kr");
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


    // Checks the total price for a group of people based on their ages.
    private static void PriceForGroup()
    {
        bool isRunning = true;
        do
        {
            Console.Clear();
            Console.Write("### CINEMA ### \n" +
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
                        if (age < 5 || age > 100)
                        {
                            totalPrice += 0;
                        }
                        else if (age < 20)
                        {
                            totalPrice += 80;
                        }
                        else if (age > 64)
                        {
                            totalPrice += 90;
                        }
                        else
                        {
                            totalPrice += 120;
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

