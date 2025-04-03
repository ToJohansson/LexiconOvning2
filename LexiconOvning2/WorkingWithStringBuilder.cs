using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconOvning2
{
    internal class WorkingWithStringBuilder
    {
        /*
        This class contains methods to demonstrate the use of StringBuilder for string manipulation.
        It includes methods to create a StringBuilder, append text, and display the result.
        It will time the process of appending text to a StringBuilder and a string.
        And compare the performance of both methods.
        Who will win! 
         */
        public static void Menu()
        {
            // menu for the stringbuilder function
            bool isRunning = true;
            do
            {
                Console.Clear();
                Console.WriteLine("### WORKING WITH STRINGBUILDER ### \n" +
                    "1: StringBuilder vs String concatination <---\n" +
                    "0: Go back to main menu");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        ComparePerformance();
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

        private static void ComparePerformance()
        {
            Console.Clear();
            // stringbuilder vs string performance comparison
            // create a stringbuilder
            StringBuilder sb = new StringBuilder();
            sb.Append("start");
            // create a string
            string str = "start";
            // create a stopwatch
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            // start the stopwatch
            Console.WriteLine("StringBuilder: Starting the stopwatch...");
            stopwatch.Start();
            // append text to stringbuilder
            for (int i = 0; i < 100000; i++)
            {
                if (i == 50000)
                {
                    Console.WriteLine("\n" +
                        "Half way and pretty fast!\n");
                }
                sb.Append(i);
            }
            sb.Append("end");
            // stop the stopwatch
            stopwatch.Stop();
            var sbTime = stopwatch.ElapsedMilliseconds;
            Console.WriteLine($"Time it took to append text to StringBuilder: {sbTime} ms\n");
            // Restart the stopwatch
            Console.WriteLine("String concatination: Starting the stopwatch...");
            stopwatch.Restart();
            // append text to string
            for (int i = 0; i < 100000; i++)
            {
                if (i == 50000)
                {
                    Console.WriteLine("\n" +
                        "Working....Working....\n" +
                        "Just wait a bit longer....\n" +
                        "Almost done....\n");
                }
                str += i;
            }
            str += "end";
            // stop the stopwatch
            stopwatch.Stop();
            var strTime = stopwatch.ElapsedMilliseconds;
            // print the time it took to append text to string
            Console.WriteLine($"Time it took to append text to string: {strTime} ms\n");
            Console.WriteLine("*** FINAL RESULT ***");

            Console.WriteLine($"StringBuilder : {sbTime}ms");
            Console.WriteLine($"String: {strTime}ms");
            Console.ReadLine();
        }


    }
}
