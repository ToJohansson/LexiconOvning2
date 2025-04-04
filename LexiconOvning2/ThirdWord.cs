using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconOvning2;

internal class ThirdWord
{
    /// <summary>
    /// This class contains a method to extract and display the third word from a user-provided sentence.
    /// </summary>
    public static void Run()
    {
        bool isRunning = true;
        while (isRunning)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the --> THIRD WORD <-- function!\n" +
                "\n" +
                "The function will display the third word from your sentence, \n" +
                "Please enter a sentence with atleast 3 words.\n");

            Console.Write("Your sentence: ");
            string input = Console.ReadLine();
            string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (words.Length >= 3)
            {
                Console.WriteLine($"The third word in your sentence is: {words[2]}");
                isRunning = false;
            }
            else
            {
                Console.WriteLine("You failed to give a sentence with three words, please try again.");
            }
        }
        Console.ReadLine();
    }
}

