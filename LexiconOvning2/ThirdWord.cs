using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconOvning2;

internal class ThirdWord
{
    // This class contains a method to display the third word from a given sentence.
    public static void Run()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the third word function!\n" +
            "\n" +
            "The function will display the third word from your sentence, \n" +
            "so please enter a sentence with atleast three words.\n" +
            "Whitespace is not a word.\n");
        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("Please enter a sentence with atleast 3 words.\n" +
                "Friendly reminder, whitespace is not a word!");

            Console.Write("Your sentence: ");
            string input = Console.ReadLine();
            string[] words = input.Trim().Split(' ');
            foreach (string word in words)
            {
                if (word.Length == 0)
                {
                    Console.WriteLine("I told you! whitespace is -> NOT <- a word...jesus...");
                    break;
                }
                else
                {
                    if (words.Length >= 3)
                    {
                        Console.WriteLine($"The third word in your sentence is: {words[2]}");
                        isRunning = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You failed to give a sentence with three words, please try again.");
                        break;
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
