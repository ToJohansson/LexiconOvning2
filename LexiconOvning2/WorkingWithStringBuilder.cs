using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconOvning2
{
    internal class WorkingWithStringBuilder
    {
        public static void Run()
        {
            ComparePerformance();
        }
        /// <summary>
        /// This method compares the performance of StringBuilder and string concatenation by measuring the time taken to append text to each.
        /// </summary>
        private static void ComparePerformance()
        {
            Console.Clear();
            const double TO_SEC = 1000; // Conversion factor from milliseconds to seconds
            const int ITERATIONS = 150000; // Number of iterations for the test
            Console.WriteLine("### COMPARING STRINGBUILDER AND STRING CONCATENATION ###\n" +
                "This test will compare the performance of StringBuilder and string concatenation.\n" +
                "It will measure the time taken to append text to each.\n" +
                $"Iteration is now set to: {ITERATIONS:n0} times.\n");
            // Create a StringBuilder and a string to compare
            StringBuilder sb = new StringBuilder();
            sb.Append("start");

            string str = "start";

            // Create a stopwatch to measure elapsed time
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();

            // StringBuilder performance
            Console.WriteLine("StringBuilder: Starting the stopwatch...");
            stopwatch.Start();

            // Append text to StringBuilder
            for (int i = 0; i < ITERATIONS; i++)
            {
                sb.Append(i);
            }

            sb.Append("end");
            stopwatch.Stop();
            var sbTime = stopwatch.ElapsedMilliseconds;
            Console.WriteLine($"Time it took to append text to StringBuilder: {sbTime} ms\n");

            // Reset stopwatch and measure string concatenation performance
            Console.WriteLine("String concatenation: Starting the stopwatch...");
            stopwatch.Restart();

            // Append text to string using string concatenation
            for (int i = 0; i < ITERATIONS; i++)
            {
                str += i;  // Inefficient string concatenation
            }

            str += "end";
            stopwatch.Stop();
            var strTime = stopwatch.ElapsedMilliseconds;

            // Print the time taken for string concatenation
            Console.WriteLine($"Time it took to append text to string: {strTime} ms\n");

            double sbTimeSec = sbTime / TO_SEC;
            double strTimeSec = strTime / TO_SEC;
            // Final result comparison
            Console.WriteLine("*** FINAL RESULT ***");
            Console.WriteLine($"StringBuilder: {sbTimeSec:f4} sek");
            Console.WriteLine($"String concatenation: {strTimeSec:f4} sek");

            Console.ReadLine();
        }



    }
}
