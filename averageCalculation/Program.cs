using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace averageCalculation
{
    class Program
    {
        static void Main()
        {
            var totalNumber = 0.0;
            var totalEntries = 0.0;

            while (true)
            { 

                Console.Write("Enter a number or type \"done\" to see the average:");
                var entry = Console.ReadLine();

                try
                {
                    if (entry.ToLower() == "done")
                    {
                        var calculation = totalNumber/totalEntries;

                        Console.WriteLine("Your average is: " + calculation);
                        break;
                    }

                    totalNumber += double.Parse(entry);

                    if (Double.Parse(entry) <= 0)
                    {
                        Console.WriteLine("0 is not a valid input!");
                        continue;
                    }

                    Console.WriteLine("You have entered: " + entry + " and your total is: " + totalNumber);

                    totalEntries += 1.0;

                }
                catch (FormatException)
                {
                    Console.WriteLine("Input is not valid");
                    continue;
                }

            }

            Console.WriteLine("Goodbye");

        }
    }
}
