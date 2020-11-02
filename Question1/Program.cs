using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Receives Input from user and converts to lower case
            Console.Write("Input the string: ");
            string input = Console.ReadLine().ToLower();

            // Groups the input string by character then converts to a list
            IEnumerable<IGrouping<char, char>> groupedInput = input.GroupBy(i => i);
            List<IGrouping<char, char>> listInput = groupedInput.ToList();


            if (string.IsNullOrWhiteSpace(input))
            {
                // Checks for empty or null inputs
                Console.WriteLine("Empty String");
            } else
            {
                // Outputs each character with it's number of repititions
                Console.WriteLine("The frequency of characters are :");
                foreach (IGrouping<char, char> c in listInput)
                {
                    Console.WriteLine("Character " + c.Key + ": " + c.Count() + " times");
                }
            }
            Console.ReadKey();
        }
    }
}
