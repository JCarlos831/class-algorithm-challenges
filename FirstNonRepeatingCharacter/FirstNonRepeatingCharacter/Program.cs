// Given a string provide the first non repeating character
// if no repeating character provide an underscore

using System;
using System.Collections.Generic;

namespace FirstNonRepeatingCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            FindFirstNonRepeatingChar("abab");
        }

        private static void FindFirstNonRepeatingChar(string str)
        {
            var uniques = new List<char>();
            while (str.Length > 0)
            {
                var count = 0;
                foreach (var letter in str)
                {
                    if (str[0] == letter)
                    {
                        count++;
                    }
                }                
                if (count == 1)
                    uniques.Add(str[0]);

                str = str.Replace(str[0].ToString(), string.Empty);
            }

            if (uniques.Count > 0)
            {
                Console.WriteLine(uniques[0]);
                return;
            }

            Console.WriteLine('_');
        }
    }
}