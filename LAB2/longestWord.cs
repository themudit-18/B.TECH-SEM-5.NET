using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    internal class longestWord
    {
        public void longString()
        {
            Console.WriteLine("Enter a string to find the longest word:");
            string input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input))
            {
                string longestWord = FindLongestWord(input);
                Console.WriteLine("Longest Word: " + longestWord);
            }
            else
            {
                Console.WriteLine("Please enter a valid string.");
            }
        }

        static string FindLongestWord(string input)
        {
            string[] words = input.Split(new[] { ' ', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            return words.OrderByDescending(word => word.Length).FirstOrDefault();
        }
    }
}

