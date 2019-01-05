using System;

namespace ThisAndThat
{
    class Program
    {
        static void Main(string[] args)
        {
            NewMethod("rthids", "urejdn");
        }

        private static void NewMethod(string str1, string str2)
        {
            str1.ToCharArray();
            str2.ToCharArray();

            int[] difference = new int[str1.Length];

            for (int i = 0; i < str1.Length; i++)
            {
                difference[i] = str1[i] - str2[i];
            }

            int sum = 0;
            
            foreach (var VARIABLE in difference)
            {
                Console.WriteLine(VARIABLE);
            }

            foreach (var VARIABLE in difference)
            {
                sum += VARIABLE;
            }

            Console.WriteLine(sum);
        }
    }
}